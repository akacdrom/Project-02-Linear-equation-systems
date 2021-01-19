using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string userInput;
            Matrix matrix = new Matrix();
            
            Console.Clear();

            Console.WriteLine("Type linear equations in augmented matrix notation:");
            Console.WriteLine("Type 'end' to finish entering equations\n");

            while (true)
            { 
                Console.Write($"Eq {id}: ");
                userInput = Console.ReadLine();
                if (userInput == "END" || userInput == "end")
                {
                    break;
                }
                else
                {
                    matrix.addLine(userInput);
                    id++;
                }
            }

            Console.Clear();
            Console.WriteLine("You have entered the following equations:");
            matrix.read();
            

            
            Console.ReadLine();
        }
    }
}