
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double NO, INVERSE, SQUAREROOT, SQUARE;
            Console.WriteLine("NO\tINVERSE\t\tSQUAREROOT\t\tSQUARE");
            Console.WriteLine("---------------------------------------------------------------------------------");
            for (NO = 1.0; NO <= 10; NO++)
            {
                INVERSE = 1 / NO;
                SQUAREROOT = Math.Sqrt(NO);
                SQUARE = NO * NO;
                Console.Write("{0:0.0}\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0##}", NO, INVERSE, SQUAREROOT, SQUARE);
                Console.WriteLine();
            }
            //Console.WriteLine();

        }
    }
}
