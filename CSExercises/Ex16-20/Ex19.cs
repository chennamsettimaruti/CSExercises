
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            // 1km = 1000 metres;
            double totalcharge = 0;
            double minimum = 2.40;
            double distance = 0;
            System.Console.WriteLine(" enter distance travelled");
            distance = Convert.ToDouble(System.Console.ReadLine());

            double d = (Math.Ceiling(distance *10))/10;
            System.Console.WriteLine("distance = " + d);
            

            // for 100 m = 0.04 then 1km = 0.04*10;
            if (d<=0.5)
            {
                totalcharge = minimum;
            }
            else if(d>0.5 && d<=8.5)
            {
                totalcharge = minimum + (0.40 * (d - 0.5));
            }
            else 
            {
                totalcharge = minimum + (0.40 * 8.5) + (0.50 * (d - 9.0));
            }

            System.Console.WriteLine(" total charge on  distance travelled  $ {0:00.#0} " , totalcharge);
        }
    }
}