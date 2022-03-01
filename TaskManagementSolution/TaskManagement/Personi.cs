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

        public Personi(int id,string emri,string mbiemri,string email) { 
        
            this.ID = id;   
            this.emri = emri;
            this.mbiemri = mbiemri; 
            this.email = email;
            

        }
        public abstract string pozita();



    }
}
