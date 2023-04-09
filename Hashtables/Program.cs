using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Ahmad", 96);
            Student stud2 = new Student(2, "Bagus", 99);
            Student stud3 = new Student(3, "Caesar", 90);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);

            Student storeStudent1 = (Student)studentsTable[stud1.Id];
            Student storeStudent2 = (Student)studentsTable[stud2.Id];

            Console.WriteLine($"Student Id: {storeStudent2.Id}");

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student Id: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }

            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine($"Student Id: {student.Id}");
                Console.WriteLine($"Student Name: {student.Name}");
                Console.WriteLine($"Student GPA: {student.GPA}");
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gPA)
        {
            Id = id;
            Name = name;
            GPA = gPA;
        }
    }
}
