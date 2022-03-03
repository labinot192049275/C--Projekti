using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagement
{
    public class Goal
    {


        public int id { get; set; }

        public String emri { get; set; }
        public string pershkrimi { get; set; }

        public Goal(int id, string emri,string pershkrimi)
        {
            this.id = id;  
            this.emri = emri;
            this.pershkrimi = pershkrimi;   
        }




        public override string ToString()
        {
            return "Goal me id: " + id + " me emer, " + emri + ". \nPershkrimi: " + pershkrimi;
        }



    }
}
