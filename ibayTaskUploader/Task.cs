using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ibayTaskUploader
{
    public class Task
    {
        private DB db = new DB();
        public List<Task.TaskItem> item { get; set; }
        public Task parseTasks(DataTable table)
        {
            Task objTask = new Task();

            for(int i=0; i < table.Rows.Count;i++)
            {
                Task.TaskItem objTaskItem = new Task.TaskItem();
                if (table.Rows[i][0] != null) { objTaskItem.trackedBy = table.Rows[i][0].ToString();   }
                if (table.Rows[i][1] != null) { objTaskItem.task = table.Rows[i][1].ToString(); }
                if (table.Rows[i][2] != null) { objTaskItem.client = table.Rows[i][2].ToString(); }
                if (table.Rows[i][3] != null) { objTaskItem.opportunity = table.Rows[i][3].ToString(); }
                if (table.Rows[i][4] != null) 
                {
                    DateTime cdate;
                    if (DateTime.TryParse(table.Rows[i][4].ToString(), out cdate))
                    {
                        objTaskItem.createDate =cdate;
                    }
                }
                if (table.Rows[i][6] != null) 
                {
                    float est_time;
                    if (float.TryParse(table.Rows[i][6].ToString(), out est_time)) { objTaskItem.estimatedTime = est_time; } 
                }
                if (table.Rows[i][7] != null)
                {
                    float tracked;
                    if(float.TryParse(table.Rows[i][7].ToString(),out tracked)) { objTaskItem.trackedTime = tracked; }
                }
                if(table.Rows[i][8]!=null)
                {
                    string bill = "";
                    switch(table.Rows[i][8].ToString().ToUpper())
                    {
                        case "YES":
                            objTaskItem.isBillable = 1;
                            break;
                        case "NO":
                            objTaskItem.isBillable = 0;
                            break;
                    }
                }
                if (objTask.item ==null)
                {
                    objTask.item = new List<TaskItem>();
                }
                objTask.item.Add(objTaskItem);
            }
            return objTask;
        }
        public Task loadTasks(Task objTask)
        {
            Task errorTask = new Task();
            if (deleteTasks())
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
        public bool deleteTasks()
        {
            bool blnRet = false;

            blnRet = db.execSproc("p_deleteTasks", db.getSQLConn());

            return blnRet;
        }
        public class TaskItem
        {
            public string trackedBy { get; set; }
            public string task { get; set; }
            public string client { get; set; }
            public string opportunity { get; set; }
            public DateTime createDate { get; set; }
            public float estimatedTime { get; set; }
            public float trackedTime { get; set; }
            public int isBillable { get; set; }
        }

    }
}
