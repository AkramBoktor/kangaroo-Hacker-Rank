using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class program
    {   
 /*
    * Complete the 'kangaroo' function below.
    *
    * The function is expected to return a STRING.
    * The function accepts following parameters:
    *  1. INTEGER x1
    *  2. INTEGER v1
    *  3. INTEGER x2
    *  4. INTEGER v2
    */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int k1 = x1 + v1;
            int k2 = x2 + v2;

            if (k1 == k2)
                return "Yes";
            else if (k1 == k2 / 2)
                return "Yes";
            else
                return "No";
        }

    

    class Solution
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = program.kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

     
        }
    }
}
}