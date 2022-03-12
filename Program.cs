using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNewRandom100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 100);
            Console.WriteLine($"Случайное число {number}");
            int verificationNumberOne = 3;
            int verificationNumberTwo = 5;
            int sumNumber = 0;
             
            for (int i = 0; i < number; i++)
            {
                if (i % verificationNumberOne == 0 | i % verificationNumberTwo == 0)
                {
                    sumNumber += i;
                }
            }
            sumNumber += number;
            Console.WriteLine($"Сумма чисел кратное {verificationNumberOne} или {verificationNumberTwo} равно {sumNumber}");
        }
    }
}
