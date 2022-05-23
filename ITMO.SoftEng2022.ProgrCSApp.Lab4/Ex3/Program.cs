using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab4Ex3 //Использование возвращаемых параметров в методах
{
    public class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;

            if (n < 0)
                ok = false;

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }  
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }

            answer = f;
            return ok;
        }
        public class Test //Тестировка метода Factorial
        {
            static void Main()
            {
                int f;
                bool ok; 
                int x;

                Console.WriteLine("Number for factorial:");
                x = int.Parse(Console.ReadLine());

                ok = Utils.Factorial(x, out f);
            
                if (ok)
                    Console.WriteLine("Factorial(" + x + ") = " + f);
                else
                    Console.WriteLine("Cannot compute this factorial");
            }
        }
    }
}
