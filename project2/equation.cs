using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Matrix
    {
        public List<string> equations = new List<string>();
        //public List<string>numbers = new List<string>();
        public void addLine (string userInput)
            {
                equations.Add(userInput);
            }

        public void read()
        {
            int id = 1;
            foreach (string equation in equations)
            {
                
                Console.Write($"\nEq #{id++}: ");
                putEq(equation);

            }
            for (int i = 0; i < equations.Count; i++) 
                {
                
                Console.WriteLine();
                
                try
                {
                    solve(equations[i],equations[i+1]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    Environment.Exit(0);
                }
                

            }
           
        }
        
        public void putEq(string equation)
        {
 
            var parts = equation.Split(' ').ToList();
            var last = parts[parts.Count - 1];
            parts.RemoveAt(parts.Count - 1);

            int k = 1;

            for (int i = 0; i < parts.Count; i++) 
                {
                   // numbers.Add(parts[i]);
                    if (i == 0)
                    {
                        Console.Write($"{parts[i]}*x{k++}");
                    }
                    else if (parts[i].Contains('-'))
                    {
                        parts[i] = parts[i].Replace("-","");   
                        Console.Write($" - {parts[i]}*x{k++}");
                    }
                    else
                    {
                        Console.Write($" + {parts[i]}*x{k++}");
                    }
                    //Console.WriteLine(parts[i]);

                }
                
                Console.Write(" = "+last);
                return;
        }

        public void solve(string equation,string equation2)
        {
            Console.WriteLine($"\n Answers: \n");

            var parts = equation.Split(' ').ToList();
            var parts2 = equation2.Split(' ').ToList();

            List<int> intList = parts.ConvertAll(int.Parse);
            List<int> intList2 = parts2.ConvertAll(int.Parse);
            
            for (int k=0; k<equations.Count(); k++)
            {
               
                double anan = (double) intList2[k] / intList[k];
                //Console.WriteLine(k+". Division: "+anan);

                try
                {
                    for (int i = k; i < equations.Count() +2; i++)
                    {
                        double sikik = (intList2[i])-(anan)*(intList[i]);
                        Console.Write(" "+sikik+" ");
                    } 
                }
                catch (System.ArgumentOutOfRangeException)
                {
                        break;
                }
                
            }      
        }
    }
}