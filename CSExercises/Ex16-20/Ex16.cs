using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter name and gender of the person");
            string name = System.Console.ReadLine();
            char gender = Convert.ToChar(System.Console.ReadLine());
            if(gender == 'M' || gender == 'm')
            {
                System.Console.WriteLine(" Good Morning Mr  " + name);
            }
            else if ((gender == 'F' || gender == 'f'))
            {
                System.Console.WriteLine(" Good Morning Ms " + name);
            }
            else
            {
                System.Console.WriteLine(" Error entering text");
            }



        }
    }
}