﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks2024
{
    internal class task3
    {
        public static void solution()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 5: Console.WriteLine("Число равно 5");
                break;
                case 10: Console.WriteLine("Число равно 10");
                break;
                default: Console.WriteLine("Неизвестное число");
                break;
            }
            

        } 
        
    }
}
