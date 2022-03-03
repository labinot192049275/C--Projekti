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
       
        List<Goal> qellimet=new List<Goal>();   

        
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


        public void shtoQellimet(Goal g)
        {

            if (qellimet.Contains(g))
            {
                Console.WriteLine("Egziston qellimi ---> "+g.ToString());

            }

            else if (g==null)
            {

                Console.WriteLine("Vlerat null nuk lejohen");

            }

            else
            {

                qellimet.Add(g);    
            }

        }

        public void shtypQellimet()
        {


            foreach (var item in qellimet)
            {

                Console.WriteLine(item);

            }


        }





    }
}
