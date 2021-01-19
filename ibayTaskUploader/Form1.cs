using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ibayTaskUploader
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        Task objTask = new Task();
        DataTable table = new DataTable();
        DataTable _allJobs = new DataTable();
        int _rows = 0;
        public Form1()
        {
            InitializeComponent();
            _allJobs = db.getSprocResults("get_alljobs");
            dgvAll.DataSource = _allJobs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string err="";
                Task errTask = new Task();
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    string file = openFileDialog1.FileName;
                    table = db.loadCSVToDatatable(file);
                    progressBar1.Value = 0;
                    dataGridView1.DataSource = table;
                    Cursor = Cursors.Default;
                }
            }
            catch(Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string err = "";
                Task errTask = new Task();
                objTask = objTask.parseTasks(table);
                if(objTask.item !=null )
                { 
                    _rows = objTask.item.Count;
                }
                else
                {
                    MessageBox.Show("There is no data to load. Please check the csv file","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                errTask = loadTasks(objTask);
                if (errTask.item != null)
                {
                    if (errTask.item.Count > 0) { err = " with errors. Contact admin"; }
                }
                Cursor = Cursors.Default;
                MessageBox.Show("upload complete!" + err);
            }
            catch(Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }


        private void updateProgress()
        {
            DataTable dt = db.getSprocResults("p_getTasksRowCount");
            if (dt != null)
            {
                string rows = dt.Rows[0][0].ToString();
                float complete = 0;
                bool bln = float.TryParse(rows, out complete);
                if (bln && _rows > 0)
                {
                    float tick = complete / _rows * 100;
                    progressBar1.Value = Convert.ToInt32(tick);
                    label2.Text = tick.ToString().Substring(0,5) +  "% complete";
                    label2.Refresh();
                }
            }
        }

        private Task loadTasks(Task objTask)
        {
            int counter = 0;
            Task errorTask = new Task();
            if (objTask.deleteTasks())
            {
                foreach (var item in objTask.item)
                {
                    if (item.trackedBy != "" && item.task != "" && item.client != "" && item.createDate != null && item.opportunity != "")
                    {
                        string create_date = item.createDate.ToString("yyyy-MM-dd");
                        string[,] arrParams = { { "@trackedBy", item.trackedBy }, { "@task", item.task }, { "@company",item.client},{ "@opportunity",item.opportunity},
                    { "@created_date",create_date},{"@dt",create_date },{ "@estimated_time",item.estimatedTime.ToString()},{ "@tracked_time",item.trackedTime.ToString()},
                    { "@billable",item.isBillable.ToString()} };
                        bool bln = db.execSproc("p_uploadTasks", arrParams);
                        counter++;
                        if(counter ==500)
                        {
                            updateProgress();
                            counter = 0;
                        }
                        if (bln == false)
                        {
                            if (errorTask.item == null)
                            {
                                errorTask.item = new List<Task.TaskItem>();
                            }
                            errorTask.item.Add(item);
                        }
                    }
                }
            }


            return errorTask;
        }

        private void cmdAll_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dgvAll.DataSource = db.getSprocResults("get_alljobs");
                Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvAll_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int currentMouseOverColumn = dgvAll.HitTest(e.X, e.Y).ColumnIndex;
                int irow = dgvAll.HitTest(e.X, e.Y).RowIndex;
                if(irow < 0) { return; }
                string opportunity = "";
                if (dgvAll[1, irow].Value != null)
                {
                    opportunity = dgvAll[1, irow].Value.ToString();
                    string[,] arrParams = { {"@project",opportunity } };
                    dgvOppDetail.DataSource = db.getSprocResults("p_selectOpportunities",arrParams);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                search_jobs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void search_jobs()
        {
            try
            {
                string client = txtClient.Text;
                string opp = txtOpp.Text;
                string proj_type = txtProj.Text;
                string work_type = txtWork.Text;
                DataView dv = new DataView(_allJobs);
                dv.RowFilter = string.Format("client LIKE '%{0}%' AND opportunity LIKE '%{1}%' and project_type LIKE '%{2}%' AND work_type LIKE '%{3}%'",
                    client + ((client == string.Empty) ? string.Empty : "%"),
                    opp + ((opp == string.Empty) ? string.Empty : "%"),
                    proj_type + ((proj_type == string.Empty) ? string.Empty : "%"),
                    work_type + ((work_type == string.Empty) ? string.Empty : "%"));
                dgvAll.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOpp_TextChanged(object sender, EventArgs e)
        {
            search_jobs();
        }

        private void txtProj_TextChanged(object sender, EventArgs e)
        {
            search_jobs();
        }

        private void txtWork_TextChanged(object sender, EventArgs e)
        {
            search_jobs();
        }
    }
}
