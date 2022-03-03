using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public abstract class Personi
    {

        public int ID { get; set; }
        public string emri { get; set; }
        public string mbiemri { get; set; }
        public string email { get; set; }

        public Personi(int id,string emri,string mbiemri) 
        { 
            this.ID = id;   
            this.emri = emri;
            this.mbiemri = mbiemri;           
        }
        public abstract string pozita();



    }
}
