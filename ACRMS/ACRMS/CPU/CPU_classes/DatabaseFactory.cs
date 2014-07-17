using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;

namespace ACRMS.CPU
{
    class DatabaseFactory
    {
        private static string serverHost = "localhost";
        private static string port ="5432";
        private static string username = "postgres";
        private static string password = "mayooran";
        private static string databaseName = "tracing";

        private static string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    serverHost, port, username,
                    password, databaseName);
        private static NpgsqlConnection conn;

        public static bool connectToDatabase()
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public static NpgsqlDataAdapter executeQuery(String sqlString)
        {
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sqlString, conn);
                return da;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int executeNonQuery(String sqlString)
        {
            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlString, conn);
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static NpgsqlConnection getCurrentConnection()
        {
            return conn;
        }
    }
}
