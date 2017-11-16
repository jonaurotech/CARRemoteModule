using System;
using System.Data;
using System.Data.SqlClient;

namespace CAR
{
    class DataAccess
    {

        public static SqlDataReader ReturnAllAssets()
        {
            string sql = "SELECT * FROM placeholder";

            SqlConnection connection = ConnectionManager.GetCarConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            return reader;
        }


        public static SqlDataReader ReturnAllCenters()
        {
            string sql = "SELECT * FROM placeholder";

            SqlConnection connection = ConnectionManager.GetCarConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            return reader;
        }

        public static int InsertCenter(
                            string center_id,
                            int locationCode,
                            int apo,
                            DateTime created,
                            DateTime lastUpdated)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = ConnectionManager.GetCarConnection())
            {
                SqlCommand command = new SqlCommand("ttInsertCenter", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Center", SqlDbType.NVarChar, 75).Value = center_id;
                command.Parameters.Add("@LocationCode", SqlDbType.Int).Value = locationCode;
                command.Parameters.Add("@Apo", SqlDbType.Int).Value = apo;
                command.Parameters.Add("@Created", SqlDbType.Date, 20).Value = created;
                command.Parameters.Add("@LastUpdated", SqlDbType.Date).Value = lastUpdated;
                

                rowsAffected = command.ExecuteNonQuery();
                
            }
            return rowsAffected;
            
        }




    }
}
