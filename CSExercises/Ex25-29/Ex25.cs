
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            /* int tot = 1;
             Console.WriteLine(" enter any number");
             int i = Convert.ToInt32(Console.ReadLine());
             int n = i;
             while(i>0)
             {
                 tot = tot * i;
                 i--;
             }
             Console.WriteLine(" Factorial of given number is {0} = {1}", n, tot);*/
            int tot = 1;
            Console.WriteLine(" enter any number");
            int i = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            while (n <= i)
            {
                tot = tot * n;
                n++;
            }
            Console.WriteLine(" Factorial of given number is {0} = {1}", i, tot);







        }
    }
}
