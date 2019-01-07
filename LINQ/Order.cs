using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation property

        public Customer Customer { get; set; } = new Customer();// nul/ referans hatasını onler
     //   public object SqlConnectionString { get; private set; }

        public List<Order> GetOrders()
        {
            List<Order> liste = new List<Order>();
            string query = @"Select o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate,
(SElECT ContactName from Customers where CustomerID = o.CustomerID) AS ContactName
from Orders o";

            DataTable dt = GetDataTable(query);
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.CustomerID =  item["CustomerID"].ToString();
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderID = (int)item["OrderID"];
                o.OrderDate = Convert.ToDateTime(item["OrderDate"]);
                o.Customer.ContactName = item["ContactName"].ToString();//customer üretmesek null referans hatası alırız
                liste.Add(o);
            }
            return liste;

        }
        private DataTable GetDataTable(string sorgu)
        {
            //1-connected architecture
            //2-Disconnected archicture
            //SqlCommand
            //SqlConnection
            //SqlDataReader
            string cs = @"Data Source=DICLE\DICLEDEMIR; Initial Catalog=NORTHWND;  Trusted_Connection=true;  User Id = Dicle;";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }

    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}
