using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Claims;
using System.Security.Policy;

namespace OOPProgramming
{
    //class student0
    //{
    //    public string Name;
    //    public string Phone;

    //    public void intro()
    //    {

    //        Console.WriteLine($"Hi {Name} your Number is {Phone}");
    //    }
    //}

    //class animal
    //{
    //    public void sound()
    //    {
    //        Console.WriteLine("This animal makes sound.");
    //    }
    //}

    //class dog : animal
    //{
    //    public void bark()
    //    {
    //        Console.WriteLine("This animal barks.");
    //    }
    //}

    //class cat : dog
    //{
    //    public void meow()
    //    {
    //        Console.WriteLine("Cats meow");
    //    }
    //}

    //class room
    //{
    //    public string rnum;
    //    public void section()
    //    {
    //        Console.WriteLine($"Student studies in Room {rnum}");
    //    }
    //}

    //class student : room
    //{
    //    public string Name;
    //    public void intro()
    //    {

    //        Console.WriteLine($"Student name is {Name}");
    //    }
    //}


    //class program
    //{
    //    static void Main()
    //    {
    //        //objects
    //        //student student1 = new student();
    //        //Console.WriteLine("Enter Name");
    //        //student1.Name= Console.ReadLine();
    //        //Console.WriteLine("Enter Number");
    //        //student1.Phone= Console.ReadLine();
    //        //student1.intro();


    //        //student student2 = new student();
    //        //Console.WriteLine("Enter Name");
    //        //student2.Name = Console.ReadLine();
    //        //Console.WriteLine("Enter Number");
    //        //student2.Phone = Console.ReadLine();
    //        //student2.intro();

    //        dog dog1 = new dog();
    //        dog1.bark();
    //        dog1.sound();
    //        Console.WriteLine();

    //        animal animal1 = new animal();
    //        animal1.sound();
    //        Console.WriteLine();

    //        //student student1 = new student();
    //        //Console.WriteLine("Enter Name");
    //        //student1.Name = Console.ReadLine();
    //        //Console.WriteLine("Enter Room number");
    //        //student1.rnum = Console.ReadLine();
    //        //student1.intro();
    //        //student1.section();

    //        cat cat1 = new cat();
    //        cat1.bark();
    //        cat1.sound();
    //        cat1.meow();



    //        }

    //    }
    class Maths
    {
        public virtual void add()
        {
            Console.WriteLine(1 + 2);
        }
    }
    class Maths2 : Maths
    {
        public override void add()
        {
            Console.WriteLine(2 + 3);
        }
    }

    class prog {
        static void Main()
    {
        Maths2 var1 = new Maths2();
        var1.add();
            Maths mmm = new Maths();
            mmm.add();
    }
}
}










//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace conditionalStatements
//{
//     class Program
//    {

//        static void greet()
//        {
//            Console.WriteLine("Hi");
//        }

//        static void cname(string name, int code) {
//            Console.WriteLine($"Lets Go {name}, {code} Entry");
//        }

//        static void arith(int num1, int num2,char oper)
//        {
//            switch (oper) { 
//                case '+':
//            Console.WriteLine($"Sum is {num1+num2}");
//                    break;
//                case '-':
//            Console.WriteLine($"Difference is {num1 - num2}");
//                    break;
//                    case '*':
//            Console.WriteLine($"Product is {num1 * num2}");
//                    break;
//                case '/':
//            Console.WriteLine($"Quotient is {num1 / num2}");
//                    break ;

//            }
//        }

//        static void Main()
//        {
//            arith(50, 25,'+');
//            Console.WriteLine();
//            arith(48, 119, '-');
//            Console.WriteLine();
//            arith(2, 4096, '*');
//            Console.WriteLine();
//            arith(1365, 5, '/');
//            Console.WriteLine();


            //Console.WriteLine("Hello World");
            //cname("Faiz",555);
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace conditionalStatements
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("φ");
//            //int Code = Convert.ToInt32(Console.ReadLine());
//            //if (Code == 555)
//            //{
//            //    Console.WriteLine("Standing By");
//            //    Console.ReadLine();
//            //    Console.WriteLine("Complete");
//            //}
//            //else if (Code == 913)
//            //{
//            //    Console.WriteLine("Standing By");
//            //    Console.ReadLine();
//            //    Console.WriteLine("Complete");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Error");
//            //}





