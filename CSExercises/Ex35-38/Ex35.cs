
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            /* string s1;
             int num = 0;
             Console.WriteLine(" Enter a phrase");
             string s = Console.ReadLine();

             for (int I = 0; I < s.Length; I++)
             {
                 s1 = s.Substring(I, 1).ToLower();
                 if ((s1 == "a") || (s1 == "e") || (s1 == "i") || (s1 == "o") || (s1 == "u"))
                         {
                     num++;
                 }
             }

             Console.WriteLine(" the total number of vowels = {0}", num);*/

            string s1;
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            Console.WriteLine(" Enter a phrase");
            string s = Console.ReadLine();
             s1 = s.ToLower();
            for (int I = 0; I < s.Length; I++)
                switch (s1.Substring(I, 1))
                {
                    case "a":

                        {                       
                            num1++;
                        }
                        break;

                    case "e":

                        {                       
                            num2++;
                        }
                        break;

                    case "i":
                       
                        {
                            num3++;
                        }
                        break;

                    case "o":
                        
                        {
                            num4++;
                        }
                        break;

                    case "u":
                        
                        {
                            num5++;
                        }
                        break;
                }
        
        Console.WriteLine("a={0}\te={1}\ti={2}\to={3}\tu={4}",num1,num2,num3,num4,num5); 

                       

                    


                }


        }
    }


