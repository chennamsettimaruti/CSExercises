
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            // find out prime or not
            int i = 1;
            Console.WriteLine(" enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int j =2; j<=n/2;j++)
            {
                if (n % j == 0)
                    {

                    i = i + 1;
                }
            }
            if (i<=1)
            {
                Console.WriteLine("  A PRIME NUMBER");
            }
            else
            {
                Console.WriteLine(" NOT A PRIME NUMBER");
            }
        }
    }
}

               