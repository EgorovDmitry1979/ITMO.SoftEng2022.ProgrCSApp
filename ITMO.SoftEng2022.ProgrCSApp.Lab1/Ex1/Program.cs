﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab1Ex1 //Создание простой программы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
        }
    }
}
