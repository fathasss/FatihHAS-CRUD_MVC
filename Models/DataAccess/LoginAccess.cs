using FatihHAS1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FatihHAS1.DataAccess
{
    public class LoginAccess : Login
    {
        public int LoginAuth(string admin, string password)
        {

            SqlConnection connString = new SqlConnection(cName);

            int res = 0;
            SqlCommand cmd = new SqlCommand("SysLogin", connString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoginName", admin);
            cmd.Parameters.AddWithValue("@LoginPass", password);
            SqlParameter obLogin = new SqlParameter();
            obLogin.ParameterName = "@Isvalued";
            obLogin.SqlDbType = SqlDbType.Bit;
            obLogin.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(obLogin);
            connString.Open();
            cmd.ExecuteNonQuery();
            res = Convert.ToInt32(obLogin.Value);
            return res;
        }      
    }
}