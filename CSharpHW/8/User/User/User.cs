﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        public string Login { get; set; }

        public string Pass { get; set; }

        public User() { }
        
        public User(string log, string pas)
        {
            Login = log;
            Pass = pas;
        }
    }
}