//            //Console.WriteLine("Eter Age");
//            //int age = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("Enter Education Level");
//            //string edu = Console.ReadLine().ToLower();
//            ////if(age >= 18)
//            ////{
//            ////    Console.WriteLine("Complete");
//            ////} else {
//            ////    Console.WriteLine("Error");
//            ////}
//            //if (age >= 18)
//            //{
//            //    Console.WriteLine("Complete");
//            //} else if(edu == "inter")
//            //{
//            //    Console.WriteLine("Complete");
//            //} else
//            //{
//            //    Console.WriteLine("Error");
//            //}


//            //Console.WriteLine("Enter Email");
//            //string email = Console.ReadLine().ToLower();
//            //if (email == "admin@gmail.com") 
//            //{
//            //    Console.WriteLine("Enter Password");
//            //    string pass = Console.ReadLine().ToLower(); 
//            //    if (pass == "admin")
//            //    {
//            //        Console.WriteLine("Welcome");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Wrong Password");
//            //    }
//            //}
//            //else
//            //{

//            //    Console.WriteLine("Inccorect Email");
//            //}




//            //Console.WriteLine("Enter Day number ");
//            //int day =int.Parse(Console.ReadLine());
//            //switch(day)
//            //{
//            //    case 1:
//            //        Console.WriteLine("Today is Sunday");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("Today is Monday");
//            //        break;
//            //    case 3:
//            //        Console.WriteLine("Today is Tuesday");
//            //        break;
//            //    case 4:
//            //        Console.WriteLine("Today is Wednesday");
//            //        break;
//            //    case 5:
//            //        Console.WriteLine("Today is Thursday");
//            //        break;
//            //    case 6:
//            //        Console.WriteLine("Today is Friday in California");
//            //        break;
//            //    case 7:
//            //        Console.WriteLine("Today is Saturday");
//            //        break;
//            //    default:
//            //        Console.WriteLine("Enter a Number from 1-7");
//            //        break;


//            //}





//            //Console.WriteLine("Rider/Sentai");
//            //string Toku = Console.ReadLine().ToLower();
//            //switch(Toku)
//            //{
//            //    case "rider":
//            //        Console.WriteLine("Era");
//            //        string era = Console.ReadLine().ToLower();
//            //        switch(era)
//            //        {


//            //            case "showa":
//            //                Console.WriteLine("enter Rider");
//            //                string Srider = Console.ReadLine().ToLower();

//            //                switch(Srider)
//            //                {
//            //                    case "Ichigo":
//            //                        Console.WriteLine("1");
//            //                        break;
//            //                    case "Nigo":
//            //                        Console.WriteLine("3");
//            //                        break;
//            //                    case "v3":
//            //                        Console.WriteLine("V3");
//            //                        break;
//            //                    default:
//            //                        Console.WriteLine("Invalid");
//            //                        break;

//            //                }
//            //                break;



//            //            case "heisei":
//            //                Console.WriteLine("enter Rider");
//            //                string Hrider = Console.ReadLine().ToLower();

//            //                switch (Hrider)
//            //                {

//            //                    case "ryuki":
//            //                        Console.WriteLine("Mirror");
//            //                        break;
//            //                    case "kabuto":
//            //                        Console.WriteLine("Speed");
//            //                        break;
//            //                    case "gattack":
//            //                        Console.WriteLine("Change Stag Beetle");
//            //                        break;
//            //                    case "den-o":
//            //                        Console.WriteLine("Climax");
//            //                        break;
//            //                    case "ex-aid":
//            //                        Console.WriteLine("game");
//            //                        break;
//            //                    default:
//            //                        Console.WriteLine("Invalid");
//            //                        break;
//            //                }
//            //                break;



//            //            case "reiwa":
//            //                Console.WriteLine("enter Rider");
//            //                string Rrider = Console.ReadLine().ToLower();

//            //                switch (Rrider)
//            //                {

