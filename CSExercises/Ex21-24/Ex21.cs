using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" enter an integer number again");
            int i = Convert.ToInt32(System.Console.ReadLine());

           while (i != 88)
                {
                    System.Console.WriteLine(" enter an integer number again");
                    i = Convert.ToInt32(System.Console.ReadLine());
                }
            
        
               System.Console.WriteLine(" Lucky you....");


        }
    }
}
