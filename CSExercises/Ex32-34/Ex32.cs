
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int max = 0, min = 0;
            int avg = 0;
            int[] sales = new int[12];
            string[] months = new string[] { "january", "febraury", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            for (i = 0; i < sales.Length; i++)
            {
                sales[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter sales for month {0} : {1}", i, sales[i]);
                max++;
                avg = avg + sales[i];
            }
            Console.WriteLine(" Maximum sale is" + max);
            Console.WriteLine(" Minimum sale is" + min);
            Console.WriteLine("average sales :" + (avg / 12));



        }
    }
}
