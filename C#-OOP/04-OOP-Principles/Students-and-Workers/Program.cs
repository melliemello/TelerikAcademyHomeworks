using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_Workers
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho","Petrov",3),
                new Student("Gosho","Hristov",2),
                new Student("Maria","Ivanova",5),
                new Student("Velizar","Simeonov",3),
                new Student("Simeon","Petkov",6),
                new Student("Maria","Petrova",5),
                new Student("Vili","Georgieva",6),
                new Student("Gosho","Goshev",2),
                new Student("Simo","Temenujkov",5),
                new Student("Petka","Petrov",3)
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Pesho","Petrov",800,4),
                new Worker("Gosho","Hristov",2000,8),
                new Worker("Maria","Ivanova",500,4),
                new Worker("Velizar","Simeonov",3000,8),
                new Worker("Simeon","Petkov",600,4),
                new Worker("Maria","Petrova",500,4),
                new Worker("Vili","Georgieva",1500,8),
                new Worker("Gosho","Goshev",2000,8),
                new Worker("Simo","Temenujkov",550,4),
                new Worker("Petka","Petrov",3000,8)
            };



            Console.WriteLine("Students by grade, ascending");
            List<Student> studentsByGrades = students.OrderBy(st => st.Grade).ToList();
            foreach (Student st in studentsByGrades)
            {
                Console.WriteLine("{0}'s grade is {1}", st.ToString(), st.Grade);
            }


            List<Worker> workersBySalary = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();
            Console.WriteLine();
            Console.WriteLine("Workers by salary, descending");
            foreach (Worker w in workersBySalary)
            {
                Console.WriteLine("{0}'s money earn per hous is {1}", w.ToString(), w.MoneyPerHour());
            }


            var mergedList = workers.Concat<Human>(students).OrderBy(h=>h.FirstName).ThenBy(h=>h.LastName);
            Console.WriteLine();
            Console.WriteLine("Merged workers and students, sorted by first, then last name:");
            foreach (Human human in mergedList)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
