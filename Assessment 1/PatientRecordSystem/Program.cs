using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordSystem
{
    internal class Program
    {
        static List<Dictionary<string, object>> patients = new List<Dictionary<string, object>>();

        static void AddPatient()
        {
            var patient = new Dictionary<string, object>();

            Console.WriteLine("Patient's name:");
            var name = Console.ReadLine();
            patient.Add("name", name);

            Console.WriteLine("Age:");
            var age = Console.ReadLine();
            patient.Add("age", age);

            Console.WriteLine("Symptoms as comma separated values:");
            var symptoms = Console.ReadLine();
            patient.Add("symptoms", symptoms);

            Console.WriteLine("Admitted / Discharged:");
            var admissionStatus = Console.ReadLine();
            patient.Add("Admission Status", admissionStatus);

            patients.Add(patient);

            Console.WriteLine($"{name} added successfully.");
        }

        static void SearchPatientByName()
        {
            Console.WriteLine("Name of the patient:");
            var name = Console.ReadLine().ToLower();

            foreach (var patient in patients)
            {
                if (patient["name"].ToString().ToLower() == name)
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Symptoms: " + patient["symptoms"]);
                    Console.WriteLine("Admission Status: " + patient["Admission Status"]);
                }
            }
            Console.WriteLine("Not found.");
        }

        static void Update()
        {
            Console.WriteLine("Patient's name:");
            var name = Console.ReadLine().ToLower();

            foreach (var patient in patients)
            {
                if (patient["name"].ToString().ToLower() == name)
                {
                    Console.WriteLine("New symptoms:");
                    var diagnosis = Console.ReadLine();
                    if (diagnosis.Length > 0)
                    {
                        patient["symptoms"] = diagnosis;
                    }

                    Console.WriteLine("New status(Admitted/Discharged):");
                    var admissionStatus = Console.ReadLine();
                    if (admissionStatus.Length > 0)
                    {
                        patient["Admission Status"] = admissionStatus;
                    }

                    Console.WriteLine($"{name} details updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Not found.");
        }

        static void AllPatients()
        {
            Console.WriteLine("List of all admitted patients:");
            foreach (var patient in patients)
            {
                if (patient["Admission Status"].ToString().Equals("Admitted"))
                {
                    Console.WriteLine($"Name: {patient["name"]}, Age: {patient["age"]}, Symptoms: {patient["symptoms"]}");
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add patient.");
                Console.WriteLine("2. Search patient by their name.");
                Console.WriteLine("3. Update patient details.");
                Console.WriteLine("4. Admitted patients list.");
                Console.WriteLine("5. EXIT");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchPatientByName();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        AllPatients();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid.");
                        break;
                }
            }
        }
    }
}
