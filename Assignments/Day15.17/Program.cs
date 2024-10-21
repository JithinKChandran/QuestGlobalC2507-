using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15._17
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob", DepartmentId = 2 }
            };

            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "IT" }
            };

            var combined = employees
                .Join(
                    departments,
                            e => e.DepartmentId,
                            d => d.Id,
                            (e, d) => new
                            {
                                EmployeeName = e.Name,
                                DepartmentName = d.Name
                            }
                    );
        }
    }
}
