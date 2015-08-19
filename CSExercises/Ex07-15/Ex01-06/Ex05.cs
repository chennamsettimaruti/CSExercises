using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter any number");
            double i = Convert.ToDouble(System.Console.ReadLine());
            double j = Math.Sqrt(i);

            System.Console.WriteLine("Squareroot of the number is  {0:#.000} ", j);
            System.Console.WriteLine("Squareroot of the number is  {0:#.#00} ", j);
            System.Console.WriteLine("Squareroot of the number is  {0:#.##0} ", j);
            System.Console.WriteLine("Squareroot of the number is  {0:0.#00} ", j);
            System.Console.WriteLine("Squareroot of the number is  {0:0.0#0} ", j);

        }
    }
}
