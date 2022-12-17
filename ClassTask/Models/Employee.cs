using ClassTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3)  Employee tipinden array olacaq.
//Employee clasinda name, surname, age, salary propertileri olmalidir.
//Maashi 1000 - 2000 arasinda olan employee-lerin melumatlarini ekranda
//gosteren method yazin. (1000 ve 2000 deyerleri methoda argument kimi gondermelidir).



namespace ClassTask.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public string GetFullData()
        {
            return $" Name: {Name} Surname: {Surname} Age: {Age} Salary: {Salary}";
        }


    }
}
