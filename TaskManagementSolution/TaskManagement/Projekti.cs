﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Projekti
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        //public  List<Task> tasqet { get; set; }
        public Lideri Lideri { get; set; }

        public Projekti(int id,string name,DateTime startDate,DateTime endDate,Lideri lideri)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            //this.tasqet = tasqet;
            this.Lideri = lideri;
        }

        public override string ToString()
        {
            return $"{this.id} --> {this.name},\nKohezgjatja e projektit: {this.startDate} - {this.endDate}\nProjekti udheheqet nga lideri {Lideri.emri} {Lideri.mbiemri}";
        }
    }
}
