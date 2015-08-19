using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV = 900;
            int DVD = 500;
            int MP3 = 700;
            double amt = 0;
            double tot = 0;

            System.Console.WriteLine(" enter the no. of quantity for TV ");
            int T = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(" enter the no. of quantity for DVD ");
            int D = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(" enter the no. of quantity for MP3 ");
            int M = Convert.ToInt32(System.Console.ReadLine());
            double order = T * TV + D * DVD;
            System.Console.WriteLine("order amount = " + order);
            if (order > 5000 && order<10000)
            {
                amt = order * 0.10;
                System.Console.WriteLine("  discount = " + amt);
                order = order - amt;

                System.Console.WriteLine("amountafter discount = " + order);

            }
            else if(order>10000)
                {
                amt = order * 0.15;
                System.Console.WriteLine("  discount = " + amt);
                order = order - amt;
                System.Console.WriteLine(" amount after discount = " + order);
            }
            else
            {
                amt = order;
                System.Console.WriteLine("order amount = " + tot);
            }
            tot = order + MP3 * M;
            System.Console.WriteLine("to total MP3 amount  payable {0}*{1} = {2} ", MP3,M, MP3*M);
            System.Console.WriteLine("to total amount  payable {0}+{1} = {2} ", MP3* M ,order,tot);

        }
    }
}