using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine(" enter marks");
            int marks = Convert.ToInt32(System.Console.ReadLine());

            if ((marks>= 80)&&(marks<=100))
                    {
                System.Console.WriteLine(" You scored {0} marks which is A grade", marks);
                     }
            else if ((marks < 80) && (marks >= 60))
            {
                System.Console.WriteLine(" You scored {0} marks which is B grade", marks);
                     }
            else if ((marks < 60) && (marks >= 40))
            {
                System.Console.WriteLine(" You scored {0} marks which is C grade", marks);
                     }
            else if ((marks < 40) && (marks >= 0))
            {
                System.Console.WriteLine(" You scored {0} marks which is F grade", marks);
                     }
            else  
            {
                System.Console.WriteLine("** ERROR**");
                     }






        }
    }
}