using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Menaxheri : Personi
    {

        public List<Lideri> lideret { get; set; }

        public Menaxheri(int id, string emri, string mbiemri, string email): base(id, emri, mbiemri, email) { 
        



        }

        public override string pozita()
        {


            return "Menazher";
        }


    }
}
