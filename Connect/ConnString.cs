using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FatihHAS1.Connect
{
    public class ConnString
    {
        public static string cName = "Data Source=FATIH-REDDRAGON\\SQLEXPRESS;initial catalog=FatihHAS;integrated security=true";
        public static string CName
        {
            get => cName;
        }

    }
}