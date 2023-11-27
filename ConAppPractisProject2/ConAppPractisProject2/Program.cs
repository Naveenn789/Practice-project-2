using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPractisProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Mphasis\Practise Project\Rainbow School.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            string data;
            using (StreamReader s = new StreamReader(file))
            {
                data = s.ReadToEnd();
            }
            Console.WriteLine(data);



            Console.ReadKey();

        }
    }
}
