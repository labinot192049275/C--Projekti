using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Punetori: Personi
    {

        public Lideri lideri { get; set; }

        public Punetori(int id, string emri, string mbiemri, string email,Lideri l) : base(id, emri, mbiemri, email)
        {

            this.lideri = l;


        }

        public override string pozita()
        {
            return "Punetor";
        }




    }
}
