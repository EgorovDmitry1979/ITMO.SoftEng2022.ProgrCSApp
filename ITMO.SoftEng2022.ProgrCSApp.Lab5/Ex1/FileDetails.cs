using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab5Ex1_1 //Передать в метод Main в качестве параметра имя текстового файла  
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
