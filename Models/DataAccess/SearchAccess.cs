using FatihHAS1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatihHAS1.DataAccess
{
    public class SearchAccess : Product
    {
        public static List<Product> Search(string pro)
        {
            List<Product> productList = new List<Product>();

            using (SqlConnection connString = new SqlConnection(cName))
            {
                connString.Open();
                SqlCommand cmd = new SqlCommand("spSearchProduct", connString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchPro", pro);
                SqlDataReader dataRead = cmd.ExecuteReader();
                while (dataRead.Read())
                {
                    productList.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dataRead["ProductId"]),
                        ProductName = dataRead["ProductName"].ToString(),
                        ProductStok = Convert.ToInt32(dataRead["ProductStok"]),
                        ProductDescription = dataRead["ProductDescription"].ToString(),
                    });
                }

            }
            return productList;
        }
    }
}