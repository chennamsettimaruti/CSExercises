
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine(" enter any number");
            int x = Convert.ToInt32(Console.ReadLine());
            y = 2 * (x * x) - 4 * x + 3;
            // Console.WriteLine("{0},{1}+3 = {2}",2*(x* x),4*x,y);
            Console.WriteLine(y);



        }
    }
}
