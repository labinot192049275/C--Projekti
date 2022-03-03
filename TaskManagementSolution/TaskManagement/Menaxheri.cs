using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Menaxheri : Personi
    {
        public List<Task> TasqetSortuara = new List<Task>();
        public List<Lideri> lideret { get; set; }
       
        List<Goal> qellimet=new List<Goal>();       

        public override string pozita()
        {
            return "Menaxher";
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
                if (time > t1)
                {
                    time = task.endDate - task.startDate;
                    taskuMePrioritetMeTeLarte = task;
                }
            }
            TasqetSortuara.Add(taskuMePrioritetMeTeLarte);
            tasqet.Remove(taskuMePrioritetMeTeLarte);

            while (tasqet.Count != 0)
            {
                CaktoPrioritetin(tasqet);
            }
        }
        public void PrintoTasqetSortuara()
        {
            Console.WriteLine("Tasqet e renditura sipas prioritetit qe duhet te kryhen : ");
            for (int i = 0; i < TasqetSortuara.Count; i++)
            {
                Console.WriteLine($"{i + 1} --> {TasqetSortuara[i]}");
            }
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
        public Menaxheri(int id, string emri, string mbiemri) : base(id, emri, mbiemri)
        {

        }
    }
}
