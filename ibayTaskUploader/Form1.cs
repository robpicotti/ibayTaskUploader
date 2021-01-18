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
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "Please remember to remove all commas from task descriptions, opportunity descriptions, etc. And also no RETURN keys to make 2 lines for the former";
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
                errTask = objTask.loadTasks(objTask);
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
    }
}
