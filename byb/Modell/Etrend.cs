﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etrend
    {
        private int fid;
        private string idopont;
        private string etelnev;
        public Etrend(int fid,string idopont,string etelnev)
        {
            this.fid = fid;
            this.idopont = idopont;
            this.etelnev = etelnev;
        }
        public int Fid { get => fid; set => fid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public string Etelnev { get => etelnev; set => etelnev = value; }
    }
}
