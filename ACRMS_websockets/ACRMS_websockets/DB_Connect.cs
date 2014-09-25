using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DataWareHouse
{
    /// <summary>
    /// Summary description for DB_Connect
    /// </summary>
    public class DB_Connect
    {
        public DB_Connect()
        {

        }
        public static SqlConnection NewCon;
        public static SqlConnection NewCon2;

        public static string ConStr = "Data Source=GAYAN-J;Initial Catalog=CPUDataWarehouse;Integrated Security=True";

        public static string ConStr2 = "Data Source=GAYAN-J;Initial Catalog=CPUData;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            NewCon = new SqlConnection(ConStr);
            return NewCon;
        }

        public static SqlConnection GetConnection2()
        {
            NewCon2 = new SqlConnection(ConStr2);
            return NewCon2;
        }
    }
}
