
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            double tot = 0;
            double avg = 0;
            string[] studentname = new string[] { " maha", "sita", "ravi", "kanth", "kish", "mohan", "jeevan", "lakshmi", "meher", "sridhar","maruti","chennam" };

            int[,] sub = new int[,] {
                { 56, 84, 68, 29 },
                { 94, 73, 31, 89 },
                { 41, 63, 36, 90 },
                { 99, 9, 18, 17 },
                { 62, 3, 65, 75 },
                { 40, 96, 53, 23 },
                { 81, 15, 27, 30 },
                { 21, 70, 100, 22 },
                { 88, 50, 13, 12 },
                { 48, 54, 52, 78 }, 
                { 64, 71, 67, 25 },
                { 16, 93, 46, 72 }
            };

            for(int i =0;i< studentname.Length;i++)
            {
                Console.Write("{0}\t{1}\t",i+1, studentname[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t",sub[i,j]);
                    tot = tot + sub[i,j];
                    avg = avg + sub[ i,j];
                        }
                Console.Write("{0}", tot);
                tot = 0;

                Console.WriteLine();
                
            }
            Console.WriteLine(" total marks of the class  " + avg);
            Console.WriteLine(" class average ="+ avg/12);



        }
    }
}
