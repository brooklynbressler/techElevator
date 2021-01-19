using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            string userInput = Console.ReadLine();
            int fibonacciNumber = int.Parse(userInput);

            int a = 0;
            int b = 1;
            string fib = "";
            for (int i = 0; i < fibonacciNumber; i++)
            {
                int x = 0;
                if(i == 0)
                {
                    x = (a + b);
                    a = b;
                    b = x;
                    string myString = a.ToString();
                    fib += "0, " + myString + ", ";
                }
                if(a > fibonacciNumber)
                {
                    break;
                }
                if(a < fibonacciNumber)
                {
                    x = (a + b);
                    a = b;
                    b = x;
                    if (a > fibonacciNumber)
                    {
                        fib = fib.Substring(0, fib.Length -2);
                        Console.Write(fib);
                        break;
                    }
                    else
                    {
                        string myString = a.ToString();
                        fib += myString + ", ";
                    }
                }
            }   
                
        }
    }
}
