using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = 0;
            int previousNumber = 0, currentNumber = 1, nextNumber = 0;

            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber)); 
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
            Console.WriteLine(fibonnaci(ref firstTime, ref previousNumber, ref currentNumber, ref nextNumber));
        }

        static int fibonnaci(ref int firstTime, ref int previousNumber, ref int currentNumber, ref int nextNumber)
        {
            if (firstTime < 1)
            {
                nextNumber = previousNumber;
                firstTime++;
            }
            else
            {
                if(firstTime < 2)
                {
                    nextNumber = previousNumber + currentNumber;
                    firstTime++;
                }
                else
                {
                    nextNumber = previousNumber + currentNumber;
                    previousNumber = currentNumber;
                    currentNumber = nextNumber;
                }

            }
            return nextNumber;
        }
    }
}
