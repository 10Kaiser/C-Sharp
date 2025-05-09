using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace firstApp
{
  class program
    {
        static void Main(string[] args)
        {
            //string name = "STest1";
            //const string kabuto = "ライダーキック";
            //int age = 6;
            //int n1 = 1, n2 = 2, n3 = 3;
            //string fivefivefive = "Complete";
            //char faiz = 'φ';


            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine();
            //Console.WriteLine(n1); Console.WriteLine(n2); Console.WriteLine(n3);
            //Console.WriteLine(kabuto);
            //Console.WriteLine(fivefivefive);
            //Console.WriteLine(faiz);



            //string h1, h2 = h1 = h2 = "hopper";
            //Console.WriteLine(h1);

            //double point = 3.1415;
            //bool btest;
            //btest = false;
            //Console.WriteLine(btest);
            //Console.WriteLine(point);
            //Console.WriteLine(n1 + n2 + n3);


            //int mynum = 35;
            //Console.WriteLine(mynum);
            //Console.WriteLine(mynum.GetType());
            //double mydub = 64.5;
            //Console.WriteLine(mydub);
            //Console.WriteLine(mydub.GetType());
            //int mynum2 = (int)mydub;
            //Console.WriteLine(mynum2);

            //string num6 = "32790";
            //string num9 = "1";

            //Console.WriteLine(Convert.ToInt32(num6) - Convert.ToInt32(num9));
            //Console.WriteLine(int.Parse(num6) + int.Parse(num9));

            //Console.WriteLine("Enter Name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi,My name is " + name);
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n1 + n2);

            //int x = 2;
            //x += 2;
            //Console.WriteLine(x);
            //x *= 4;
            //Console.WriteLine(x);
            //x -= 2;
            //Console.WriteLine(x);
            //x &= 40;
            //Console.WriteLine(x);
            //x ^= 2;
            //Console.WriteLine(x);
            //x /= 2;
            //Console.WriteLine(x);


            int x = 5;
            int y = 3; 
            int a = 1;
            int b = 1;
            Console.WriteLine(x > y);
            Console.WriteLine((a == 1 && b == 21) || x==5);

            string firstName = "Tendo";
            string lastName = "Soji";
            string name = string.Concat(firstName," ",lastName);
            Console.WriteLine(name);
            Console.WriteLine($"天の道を行き、総てを司る男 {firstName} {lastName}");
            Console.WriteLine("Ten no michi o iki, subete o tsukasadoru otoko {0} {1}", firstName,lastName);
            Console.WriteLine("We are the so-called \"Riders\". ");
            string ran = "Mugen";
            Console.WriteLine(ran);
            Console.WriteLine(ran.IndexOf("M"));
            Console.WriteLine(ran.Substring(2));


        }
    }
}
