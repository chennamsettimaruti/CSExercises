
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int temp = 0;
            int[] list = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;

                    }
                }
            }
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write("{0}\t", list[i]);
                }

            
        }
            
        }
    }

