using System;

namespace commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string result = "";

            foreach ( var word1 in arr2)
            {
                foreach (var word2 in arr1)
                {
                    if (word1 == word2)
                    {
                        result += word1 + " ";
                    }
                }
            }
            Console.WriteLine(result);

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int index = 0; index < arr1.Length; index++)
            //    {
            //        if (arr2[i] == arr1[index])
            //        {
            //            result = arr2[i] + " ";
            //        }
            //    }
            //}
           // Console.WriteLine(result);

        }
    }

}
    
