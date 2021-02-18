using System;
using System.Collections.Generic;
using System.Text;

namespace EventsandLambda
{
    public class Lambda
    {
        delegate int Incr(int v);
        delegate bool IsEven(int v);
        class SimpleLambdaDemo
        {
            static void Main()
            {
                Incr incr = count => count + 2;
                Console.WriteLine("Использование лямбда-выражения incr: ");
                int x = -10;
                while (x <= 0)
                {
                    Console.Write(x + " ");
                    x = incr(x);
                }
                Console.WriteLine("\n");
                IsEven isEven = n => n % 2 == 0;
                Console.WriteLine("Использование лямбда-выражения isEven: ");
                for (int i = 0; i <= 10; i++)
                    if (isEven(i)) Console.WriteLine(i + " четное.");
            }
        }
    }
}
