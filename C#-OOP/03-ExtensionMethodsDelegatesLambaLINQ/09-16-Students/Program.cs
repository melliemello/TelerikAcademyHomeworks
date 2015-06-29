using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16_Students
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Petar","Petrov",23,234106, 3,"02/9738987","somemail@mail.bg", new List<byte>{4,4,6,5,2} ),
                new Student("Aleks","Petrov",23,234104, 2,"02/9738987","somemail@abv.bg", new List<byte>{2,4,5,5,2} ),
                new Student("Viktoria","Zdravkova",33,660202, 3,"02/8538987","somemail@mail.bg", new List<byte>{6,6,6,5,2}),
                new Student("Georgy","Aleksiev",23,110206, 1,"037/6738987","somemail@abv.bg", new List<byte>{5,5,6,5,2}),
                new Student("Antonia","Malinova",14,552504, 2,"029/735987","somemail@mail.bg", new List<byte>{4,2,3,5,2}),
                new Student("Zdravko","Cvetkov",67,204102, 2,"029/708987","somemail@abv.bg", new List<byte>{4,2,6,5,2}),
                new Student("Aleks","Ivanov",45,524501, 2,"02/9758987","somemail@mail.bg", new List<byte>{4,6,6,5,2} )
            };

            //Task 9:Select only the students that are from group number 2.
            Console.WriteLine("Select only the students that are from group number 2.");
            Console.WriteLine("--------------------------------------------------------------------------.");
            var group2 = from student in students
                         where student.GroupNumber == 2
                         orderby student.FirstName
                         select student;
            foreach(Student student in group2.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }
            //Task 10: Implement the previous using the same query expressed with extension methods.
            Console.WriteLine("Implement the previous using the same query expressed with extension methods.");
            Console.WriteLine("--------------------------------------------------------------------------.");
            var group2wMethods = students.Where(stud => stud.GroupNumber == 2).OrderBy(stud => stud.FirstName);
            foreach (Student student in group2wMethods.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            //Task 11: Extract all students that have email in abv.bg
            Console.WriteLine("Extract all students that have email in abv.bg");
            Console.WriteLine("--------------------------------------------------------------------------.");

            var studentInAbv = from student in students
                               where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                               select student;
            foreach (Student student in studentInAbv.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            //Task 12: Extract students by phone
            Console.WriteLine("Extract students by phone");
            Console.WriteLine("--------------------------------------------------------------------------.");
            var studentsInSofia = from student in students
                                  where student.Tel.Substring(0, student.Tel.IndexOf("/")) == "02"
                                  select student;

            foreach (Student student in studentsInSofia.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            //Task 13: TODO


            //Task 14: TOFO

            //Task 15: Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).");
            Console.WriteLine("--------------------------------------------------------------------------.");

            var studentWith2Fs = students.Where(st => st.Grades.Count(grade => grade == 2) == 2);
            foreach (Student student in studentWith2Fs.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            //Taks 15: Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).");
            Console.WriteLine("--------------------------------------------------------------------------.");

            var marksFrom06 = students.Where(st => st.FN.ToString().Substring(4, 2) == "06").Select(st=> st.Grades).SelectMany(grade=> grade) ;
            foreach (byte grade in marksFrom06.ToList())
            {
                Console.Write("{0} ",grade);                
            }
            Console.WriteLine();

            //Task 16 Groups 
            Console.WriteLine("Extract all students in Mathematics department");
            Console.WriteLine("--------------------------------------------------------------------------.");
            List<Group> groups = new List<Group>
            {
                new Group(1,"Mathematics"),
                new Group(2,"Biology"),
                new Group(3,"Philosophy"),
                new Group(4,"Literature"),
                new Group(5,"Economy")
            };

            var studentsInMath = from student in students
                                join gr in groups on student.GroupNumber equals gr.GroupID
                                where gr.Department == "Mathematics"
                                select student;

            foreach (Student student in studentsInMath.ToList())
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }

            //Task 18:Create a program that extracts all students grouped by GroupNumber and then prints them to the console
            Console.WriteLine("Create a program that extracts all students grouped by GroupNumber and then prints them to the console");
            Console.WriteLine("--------------------------------------------------------------------------.");

            var groupedByGroup = from student in students
                                 group student by student.GroupNumber into grouped
                                 select new { groupID = grouped.Key, st = grouped.ToList() };

            foreach (var group in groupedByGroup)
            {
                Console.WriteLine("Students in group {0}:", group.groupID);
                Console.WriteLine("***" );
                foreach(var student in group.st )
                {
                    Console.WriteLine("{0} ",student);
                }
                Console.WriteLine();
            }

            //Task 19 Rewrite the previous using extension methods.
            Console.WriteLine("Rewrite the previous using extension methods.");
            Console.WriteLine("---------------------------------------------");
            Dictionary<int, List<Student>> result = students.OrderByGroupNumber();


            
        }
    }
}
