using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    class Program
    {
        static void Main()
        {

            //Creating lists of Students & Teachers
            List<Student> students = new List<Student>
            {
                new Student("Pesho Petrov"),
                new Student("Gosho Hristov"),
                new Student("Maria Ivanova"),
                new Student("Ivan Velikov")
            };           

            List<Teacher> teachers = new List<Teacher> 
            {
                new Teacher("Ivan Petrov", new List<Discipline> {new Discipline("Mathematics",24,24), new Discipline("Mathematics II",20,20)} ),
                new Teacher("Milena Georgieva", new List<Discipline> {new Discipline("Literature",24,24), new Discipline("Philosophy II",20,20)} ),
                new Teacher("Stoyan Velkov", new List<Discipline> {new Discipline("Geography",24,24), new Discipline("Biology",20,20)} ),
                new Teacher("Veselin Staykov", new List<Discipline> {new Discipline("Physycs",24,24)} ),
            };


            //Initialize a test class
            Class testClass = new Class("2a", students, teachers);

            //Initialize test sutdent
            var student = new Student("Pesho Petrov");

            //Student:CommentableObject  test
            student.AddComent("Some comment");





        }
    }
}
