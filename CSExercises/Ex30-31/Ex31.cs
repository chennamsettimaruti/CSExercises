
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int fact = 0;
            for(int i = 1;i<=1000;i++)
            {
                
                for(int j = 1;j < i;j++)
                {
                    if(i%j==0)
                    {
                        fact = fact + j;
                    }
                }
                if(i==fact)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
