/*
Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.
Громов Вячеслав
*/
using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 16;
            int b = 28;

            b = a + b; 
            a = b - a; 
            b = b - a;

            Console.ReadKey();

        }
    }
}