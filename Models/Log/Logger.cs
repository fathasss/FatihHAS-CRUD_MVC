using FatihHAS1.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatihHAS1.Models.Log
{
    public class Logger: ConnString
    {
        public int Id { get; set; }
        public string UserName{ get; set; }
        public string LogAction { get; set; }
        public DateTime LogDate { get; set; }
        public string LogDateStr { get { return LogDate.ToString(); } }
        public string IpAddress { get; set; }
        public string Browser { get; set; }

    }
}