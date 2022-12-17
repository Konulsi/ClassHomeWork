using ClassTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2) Calculator adinda class yaradirsiz,
//hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. 



namespace ClassTask.Models
{
    public class Calculator
    {
        


        public void Calculation()

        {
            float result = 0;


            Console.WriteLine("Reqem daxil edin");
            float n = float.Parse(Console.ReadLine());

            Console.WriteLine("Operatoru daxil edin");
            string op = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
            float m = float.Parse(Console.ReadLine());

           

            switch (op)
            {
                case "+":
                    result = n + m;
                    break;
                case "-":   
                    result = n - m; 
                    break;  
                case "*":   
                    result = n * m; 
                    break;  
                case "/":   
                    result = n / m; 
                    break; 
                    
            }
            Console.WriteLine("Netice = " + result);
        }

    }
}
