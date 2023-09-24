using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    internal class Program : BestSeller
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*******************************************************************");

                getBestSeller();
                Console.WriteLine("*******************************************************************");


            }
            catch (Exception ex)
            {

            }
            Console.ReadLine();
        }



        static private void ExecuteQuery(string query)
        {
            //variables declaration
            string queryString;
            SqlConnection connection;
            SqlCommand command;

            //variables iniatialization
            queryString = $"{query}";

            using (connection = GetDBConnection())
            {
                command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
