using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab7Ex2 //Обращение строки
{
    class Utils //Создание метода Reverse
    {
        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            sRev = sRev + s[k];

            s = sRev;
        }
    }
    public class Test //Тестировка метода Reverse
    {
        public static void Main()
        {
            string message;

            Console.WriteLine("Enter string to reverse (Введите строку, чтобы изменить):");
            message = Console.ReadLine();

            Utils.Reverse(ref message);

            Console.WriteLine(message);
        }
    }
}
