﻿using byb.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    partial class Repo
    {
        List<Login> logins;
        public List<Login> getLogins()
        {
            return logins;
        }
        
    }
}