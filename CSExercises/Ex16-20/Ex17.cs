using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter name, age and gender of the person");
            string name = System.Console.ReadLine();
            int age = Convert.ToInt32(System.Console.ReadLine());
            char gender = Convert.ToChar(System.Console.ReadLine());
            if ((age >= 40) && (gender == 'M' || gender == 'm'))
            {
                System.Console.WriteLine(" Good Morning Uncle  " + name);
            }
            else if ((age >= 40) && (gender == 'F' || gender == 'f'))
            {
                System.Console.WriteLine(" Good Morning Aunty  " + name);
            }
            else if ((age < 40) && (gender == 'M' || gender == 'm'))
            {
                System.Console.WriteLine(" Good Morning Mr.  " + name);
            }

            else if ((age < 40) && (gender == 'F' || gender == 'f'))
            {
                System.Console.WriteLine(" Good Morning Ms  " + name);
            }
            else
                System.Console.WriteLine(" Error entering text");



            }
    }
}