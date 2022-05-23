﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab3Ex3_1 //Считать значение года с экрана консоли
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatsDay
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the year: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);
                Console.Write("Please enter a day number between 1 and 365: ");
                line = Console.ReadLine();
                int dayNum = int.Parse(line);

                if (dayNum < 1 || dayNum > 365)
                { //new
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine("Номер дня не входит в интервал 1 - 365. Исключение - " + caught);
            }
        }
        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}
