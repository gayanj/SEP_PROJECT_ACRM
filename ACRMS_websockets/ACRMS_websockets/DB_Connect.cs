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

        public static string ConStr = "Data Source=GAYAN-PC;Initial Catalog=CPUDataWarehouse;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            NewCon = new SqlConnection(ConStr);
            return NewCon;
        }
    }
}
