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

        public void CaktoPrioritetin(List<Task> tasqet)
        {
            Task taskuMePrioritetMeTeLarte = null;
            TimeSpan time = TimeSpan.Zero;
            bool firsttime = true;

            foreach (var task in tasqet)
            {
                
                if (firsttime)
                {
                    taskuMePrioritetMeTeLarte = task;
                    time = task.endDate - task.startDate;
                    firsttime = false;
                }
                TimeSpan t1 = task.endDate - task.startDate;
                if (time > task.endDate - task.startDate)
                {
                    time = task.endDate - task.startDate;
                    //task = tasku;
                    taskuMePrioritetMeTeLarte = task;
                }


            }
            Console.WriteLine("Tasku me prioritet me te larte eshte " + taskuMePrioritetMeTeLarte.pershkrimi);
        }
    }
}
