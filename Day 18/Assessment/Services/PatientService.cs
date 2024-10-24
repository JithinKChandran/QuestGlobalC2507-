using Assessment.Entities;
using Assessment.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class PatientService : EntityService
    {
        public PatientService(string connectString) : base(connectString) { }

        public override void Add()
        {
            Patient patient = new Patient
            {
                Name = "John",
                Age = 30,
                Gender = Gender.Male,
                MedicalCondition = "Healthy"
            };

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender.ToString());
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Update()
        {
            Patient patient = new Patient
            {
                Id = 1,
                Name = "John k",
                Age = 31,
                Gender = Gender.Male,
                MedicalCondition = "Unhealthy"
            };

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", patient.Id);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender.ToString());
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Patient WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Patient";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Age"]}, {reader["Gender"]}, {reader["MedicalCondition"]}");
                }
            }
        }
    }
}
