using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Think of a number");
            Random r = new Random();
            int number = 0;
            // System.Console.WriteLine(r.Next(0,9));
            for (int i = 0; i <= 9; i++)
            {
                System.Console.WriteLine(r.Next(0, 9));
                number += r.Next(0, 9);

                //int g = Convert.ToInt32((r.Next(0, 9)));
            }

                switch (number)
                {
                    case 1:
                        System.Console.WriteLine(" your are a  Wizard");
                        break;
                    case 2:
                        System.Console.WriteLine(" your are a good guess");
                        break;
                    case 3:
                        System.Console.WriteLine(" your are lousy");
                        break;
                    case 4:
                        System.Console.WriteLine(" try again");
                        break;
                    case 5:
                        while (number >= 5)
                        {
                            System.Console.WriteLine(" you attempted {0}times =", number);
                            break;
                        }
                        break;


                }
            }

        }
    }
