using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_Linq_Queries
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Petar","Petrov",23),
                new Student("Viktoria","Zdravkova",33),
                new Student("Georgy","Aleksiev",23),
                new Student("Antonia","Malinova",14),
                new Student("Zdravko","Cvetkov",67)
            };

            StudentList studentList = new StudentList(students);
            //Task 3
            Console.WriteLine("Task 3: Student whose first name is before their last name:");
            Console.WriteLine(studentList.FirstBeforeLast().ToString());
            //Task 4
            Console.WriteLine("Task 4: Student whose age is in the range 18-24:");
            Console.WriteLine(studentList.InRange18_24().ToString());
            //Task 5
            Console.WriteLine("Task 5: Students ordert by first, then by last name:");
            Console.WriteLine(studentList.OrderByFirstAndLastName().ToString());
            //Task 5 using LINQ Queries
            Console.WriteLine("Task 5: Students ordert by first, then by last name, using LINQ queries:");
            Console.WriteLine(studentList.OrderByFirstAndLastNameLINQ().ToString());
        }
    }
}
