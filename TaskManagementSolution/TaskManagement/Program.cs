﻿using System;
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
           
            
            Menaxheri m1 = new Menaxheri(2, "filan", "fisteku", "filan@gmail.com");

            List<Task> tasqet = new List<Task>();
            tasqet.Add(tasku1);
            tasqet.Add(tasku2);
            tasqet.Add(tasku3);
            m1.CaktoPrioritetin(tasqet);


            //--------------------------------------------------------------------------------------------------------------
            //int id, string emri,string pershkrimi
            Goal g1 = new Goal(1,"Qellimi 1","Duhet te behet bartja e te dhenave nga ... ne ...");
            Goal g2 = new Goal(1, "Qellimi 2", "pershkrimi 2");
            Goal g3 = new Goal(1, "Qellimi 3", "pershkrimi 3");




            m1.shtoQellimet(g1);
            m1.shtoQellimet(g2);
            m1.shtoQellimet(g3);
            Console.WriteLine("Qellimet  print ----> ");

            m1.shtypQellimet();




        }

    }
}



/*
 
 menaxheri shton goals

goals me u nderlidh me task
 
 
 */
