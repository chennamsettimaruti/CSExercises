
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        // find out perfect number
        // the sum of the factors including 
       
        public static void Main(string[] args)
        {
            int temp = 0;
            Console.WriteLine(" enter any number");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    temp = temp + j;
                }
            }
            if (i == temp)
            {
                Console.WriteLine("PERFECT NUMBER");
            }
            else
            {
                Console.WriteLine("NOT A PERFECT NUMBER");
            }




            }


            
        }
    }


