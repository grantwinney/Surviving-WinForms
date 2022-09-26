using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NullHandlingOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var validCompany = DefineCompany();
            var emptyCompany = new Company();

            
            var validCompanyNameLength = validCompany.Name.Length;     // 6 (SpaceX)
            var invalidCompanyNameLength = emptyCompany.Name?.Length;  // null


            var validUrlHost = validCompany.URL.Host;     // www.spacex.com
            var invalidUrlHost = emptyCompany.URL?.Host;  // null


            var engineers = validCompany.Departments[0].Employees.Count();      // 3
            var invalidCount = emptyCompany.Departments?[0].Employees.Count();  // null


            //var seniorRoles = validCompany.Departments.SelectMany(x => x.Employees).Count(x => x.JobTitle.StartsWith("Sr"));  // NullReferenceException

            var seniorRolesSafe1 = validCompany.Departments.SelectMany(x => x.Employees).Where(x => x.JobTitle != null).Count(x => x.JobTitle.StartsWith("Sr"));
            var seniorRolesSafe2 = validCompany.Departments.SelectMany(x => x.Employees).Count(x => x.JobTitle?.StartsWith("Sr") ?? false);


            Console.WriteLine($"{validCompany.Name}'s website is {validCompany.URL.Host}.");
            // SpaceX's website is www.spacex.com.

            var anotherInvalidCompany = new Company { Name = "ACME" };
            Console.WriteLine($"{anotherInvalidCompany.Name}'s website is {anotherInvalidCompany.URL?.Host ?? "unknown"}.");
            // ACME's website is unknown.


            foreach (var emp in validCompany.Departments.SelectMany(x => x.Employees))
                Console.WriteLine($"{emp.Name} was hired on {emp.HireDate?.ToString("d") ?? "an unknown date"}.");

            // Geordi La Forge was hired on 1/1/2011.
            // Montgomery Scott was hired on 2/2/2022.
            // B'Elanna Torres was hired on an unknown date.


            foreach (var dept in validCompany.Departments)
                Console.WriteLine($"{dept.Name} currently has {dept.Employees?.Count() ?? 0} employee(s).");

            // Starship Engineering currently has 3 employee(s).
            // Space Car Retrieval currently has 0 employee(s).
        }

        public Company DefineCompany()
        {
            return new Company
            {
                Name = "SpaceX",
                URL = new Uri("https://www.spacex.com"),
                Founded = new DateTime(2002, 03, 14),
                Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "Starship Engineering",
                        Employees = new List<Employee>
                        {
                            new Employee
                            {
                                Name = "Geordi La Forge",
                                JobTitle = "Lead Flight Control Tech",
                                HireDate = new DateTime(2011,1,1),
                            },
                            new Employee
                            {
                                Name = "Montgomery Scott",
                                JobTitle = "Sr Propulsion Engineer",
                                HireDate = new DateTime(2022,2,2),
                            },
                            new Employee
                            {
                                Name = "B'Elanna Torres"
                            }
                        }
                    },
                    new Department
                    {
                        Name = "Space Car Retrieval",
                    },
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public Uri URL { get; set; }
        public DateTime Founded { get; set; }
        public IList<Department> Departments { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public IList<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
