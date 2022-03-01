using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Lideri: Personi
    {
        public Menaxheri menaxheri { get; set; }
        public List<Punetori> punetoret { get; set; }

        public Lideri(int id, string emri, string mbiemri, string email,Menaxheri m) : base(id, emri, mbiemri, email)
        {

            this.menaxheri = m; 


        }

        public override string pozita()
        {

            return "Lider";
        }

    }
}
