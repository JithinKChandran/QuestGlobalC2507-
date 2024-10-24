using Assessment.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class DoctorService : EntityService
    {
        public DoctorService(string connectionString) : base(connectionString) { }

        public override void GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Doctor";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Specialization"]}");
                }
            }
        }

        public override void Add()
        {
            Doctor doctor = new Doctor
            {
                Name = "Dr X",
                Specalization = "Cardio"
            };

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Doctor (Name, Specialization) VALUES (@Name, @Specialization)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specalization);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Update()
        {
            Doctor doctor = new Doctor
            {
                Id = 1,
                Name = "Dr Y",
                Specalization = "ENT"
            };

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", doctor.Id);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specalization);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Doctor WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
