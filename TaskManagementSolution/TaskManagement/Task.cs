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
        
        private bool statusi = false;
        public bool Statusi 
        { 
            get { return statusi;  }
            set { statusi = value; } 
        }

        public Task(int id,string pershkrimi,DateTime startDate,DateTime endDate)
        {

            this.taskID = id; 
            this.pershkrimi = pershkrimi; 
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public bool Equals(Task tasku)
        {
            if (tasku is Task)
            {
                Task task = (Task)tasku;
                return task.pershkrimi == this.pershkrimi;
            }
            return false;
        }

        public override string ToString()
        {
            string statusiTaskut = "";
            if (statusi == false)
            {
                return statusiTaskut = "i pa perfunduar";
            }
            else if (statusi == true)
            {
                return statusiTaskut="i perfunduar";
            }

            return $"Tasku {taskID} -> {pershkrimi} eshte {statusiTaskut}";
        }
        public Task()
        {

        }
    }
}
