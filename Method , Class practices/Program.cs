

using Method___Class_practices;
using System;
#region Calculetor





//Calculate();
//static void Calculate()
//{
//    {


//        Calculator calculator = new();

//        Console.WriteLine("Add frist number :");

//    Number1: string number1 = Console.ReadLine();
//        int checkednum1;
//        bool isParseNum1 = int.TryParse(number1, out checkednum1);



//        if (!isParseNum1)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Plase add correct format number 1");
//            Console.ResetColor();
//            goto Number1;
//        }

//        Console.WriteLine("Add operation :");
//        string operation = Console.ReadLine();

//        Console.WriteLine("add second number :");

//    Number2: string number2 = Console.ReadLine();
//        int checkednum2;
//        bool isParseNum2 = int.TryParse(number2, out checkednum2);


//        if (!isParseNum2)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Plase add correct format number 2");
//            Console.ResetColor();
//            goto Number2;
//        }

//        if (checkednum2 == 0 && operation == "/")
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Plase dont add");
//            Console.ResetColor();
//            goto Number2;

//        }


//        var result = calculator.Calculation(checkednum1, checkednum2, operation);


//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(result);
//        Console.ResetColor();



//    }
//}



#endregion






#region Doctor 

//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 25);

//GetDoctorsByBirthday(startDate, endDate);


//static void GetDoctorsByBirthday(DateTime start, DateTime end)
//{
//    var doctors = GetDoctors();
//    foreach (var doctor in doctors)
//    {
//        if (doctor.Birthday > start && doctor.Birthday < end)

//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Adrress} {doctor.Birthday} ");
//        }
//    }
//}


//static Doctor[] GetDoctors()
//{
//    Doctor doctor = new Doctor()
//    {

//        Name = "Aqsin",
//        Surname = "Hummatov",
//        Adrress = "Xirdalan",
//        Birthday = new DateTime(2000, 07, 15)
//    };

//    Doctor doctor1 = new()
//    {
//        Name = "Mirze",
//        Surname = "Abbasov",
//        Adrress = "Sumqayit",
//        Birthday = new DateTime(2003, 12, 15)

//    };


//    Doctor doctor2 = new()
//    {
//        Name = "Aysel",
//        Surname = "Asadova",
//        Adrress = "Baki",
//        Birthday = new DateTime(2001, 05, 09)


//    };

//    Doctor doctor3 = new()
//    {
//        Name = "Aytac",
//        Surname = "Hasanova",
//        Adrress = "Baki",
//        Birthday = new DateTime(2002, 08, 01)


//    };

//    Doctor[] doctors = { doctor, doctor1, doctor2, doctor3, };

//    return doctors;
//}



#endregion






#region Order






//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order(new DateTime(2022, 12, 20), 1500);
//    var order4 = new Order(new DateTime(2022, 12, 21), 700);

//    return new Order[] { order1, order2, order3, order4 };


//}

//DateTime filterdDate = DateTime.Now.AddDays(1);

//double filteredPrice = 200;

//GetFiltredOrdes(filterdDate, filteredPrice);


//static void GetFiltredOrdes(DateTime date, double price)
//{
//    var orders = GetOrders();
//    foreach (var item in orders)
//    {

//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date + ":" + item.Price);
//        }

//    }
//}


#endregion





#region Ismarried

Person Person = new Person("Aqsin", "Hummatov", 27, false);

Person Person1 = new Person("Anar", "Asadov", 23, false);

Person Person2 = new Person("Gulnar", "Abbasova", 21, true);

Person Person3 = new Person("Aytac", "Abbasova", 21, true);

Person Person4 = new Person("Samir", "Hummatov", 21, true);



Person[] persons = new Person[] { Person1, Person2, Person3, Person4 };


int age = 25;

Brithday(persons, age);

static void Brithday(Person[] persons, int age)
{
    int count = 0;

    foreach (var item in persons)
    {

        if (item.Age < age && item.Ismarried == true)
        {

            count++;

        }


    }
    Console.WriteLine(count);


}





#endregion


