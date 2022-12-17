using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomMath
    {
        public void GetFactorialNums( int n)
        {
            int multiple = 1;

            for (int i = 1; i <= n; i++)
            {
                
                multiple *= i;
                
            }

            Console.WriteLine(multiple);

        }
 



        public void GetCountArray()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);   
        }

    }
}
