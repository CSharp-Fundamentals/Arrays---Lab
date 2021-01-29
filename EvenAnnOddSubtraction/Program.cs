using System;
using System.Linq;

namespace EvenAnnOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEvens = 0;
            int sumOdds = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    sumEvens += arr[i];
                }
                else
                {
                    sumOdds += arr[i];
                }
            }
            Console.WriteLine(sumEvens-sumOdds);
        }
    }
}
