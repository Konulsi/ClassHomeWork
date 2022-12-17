
using ClassTask.Models;
using Service;


#region ClassTask

//Person person1 = new Person("Konul", "Ibrahimova", 26);
//Person person2 = new Person("Roya", "Meherremova", 26);
//Person person3 = new Person("Cavid", "Ismayilzade", 16);



//Person[] people = { person1, person2, person3 };



//GetPersonsByAge(people);

//static void GetPersonsByAge(Person[] arr)
//{
//	foreach (var item in arr)
//	{
//		if (item.Age > 20)
//		{
//			Console.WriteLine(item.Name, item.Surname, item.Age);
//		}
//	}
//}




//Student student1 = new Student("Cemile", "Cavadova", "Ehmedli", 18);
//Student student2 = new Student("cemil", "cunayev", "Sumqayit", 19);
//Student student3 = new Student("Huseynov", "Tural", "Nerimanov", 18);
//Student student4 = new Student("Abbasova", "Aysel", "Genclik", 19);
//Student student5 = new Student("Cavad", "Cabbarov", "Neftchiler", 18);



//static Student[] GetStudents()
//{
//    Student student1 = new Student()
//    {
//        Name = "Cemile",
//        Surname = "Cavadova",
//        Address = "Ehmedli",
//        Age = 22
//    };
//    Student student2 = new Student()
//    {
//        Name = "Cemil",
//        Surname = "Cunayev",
//        Address = "Ehmedli",
//        Age = 22
//    };
//    Student student3 = new Student()
//    {
//        Name = "Tural",
//        Surname = "Huseynov",
//        Address = "Ehmedli",
//        Age = 22
//    };

//    Student student4 = new Student()
//    {
//        Name = "Cavad",
//        Surname = "Cebiyev",
//        Address = "Ehmedli",
//        Age = 22
//    };
//    Student[] students = { student1, student2, student3, student4 };

//    return students;
//}

//string name = "Cavid";
//Console.WriteLine(name.ToLower());

//Console.WriteLine("Herf daxil edin");
//string? searchText = Console.ReadLine();

//var res=Search(GetStudents(),searchText);
//Console.WriteLine(res);


//static void Search(Student[] student)
//{
//	foreach (var item in student)
//	{
//		if (item.Name.Contains('C') || item.Name.Contains('c') || item.Surname.Contains('C') || item.Surname.Contains('c'))
//		{
//			Console.WriteLine(item.Name + " " + item.Surname + " " + item.Address + " " + item.Age);
//		}
//	}
//}

//static string Search(Student[] students,string searchText)
//{
//    foreach (Student student in students)
//    {
//        if (student.Name.ToLower().Contains(searchText.ToLower()) || student.Surname.ToLower().Contains(searchText.ToLower()))
//        {
//            return $"{student.Name} {student.Surname}";
//        }
//    }
//    return "Not found";
//}














#endregion




#region Calculator
//2) Calculator adinda class yaradirsiz,
//hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. 


//Calculator calculator = new Calculator();

//calculator.Calculation();

#endregion

#region Employee


//3)  Employee tipinden array olacaq.
//Employee clasinda name, surname, age, salary propertileri olmalidir.
//Maashi 1000 - 2000 arasinda olan employee-lerin melumatlarini ekranda
//gosteren method yazin. (1000 ve 2000 deyerleri methoda argument kimi gondermelidir).



//static Employee[] GetEmployees()
//{


//    Employee employee1 = new Employee()
//    {
//        Name = "Konul",
//        Surname = "Ibrahimova",
//        Age = 26,
//        Salary = 1500

//    };


//    Employee employee2 = new Employee()
//    {
//        Name = "Chinara",
//        Surname = "Ibadova",
//        Age = 22,
//        Salary = 1700

//    };


//    Employee employee3 = new Employee()
//    {
//        Name = "Roya",
//        Surname = "Meherremova",
//        Age = 26,
//        Salary = 1600

//    };


//    Employee employee4 = new Employee()
//    {
//        Name = "Cavid",
//        Surname = "Ismayilzade",
//        Age = 22,
//        Salary = 900

//    };


//    Employee employee5 = new Employee()
//    {
//        Name = "Alekber",
//        Surname = "Hesenov",
//        Age = 20,
//        Salary = 2600

//    };


//    Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };

//    return employees;

//}

//int startSalaryText = 1000;
//int endSalaryText = 2000;

//GetEmployeesSalary(GetEmployees(), startSalaryText, endSalaryText);


//static void GetEmployeesSalary(Employee[] employees, int startSalaryText, int endSalaryText)
//{
//    bool isExist = false;


//    foreach (var item in employees)
//    {
//        if (item.Salary > startSalaryText && item.Salary < endSalaryText)
//        {
//            Console.WriteLine(item.GetFullData());

//            isExist = true;
//        }

//    }
//    if (!isExist)
//    {
//        Console.WriteLine("bu maash araliginda ishci yoxdur");
//    }
//}
#endregion

#region Doctor

//4) Doctor adinda class olacaq, Doctor clasinin name, surname, address, birthday propertileri olacaq.
//Dogum tarixi 25.05.1993 - 15.12.2002 arasinda olan doctor-larin siyahisini ekranda gosteren method yazin.
//(25.05.1993  ve 15.12.2002 deyerleri methoda argument kimi gonderilecek)




Doctor doctor = new Doctor();


static Doctor[] GetDoctors()
{


    Doctor doctor1 = new Doctor()
    {
        Name = "Konul",
        Surname = "Ibrahimova",
        Address = "Nerimanov",
        Birthday = new DateTime(1995, 03, 12),

    };


    Doctor doctor2 = new Doctor()
    {
        Name = "Leyla",
        Surname = "Selimova",
        Address = "Genclik",
        Birthday = new DateTime(1991, 06, 22),
    };



    Doctor doctor3 = new Doctor()
    {
        Name = "Davud",
        Surname = "Memmedov",
        Address = "Hovsan",
        Birthday = new DateTime(2003, 07, 18),
    };


    Doctor doctor4 = new Doctor()
    {
        Name = "Mahir",
        Surname = "Azizov",
        Address = "Ehmedli",
        Birthday = new DateTime(2003, 03, 11),

    };



    Doctor doctor5 = new Doctor()
    {
        Name = "Arzu",
        Surname = "Isayeva",
        Address = "Nerimanov",
        Birthday = new DateTime(2000, 10, 02),

    };



    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };
    return doctors;
}

DateTime minDate = new DateTime(1993, 05, 25);
DateTime maxDate = new DateTime(2002, 12, 15);

GetDoctorsBirthday(GetDoctors(), minDate, maxDate);
static void GetDoctorsBirthday(Doctor[] doctors, DateTime minDate, DateTime maxDate)
{


    foreach (var doctor in doctors)
    {
        if (doctor.Birthday > minDate && doctor.Birthday < maxDate)
        {
            Console.WriteLine(doctor.GetFullData());
        }
    }

}

#endregion

#region Service Layer


//5) Service adinda layer yaradirsiz. Onun icerisinde CustomMath classi yaradirsiz.
//Hemin clasin icinde ashagidaki methodlar olacaq.
//Methodlari esas projectde (program.cs -de cagirib istifade edin).
//Faktorialin hesablanmasi.
//Arrayin icindeki tek ededlerin sayinin tapilmasi.



//CustomMath custom = new CustomMath();

//custom.GetFactorialNums( 5 );



//CustomMath custom2 = new CustomMath();

//custom2.GetCountArray();


#endregion

