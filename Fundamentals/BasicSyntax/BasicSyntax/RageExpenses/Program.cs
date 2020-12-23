using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double trashedHeadset = Math.Floor(lostGames / 2.0);
            double trashedMouse = Math.Floor(lostGames / 3.0);
            double trashedkeyboard = Math.Floor(lostGames / 6.0);
            double trashedDisplay = Math.Floor(lostGames / 12.0);

            double totalExpenses = (headsetPrice * trashedHeadset) + (mousePrice * trashedMouse) + (keyboardPrice * trashedkeyboard) + (displayPrice * trashedDisplay);


            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
