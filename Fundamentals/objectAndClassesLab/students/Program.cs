using System;
using System.Collections.Generic;

namespace students
{
    class Program
    {
        public static int Age { get; private set; }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                string age = tokens[2];
                string city = tokens[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;
                
                students.Add(student);
                command = Console.ReadLine();
                string filterCity = Console.ReadLine();

                foreach ( Student Student in students)
                {
                    if (student.City == filterCity)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                    }
                }
                

            }
            
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }
        public string City { get; set; }
    }
}
