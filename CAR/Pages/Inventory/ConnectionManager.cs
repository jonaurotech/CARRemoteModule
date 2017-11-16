using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace CAR
{
    class ConnectionManager
    {
        public static SqlConnection GetCarConnection()
        {
            ///<summary>
            ///Get the connection string from the configuration file
            ///</summary>
            string connectionString = ConfigurationManager.ConnectionStrings["CARConnectionString"].ConnectionString;

            ///<summary>
            ///Create a new connection object
            ///</summary>
            SqlConnection connection = new SqlConnection(connectionString);

            ///<summary>
            ///Open the connection and return it
            ///</summary>
            connection.Open();
            return connection;
           
        }


    }//end class
}//end namespace
