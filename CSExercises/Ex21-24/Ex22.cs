
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int HCF = 0;
            int LCM = 0;
            System.Console.WriteLine(" Enter A");
            int A = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(" Enter B");
            int B = Convert.ToInt32(System.Console.ReadLine());
            int x = A;
            int y = B;
            if (A > B)
            {
                while (A != B)
                {

                    A = A - B;
                }
                         }
            else
               while(B!=A)
            {
                B = B - A;
            }
            HCF = B;
             System.Console.WriteLine(" HCF of given two numbers is " + HCF);
             LCM = x * y / A;

            System.Console.WriteLine(" LCM of given two numbers is "+ LCM);



                 }
    }
}
