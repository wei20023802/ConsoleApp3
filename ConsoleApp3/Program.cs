﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            double summeal = meal_cost + tip_percent + tax_percent;
            Console.WriteLine("用餐總費用：" + summeal);
        }
    }
}
