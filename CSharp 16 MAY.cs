using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("φ");
            //int Code = Convert.ToInt32(Console.ReadLine());
            //if (Code == 555)
            //{
            //    Console.WriteLine("Standing By");
            //    Console.ReadLine();
            //    Console.WriteLine("Complete");
            //}
            //else if (Code == 913)
            //{
            //    Console.WriteLine("Standing By");
            //    Console.ReadLine();
            //    Console.WriteLine("Complete");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}








            //Console.WriteLine("Rider/Sentai");
            //string Toku = Console.ReadLine().ToLower();
            //switch(Toku)
            //{
            //    case "rider":
            //        Console.WriteLine("Era");
            //        string era = Console.ReadLine().ToLower();
            //        switch(era)
            //        {


            //            case "showa":
            //                Console.WriteLine("enter Rider");
            //                string Srider = Console.ReadLine().ToLower();

            //                switch(Srider)
            //                {
            //                    case "Ichigo":
            //                        Console.WriteLine("1");
            //                        break;
            //                    case "Nigo":
            //                        Console.WriteLine("3");
            //                        break;
            //                    case "v3":
            //                        Console.WriteLine("V3");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Invalid");
            //                        break;

            //                }
            //                break;



            //            case "heisei":
            //                Console.WriteLine("enter Rider");
            //                string Hrider = Console.ReadLine().ToLower();

            //                switch (Hrider)
            //                {

            //                    case "ryuki":
            //                        Console.WriteLine("Mirror");
            //                        break;
            //                    case "kabuto":
            //                        Console.WriteLine("Speed");
            //                        break;
            //                    case "gattack":
            //                        Console.WriteLine("Change Stag Beetle");
            //                        break;
            //                    case "den-o":
            //                        Console.WriteLine("Climax");
            //                        break;
            //                    case "ex-aid":
            //                        Console.WriteLine("game");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Invalid");
            //                        break;
            //                }
            //                break;



            //            case "reiwa":
            //                Console.WriteLine("enter Rider");
            //                string Rrider = Console.ReadLine().ToLower();

            //                switch (Rrider)
            //                {

            //                    case "zero one":
            //                        Console.WriteLine("Jump");
            //                        break;
            //                    case "revice":
            //                        Console.WriteLine("Rex");
            //                        break;
            //                    case "geats":
            //                        Console.WriteLine("MK IX");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Invalid");
            //                        break;
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Invalid");
            //                break;

            //        }
            //        break;


            //    case "sentai":
            //        Console.WriteLine("Enter colour");
            //        string sentai = Console.ReadLine().ToLower();
            //        switch (sentai)
            //        {
            //            case "aka":
            //                Console.WriteLine("Red");
            //                break;
            //            case "ao":
            //                Console.WriteLine("Blue");
            //                break;
            //            case "ki":
            //                Console.WriteLine("Yellow");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid");
            //                break;

            //        }
            //        break;

            //        default:
            //        Console.WriteLine("Invalid");
            //        break;

            //}




            int count = 2;

            while (count <= 8192)
            {
                Console.WriteLine(count);
                ////Console.WriteLine(count*2);
                //Console.WriteLine(count*4);
                ////count++;
                count = count * 2;
            };

            Console.WriteLine();

            for (int i = 0; i <= 10; i++) { Console.WriteLine(i); };
            for (int i = 9; i >= 0; i--) { Console.WriteLine(i); };



            string[] ride = { "Kuuga", "Agito", "Ryuki", "Faiz", "Blade", "Hibiki", "Kabuto", "Den-O", "Kiva", "Decade"};
            for (int i = 0; i <= 9; i++) { Console.WriteLine(ride[i]); };



        }
    }
}
