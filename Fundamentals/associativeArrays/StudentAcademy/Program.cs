using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> listOfGrades = new Dictionary<string, List<double>>();
            string studentName;
            double studentGrade = 0;

            for (int i = 0; i < n; i++)
            {
                studentName = Console.ReadLine();
                studentGrade = double.Parse(Console.ReadLine());

                if (!listOfGrades.ContainsKey(studentName))
                {

                    listOfGrades.Add(studentName, new List<double>());

                }

                listOfGrades[studentName].Add(studentGrade);

            }
            foreach (var eachStudent in listOfGrades.OrderByDescending(x => x.Value.Average()))
            {

                if (eachStudent.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{eachStudent.Key} -> {eachStudent.Value.Average():f2}");
                }
            }
        }

    }

 }
    