//            //                    case "zero one":
//            //                        Console.WriteLine("Jump");
//            //                        break;
//            //                    case "revice":
//            //                        Console.WriteLine("Rex");
//            //                        break;
//            //                    case "geats":
//            //                        Console.WriteLine("MK IX");
//            //                        break;
//            //                    default:
//            //                        Console.WriteLine("Invalid");
//            //                        break;
//            //                }
//            //                break;
//            //            default:
//            //                Console.WriteLine("Invalid");
//            //                break;

//            //        }
//            //        break;


//            //    case "sentai":
//            //        Console.WriteLine("Enter colour");
//            //        string sentai = Console.ReadLine().ToLower();
//            //        switch (sentai)
//            //        {
//            //            case "aka":
//            //                Console.WriteLine("Red");
//            //                break;
//            //            case "ao":
//            //                Console.WriteLine("Blue");
//            //                break;
//            //            case "ki":
//            //                Console.WriteLine("Yellow");
//            //                break;
//            //            default:
//            //                Console.WriteLine("Invalid");
//            //                break;

//            //        }
//            //        break;

//            //        default:
//            //        Console.WriteLine("Invalid");
//            //        break;

//            //}




//            //int count = 2;

//            //while (count <= 8192)
//            //{
//            //    Console.WriteLine(count);
//            //    ////Console.WriteLine(count*2);
//            //    //Console.WriteLine(count*4);
//            //    ////count++;
//            //    count = count * 2;
//            //};

//            //Console.WriteLine();

//            //for (int i = 0; i <= 10; i++) { Console.WriteLine(i); };
//            //for (int i = 9; i >= 0; i--) { Console.WriteLine(i); };



//            //string[] ride = { "Kuuga", "Agito", "Ryuki", "Fφiz", "Blade", "Hibiki", "Kabuto", "Den-O", "Kiva", "Decade", "W", "OOO", "Fourze", "Wizard", "Gaim", "Drive", "Ghost", "Ex-aid", "Build", "Zi-O" };
//            //for (int i = 0; i <= 8; i++) { Console.WriteLine(ride[i]); };

//            //Console.WriteLine();

//            //foreach (string i in ride)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //Console.WriteLine();

//            //for (int i = 0; i < ride.Length; i++) { Console.WriteLine(ride[i]); };



//            String[] colour = { "Red", "Blue", "Yellow", "Green", "Pink" };
//            String[] number = { "One", "Two", "Three", "Four", "Five" };



//            Console.WriteLine("Colour/Number");
//            string select = Console.ReadLine().ToLower();

//            switch (select)
//            {
//                case "colour":
//                    foreach (string i in colour)
//                            Console.WriteLine(i);
//                    Console.WriteLine("Select Colour");
//                    string scolour = Console.ReadLine().ToLower();
//                    switch (scolour)
//                    {
//                        case "red":
//                            Console.WriteLine("You slected " + scolour);
//                            break;
//                        case "blue":
//                            Console.WriteLine("You slected " + scolour);
//                            break;
//                        case "yellow":
//                            Console.WriteLine("You slected " + scolour);
//                            break;
//                        case "green":
//                            Console.WriteLine("You slected " + scolour);
//                            break;
//                        case "pink":
//                            Console.WriteLine("You slected " + scolour);
//                            break;

//                    }


//                    break;

//                case "number":
//                    for (int i = 0; i < number.Length; i++)
//                    { Console.WriteLine(number[i]); }
//                    ;
//                    Console.WriteLine();
//                    Console.WriteLine("Select a Number");
//                    string snumber = Console.ReadLine().ToLower();
//                    switch (snumber)
//                    {
//                        case "1":
//                            Console.WriteLine("You slected " + number[0]);
//                            break;
//                        case "2":
//                            Console.WriteLine("You slected " + number[1]);
//                            break;
//                        case "3":
//                            Console.WriteLine("You slected " + number[2]);
//                            break;
//                        case "4":
//                            Console.WriteLine("You slected " + number[3]);
//                            break;
//                        case "5":
//                            Console.WriteLine("You slected " + number[4]);
//                            break;

//                    };
//                    break;
//                default:
//                            Console.WriteLine("Invalid");
//                    break;
//            }





//        }
//    }
//}
