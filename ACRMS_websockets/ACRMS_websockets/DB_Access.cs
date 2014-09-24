using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DataWareHouse
{
    /// <summary>
    /// Summary description for DB_Access
    /// </summary>
    public class DB_Access
    {
        SqlConnection conn;

        public DB_Access()
        {
            conn = DB_Connect.GetConnection();
        }

        //Get Date Key
        public string getDateKey(string date)
        {
            string dateKey = null;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select DateKey from DimDate where DateKey='" + date + "'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                dateKey = dr[0].ToString();
            }
            dr.Close();
            return dateKey;
        }

        //Get Time Key
        public string getTimeKey(string time)
        {
            string timeKey = null;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select TimeKey from DimTime where TimeKey='" + time + "'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                timeKey = dr[0].ToString();
            }
            dr.Close();
            return timeKey;
        }

        //Get Process Key
        public string getProcessKey(string processName)
        {
            string processId = null;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Id from DimProcess where ProcessName='" + processName + "'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "process");
            processId = ds.Tables[0].Rows[0].Field<long>("Id").ToString();
            conn.Close();
            return processId;
        }

        //Check If Process Exists
        public bool checkIfProcessExist(string processName)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select * from DimProcess where ProcessName='" + processName + "'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            dr.Close();
            return status;
        }
        
        //Insert into Process Table
        public bool persistProcessName(string processName)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "INSERT INTO DimProcess(ProcessName) VALUES('" + processName + "')";
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        //Insert into Fact Table
        public bool persistData(string UsageDateKey, string UsageTimeKey, string ProcessKey, string CreatingProcessID,
                                string ElapsedTime, string HandleCount, string IDProcess, string PercentProcessorTime, string PercentUserTime,
                                string ThreadCount)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "INSERT INTO FactCPUUsage(UsageDateKey,UsageTimeKey,UsageProcessKey,CreatingProcessID," +
                                       "ElapsedTime,HandleCount,IDProcess,PercentProcessorTime,PercentUserTime," +
                                       "ThreadCount) VALUES('" + UsageDateKey + "' , '" + UsageTimeKey + "' , '" + ProcessKey + "' , '"
                                        + CreatingProcessID + "' , '" + ElapsedTime + "' , '" + HandleCount + "' , '" + IDProcess + "' , '" + PercentProcessorTime
                                        + "' , '" + PercentUserTime + "','" + ThreadCount + "')";
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        //User Registration
        public bool registration(string UserName, string Password, string FirstName, string LastName,
                                string Address, string Phone, string Email, string SecurityQuestion, string Answer)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "SELECT * FROM Customer WHERE username='" + UserName + "'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                status = false;
            }
            else
            {
                dr.Close();
                SqlCommand newCmd2 = conn.CreateCommand();
                newCmd2.Connection = conn;
                newCmd2.CommandType = CommandType.Text;
                newCmd2.CommandText = "INSERT INTO Customer VALUES('" + UserName + "' , '" + Password + "' , '" + FirstName + "' , '"
                                        + LastName + "' , '" + Address + "' , '" + Phone + "' , '" + Email + "' , '" + SecurityQuestion
                                        + "' , '" + Answer + "')";
                newCmd2.ExecuteNonQuery();

                status = true;
            }
            return status;

        }
        //Get User data
        public DataSet getuser()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = " select * from Customer";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");
            conn.Close();
            return ds;
        }


        //Adding to cart
        public bool shoppingCart(string pid, string pname, string pbrand, string pmodel, Int32 quantity, double price, string url, string UserName)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select p_name from Product where p_name='" + pname + "' and stock>=" + quantity + "";//check stock availability
            SqlDataReader dr1 = newCmd1.ExecuteReader();
            if (dr1.HasRows)
            {
                dr1.Close();
                SqlCommand newCmd2 = conn.CreateCommand();
                newCmd2.Connection = conn;
                newCmd2.CommandType = CommandType.Text;
                newCmd2.CommandText = "select p_name from ShoppingCart where p_name='" + pname + "' AND username='" + UserName + "'";//check item already in cart
                SqlDataReader dr2 = newCmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    dr2.Close();
                    SqlCommand newCmd4 = conn.CreateCommand();
                    newCmd4.Connection = conn;
                    newCmd4.CommandType = CommandType.Text;
                    newCmd4.CommandText = " update ShoppingCart set p_quantity=p_quantity+'" + quantity + "' where p_name='" + pname + "'";
                    newCmd4.ExecuteNonQuery();


                    SqlCommand newCmd5 = conn.CreateCommand();
                    newCmd5.Connection = conn;
                    newCmd5.CommandType = CommandType.Text;
                    newCmd5.CommandText = "update Product set stock= stock - " + quantity + " where p_name='" + pname + "'";//update stock
                    newCmd5.ExecuteNonQuery();
                    return true;
                }
                else//insert into cart
                {
                    dr2.Close();
                    double total = (double)quantity * price;
                    SqlCommand newCmd4 = conn.CreateCommand();
                    newCmd4.Connection = conn;
                    newCmd4.CommandType = CommandType.Text;
                    newCmd4.CommandText = " insert into ShoppingCart values('" + pid + "','" + pname + "','" + pbrand + "', '" + pmodel + "'," + quantity + "," + price + "," + total + ",'" + url + "','" + UserName + "')";
                    newCmd4.ExecuteNonQuery();


                    SqlCommand newCmd5 = conn.CreateCommand();
                    newCmd5.Connection = conn;
                    newCmd5.CommandType = CommandType.Text;
                    newCmd5.CommandText = "update Product set stock= stock - " + quantity + " where p_name='" + pname + "'";//update stock
                    newCmd5.ExecuteNonQuery();

                    status = true;
                }
            }
            else
            {
                dr1.Close();
                status = false;
            }
            return status;
        }

        //Get cart data
        public DataSet getcart()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = " select * from ShoppingCart";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "cart");
            conn.Close();
            return ds;
        }

        //Getting number of Items in cart
        public Int32 getCount()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("count", typeof(Int32));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select count(p_ID) as 'count' from ShoppingCart";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["count"]);
            }
            if (dr.HasRows)
            {
                string countstr = dt.Rows[0]["count"].ToString();
                Int32 counter = System.Convert.ToInt32(countstr);
                dr.Close();
                conn.Close();
                return counter;
            }
            else
            {
                dr.Close();
                conn.Close();
                return -1;
            }
        }

        //Removing item from cart
        public void removeItem(string pname, Int32 quantity)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "delete from ShoppingCart where p_name='" + pname + "'";//remove item
            newCmd1.ExecuteNonQuery();

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "update Product set stock= stock + " + quantity + " where p_name='" + pname + "'";//update stock
            newCmd2.ExecuteNonQuery();
        }

        //Adding to Orders table
        public void orders(string pid, string pname, double price, string url, Int32 quantity, string username)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select p_name from Orders where p_name='" + pname + "'";//check item already in orders
            SqlDataReader dr = newCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                SqlCommand newCmd1 = conn.CreateCommand();
                newCmd1.Connection = conn;
                newCmd1.CommandType = CommandType.Text;
                newCmd1.CommandText = "update Orders set quantity=quantity+" + quantity + " where p_name='" + pname + "'";//update quantity
                newCmd1.ExecuteNonQuery();
            }
            else//insert into orders
            {
                dr.Close();
                SqlCommand newCmd2 = conn.CreateCommand();
                newCmd2.Connection = conn;
                newCmd2.CommandType = CommandType.Text;
                newCmd2.CommandText = " insert into Orders values('" + url + "','" + pid + "','" + pname + "', '" + price + "'," + quantity + ",'" + username + "')";
                newCmd2.ExecuteNonQuery();
            }
        }

        //Get Order data
        public DataSet getorders()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = " select * from Orders";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "orders");
            conn.Close();
            return ds;
        }

        //Removing Orders
        public void removeOrder(string pname, Int32 quantity)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "delete from orders where p_name='" + pname + "'";//remove item
            newCmd1.ExecuteNonQuery();

            SqlCommand newCmd2 = conn.CreateCommand();
            newCmd2.Connection = conn;
            newCmd2.CommandType = CommandType.Text;
            newCmd2.CommandText = "update Product set stock= stock + " + quantity + " where p_name='" + pname + "'";//update stock
            newCmd2.ExecuteNonQuery();
        }
        //change email function
        public void changeEmail(string userName, string email)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "update customer set e_mail = '" + email + "' where username = '" + userName + "'";
            newCmd1.ExecuteNonQuery();
            conn.Close();
        }

        //verify password
        public bool passwordVerify(string userName, string password)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select * from customer where username='" + userName + "' and password='" + password + "'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            dr.Close();
            conn.Close();
            return status;
        }

        //change security question and answer
        public void changeQuestionAnswer(string userName, string question, string answer)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "update customer set c_security = '" + question + "', c_answer = '" + answer + "' where username = '" + userName + "'";
            newCmd1.ExecuteNonQuery();
            conn.Close();
        }
        //Find for products
        public DataSet search1(string keyword)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Product where p_name like '%" + keyword + "%'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "search");
            conn.Close();
            return ds;
        }
        //Get search products
        public bool search2(string keyword)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "select * from Product where p_name like '%" + keyword + "%'";
            SqlDataReader dr = newCmd1.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                status = true;
            }
            else
            {
                dr.Close();
                status = false;
            }
            conn.Close();
            return status;
        }

        //Get Products
        public DataSet getproducts(string keyword)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = " select * from product where p_name='" + keyword + "'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "products1");
            conn.Close();
            return ds;
        }

        //Get Contact Us Data
        public void contactUs(string Name, string email, string Sub, string Comment, string userName)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "INSERT INTO ContactUs(name,email,Subject,comment,username)VALUES('" + Name + "', '" + email + "' , '" + Sub + "' , '" + Comment + "', '" + userName + "')";
            newCmd1.ExecuteNonQuery();
            conn.Close();
        }

        //recover request
        public string recoverRequest(string UserName)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("c_security", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select c_security from customer where username='" + UserName + "'";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["c_security"]);
            }
            if (dr.HasRows)
            {
                string Question = dt.Rows[0]["c_security"].ToString();
                dr.Close();
                conn.Close();
                return Question;
            }
            else
            {
                dr.Close();
                conn.Close();
                return "false";
            }
        }

        //check answer
        public bool checkAnswer(string UserName, string Answer)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("c_answer", typeof(string));
            string originalAnswer;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select c_answer from customer where username='" + UserName + "'";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["c_answer"]);
            }
            if (dr.HasRows)
            {
                originalAnswer = dt.Rows[0]["c_answer"].ToString();
                dr.Close();
                conn.Close();
                if (originalAnswer.Equals(Answer))
                    return true;
                else return false;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }

        //Update Password
        public void updatePassword(string UserName, string Password)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "UPDATE customer SET password='" + Password + "' WHERE username='" + UserName + "'";
            newCmd1.ExecuteNonQuery();
            conn.Close();
        }


        //Get Product according to Category
        public DataSet getproduct2(Int32 cat_ID)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Product where cat_ID='" + cat_ID + "'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            conn.Close();
            return ds;
        }

    }
}
