﻿using FatihHAS1.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatihHAS1.Models
{
    public class Login : ConnString
    {
        public int LoginId { get; set; }
        public string LoginNick { get; set; }
        public string LoginPass { get; set; }
    }
}