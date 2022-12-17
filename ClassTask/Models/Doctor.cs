using ClassTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//4) Doctor adinda class olacaq, Doctor clasinin name, surname, address, birthday propertileri olacaq.
//Dogum tarixi 25.05.1993 - 15.12.2002 arasinda olan doctor-larin siyahisini ekranda gosteren method yazin.
//(25.05.1993  ve 15.12.2002 deyerleri methoda argument kimi gonderilecek)



namespace ClassTask.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }


        public string GetFullData()
        {
            return $" Name: {Name} Surname: {Surname} Address: {Address} Birthday: {Birthday} ";
        }
    }
}
