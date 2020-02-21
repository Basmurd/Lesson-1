﻿/*
 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * б) Сделать задание, только вывод организуйте в центре экрана
 * в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
 * Громов Вячеслав
*/
using System;

namespace NameSurnameCity
{
    class Program
    {
        static void Print(string[] msg, int x, int y)
        {

            for (int i = 0; i < msg.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(msg[i]);
            }

        }


        static void Main(string[] args)
        {
            string[] info = { "Vyacheslav", "Gromov", "Pechora" };


            Print(info, 50, 13);

            Console.ReadKey();
        }
    }
}