using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("name", "Alam Alfaris");
            myDictionary.Add("name", ".Net Developer");
            myDictionary.Add("address", "Jakarta");

            Console.WriteLine(myDictionary["name"]);

            //Employee[] employees =
            //{
            //    new Employee("CEO", "Wawan", 50, 200),
            //    new Employee("Manager", "Andry", 43, 100),
            //    new Employee("HR", "Andini", 40, 88),
            //};

            //Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();

            //foreach (Employee emp in employees)
            //{
            //    employeeDirectory.Add(emp.Role, emp);
            //}

            //string key = "HR";
            //if (employeeDirectory.ContainsKey(key))
            //{
            //    Employee emp1 = employeeDirectory[key];
            //    Console.WriteLine($"Employee name: {emp1.Name}, role: {emp1.Role}, age: {emp1.Age}, rate: {emp1.Rate}");
            //}
            //else
            //{
            //    Console.WriteLine("No employee found with this {0} role", key);
            //}

            //if (employeeDirectory.ContainsKey(key))
            //{
            //    employeeDirectory[key] = new Employee("HR", "Putri", 32, 86);
            //}

            //if (employeeDirectory.Remove(key))
            //{
            //    Console.WriteLine("Employee with role {0} was removed", key);
            //}

            //Employee result = null;
            //if (employeeDirectory.TryGetValue("CEO", out result))
            //{
            //    Console.WriteLine($"Employee name: {result.Name}, role: {result.Role}, age: {result.Age}, rate: {result.Rate}");
            //}
            //else
            //{
            //    Console.WriteLine("Can't get value from key");
            //}
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }
    }
}
