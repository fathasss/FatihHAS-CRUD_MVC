using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FatihHAS1.Models.Helper
{
    public class GlobalSettings
    {
        public static string GlobalAddress = ConfigurationManager.AppSettings["LocalAddress"];
    }
}