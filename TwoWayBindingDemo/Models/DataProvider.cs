using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TwoWayBindingDemo.Models
{
    public class DataProvider
    {

        public static IDbConnection GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
            return  new SqlConnection(connString);
        }
    }
}