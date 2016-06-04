using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = "";
            int number = 10;

            while (way == "")
            {
                Console.Write("Enter the way to the text file: ");
                way = Console.ReadLine();
            }
            Console.Write("Enter the number of test-cases: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("By default number of test cases is 10", e);
            }
            ReadingFile(way, number);
            Console.Read();
        }

        public static void ReadingFile(string way, int number)
        {
            string file = "";
            int n = 0;
            try
            {
                StreamReader StreamReader = new StreamReader(way);
                while (n <= number)
                {
                    file += StreamReader.ReadLine();
                    n++;
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Could not find file", e);
            }
            Console.Write(file);
        }
    }
}
