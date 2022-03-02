using System;
using System.Collections.Generic;

namespace TaskManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Projekti p1=new Projekti();
            Projekti p2 = new Projekti();
            Projekti p3= new Projekti();

            Task tasku1 = new Task(1, "tasku1", DateTime.ParseExact("01-02-2021", "dd-MM-yyyy", null), DateTime.ParseExact("01-03-2021", "dd-MM-yyyy", null));
            Task tasku2 = new Task(2, "tasku2", DateTime.ParseExact("01-02-2022", "dd-MM-yyyy", null), DateTime.ParseExact("01-06-2022", "dd-MM-yyyy", null));
            Task tasku3 = new Task(3, "tasku3", DateTime.ParseExact("01-02-2022", "dd-MM-yyyy", null), DateTime.ParseExact("01-05-2022", "dd-MM-yyyy", null));

            List<Task> tasqet = new List<Task>();
            tasqet.Add(tasku1);
            tasqet.Add(tasku2);
            tasqet.Add(tasku3);
            Menaxheri m = new Menaxheri(2, "filan", "fisteku", "filan@gmail.com");
            m.CaktoPrioritetin(tasqet);

           
        }

    }
}
