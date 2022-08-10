using FatihHAS1.Models.Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FatihHAS1.Models.DataAccess
{
    public class LoggerAccess:Logger
    {
        public static List<Logger> GetList()
        {
            List<Logger> list = new List<Logger>();
            using (SqlConnection connString = new SqlConnection(cName))
            {
                connString.Open();
                SqlCommand cmd = new SqlCommand("spGetAllLogger", connString);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataRead = cmd.ExecuteReader();
                while (dataRead.Read())
                {
                    list.Add(new Logger
                    {
                        Id = Convert.ToInt32(dataRead["LoggerId"]),
                        UserName = dataRead["LoggerName"].ToString(),
                        LogAction = dataRead["LoggerAction"].ToString(),
                        LogDate = Convert.ToDateTime(dataRead["LoggerDate"]),
                        IpAddress = dataRead["LoggerIp"].ToString(),
                        Browser = dataRead["LoggerBrowser"].ToString()
                    });
                }
                return list;
            }
        }
    }
}