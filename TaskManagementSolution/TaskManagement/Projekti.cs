using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Projekti
    {

        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public  List<Task> tasqet { get; set; }


        public Projekti()
        {




        }



    }
}
