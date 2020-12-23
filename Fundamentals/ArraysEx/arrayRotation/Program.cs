using System;

namespace arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());


            for (int c = 0; c < count; c++)
            {
                string temp = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
           
            arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
