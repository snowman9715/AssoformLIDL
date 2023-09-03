using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetDataFromDB();
                Console.WriteLine("ha funzionato");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void GetDataFromDB()
        {
            string connectionString = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=GiuseppeUgarelliLIDL;Integrated Security= True";
            string queryString = "SELECT * FROM Prodotti";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
            }



        }
    }
}
