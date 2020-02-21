/*
 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
 где m — масса тела в килограммах, h — рост в метрах. 
 Громов Вячеслав
 */
using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа для рассчёта ИМТ.");
               
            Console.WriteLine("Введите вес человека в кг: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth /= 100;

            Console.Write("Индекс массы тела: ");
            double Index = weight / (heigth * heigth);
            Console.WriteLine("{0:0.##}", Index);

            Console.ReadKey();
        }
    }
}