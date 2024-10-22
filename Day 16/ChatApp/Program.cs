using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal class Program
    {
        const string connStr = @"Data Source=ASUS; Database=QuestDB;Integrated Security=True";
        static void Main(string[] args)
        {
            //Console.WriteLine("Name:");
            //var name = Console.ReadLine();

            //Console.WriteLine("Author: ");
            //var author = Console.ReadLine();

            //Console.WriteLine("Price");
            //var price = Console.ReadLine();

            //var insertQuery = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
            //var nameParameter = new SqlParameter("@name", name);
            //var authorParameter = new SqlParameter("@author", author);
            //var priceParameter = new SqlParameter("@price", price);


            //var conn = new SqlConnection(connStr);
            //conn.Open();

            //var command = new SqlCommand(insertQuery, conn);
            //command.Parameters.AddWithValue("@name", name);
            //command.Parameters.AddWithValue("@author", author);
            //command.Parameters.AddWithValue("@price", price);

            // SELECTING DATA
            var insertQuery = $"SELECT id, name ,author, price from Books";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command1 = new SqlCommand(insertQuery, conn);
            var reader = command1.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var value = reader.GetString(2);
                var price = reader.GetInt32(3);

                Console.WriteLine($"{id} -{name} - {value} - {price}");
            }
            conn.Close();

            //command.ExecuteNonQuery();
            //conn.Close();

            // AUTO connection close
            //using (var conn2 = new SqlConnection(connStr))
            //{
            //    conn2.Open();
            //    var insertQuery1 = @"INSERT INTO Books(name, author, price) VALUES('War and Peace','Leo TolStoy',1000)";

            //    var command1 = new SqlCommand(insertQuery1, conn2);
            //    command1.ExecuteNonQuery();
            //}
        }
    }
}
