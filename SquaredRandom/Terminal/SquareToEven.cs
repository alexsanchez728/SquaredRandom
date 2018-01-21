using System;
using System.Collections.Generic;

namespace SquaredRandom.Terminal
{
    class SquareToEven
    {
        static public void GetEvenSquares()
        {
            Random rnd = new Random();
            var numThings = new List<int>();
            var squareThings = new List<double>();
            var onlyEvens = new List<double>();

            for (int i = 0; i < 50; i++)
            {
                var rndValue = rnd.Next(1, 50);
                numThings.Add(rndValue);
                Console.WriteLine($"Number 1-50: {rndValue}");
            }

            foreach(var thing in numThings)
            {
                var roundSquare = Math.Round(Math.Sqrt(thing));
                squareThings.Add(roundSquare);
                Console.WriteLine($"square of Number: {roundSquare}");
            }

            foreach (var numb in squareThings)
            {
                var numToEven = numb;
                if (numToEven % 2 == 0)
                {
                    onlyEvens.Add(numToEven);
                    Console.WriteLine($"Only Even square numbers: {numToEven}");
                }
            }
            Console.ReadKey();
        }
    }
}
