
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyBPSConsoleApplication
{
    class Program
    {
        /// <summary>
        /// Getting Even and Odd Number
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
           
           
            var ed = new EvenOdd();
            ed.ED();

            var v = "hello";
            MessageBox(v);


        }

        private static string MessageBox(string v)
        {
             v = "hi";
            return v;
        }

        

        public  class EvenOdd
        {
            public void ED()
            {
                Console.Title = "Even-Odd Application, "+ "Programmer: Ahmed Chowdhury "+ DateTime.Now;
                Console.WindowHeight = 10;
                Console.WindowWidth = 100;

                start:
                try {
                    Console.WriteLine("Please Enter a valid number: or Ctrl+C then press any key to Exit \n");
                    int input = int.Parse(Console.ReadLine());

                    if (input % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n{input} is an even number. \n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{input} is an odd number. \n");
                    }
                }
                catch(FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"\nInvalid entry: {ex.Message} \n");
                }
                Console.ForegroundColor = ConsoleColor.White;
                goto start;

            }


        }
    }
}



