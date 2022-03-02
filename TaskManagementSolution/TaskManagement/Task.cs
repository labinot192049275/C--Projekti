using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public int taskID { get; set; }
        public  string pershkrimi{ get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }


        public Task(int id,string pershkrimi,DateTime startDate,DateTime endDate)
        {

            this.taskID = id; 
            this.pershkrimi = pershkrimi; 
            this.startDate = startDate;
            this.endDate = endDate;

        }
        public Task()
        {

        }

       

    }
}
