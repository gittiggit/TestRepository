using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOfSumSquareAndSqurare
{
    class Program
    {
        static void Main(string[] args)
        {
           int lowerLimit = 1;
           int upperLimit = 100;

           int squareOfTheSum = GetSquareOfTheSum(lowerLimit, upperLimit);
           int sumOfTheSquare = GetSumOfTheSquare(lowerLimit, upperLimit);
           int difference = GetDifference(squareOfTheSum, sumOfTheSquare);

           Console.WriteLine("Square of the sum is : "+squareOfTheSum);
           Console.WriteLine("Sum of the square is : " + sumOfTheSquare);
           Console.WriteLine("Difference between them is  : " + difference);

           Console.ReadLine();


        }

        static int GetSquareOfTheSum(int start , int end) 
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;
            }
                return sum*sum;
        }

        static int GetSumOfTheSquare(int start , int end) 
        {
            int sum = 0;

            for (int i = start; i <= end;i++ )
            {
                sum = sum + i*i;
            }
            return sum;
        }

        static int GetDifference(int square , int sum) 
        {
            return square - sum ;
        }

    }
}
