using System;
using System.Data.SqlClient;

namespace PhoneBook
{
    public class ContactManager
    {
        const string connStr = @"Data Source=ASUS; Database=QuestDB;Integrated Security=True";

        public void AddContact(Contact contact)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var insertQuery = "INSERT INTO Contacts (Name, Phone) VALUES (@Name, @Phone)";
                var command = new SqlCommand(insertQuery, conn);
                command.Parameters.AddWithValue("@name", contact);
                command.Parameters.AddWithValue("@Phone", contact);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteContact(string name)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var deleteQuery = "DELETE FROM Contacts WHERE Name = @Name";
                var command = new SqlCommand(deleteQuery, conn);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateContact(string name, string newPhone)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var updateQuery = "UPDATE Contacts SET Phone = @Phone WHERE Name = @Name";
                var command = new SqlCommand(updateQuery, conn);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Phone", newPhone);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void SearchContact(string search)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var searchQuery = "SELECT * FROM Contacts WHERE Name = @Search OR Phone = @Search";
                var command = new SqlCommand(searchQuery, conn);
                command.Parameters.AddWithValue("@Search", search);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var Name = reader.GetString(1);
                    var Phone = reader.GetString(2);

                    Console.WriteLine($"{id} -{Name} - {Phone}");
                }
                conn.Close();
            }
        }
    }
}
