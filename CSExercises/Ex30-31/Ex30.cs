


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        static void Main(string[] args)
        {
            // this programm is not executing
            int x = 0;
            for (int i = 5; i <= 10000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        x++;

                    }
                }

                if (x == 0)
                {
                    Console.Write(i);
                }

            }
            
        }
    }
}
           

