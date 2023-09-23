using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MKJVHHI
{
    internal class Program
    {
        // User Define function
        // In build function
        static void Main(string[] args)
        {

            //int abvccdfd = 20;
            //object obj = abvccdfd; // Boxing

            //object abvccdfdsdasd = 20;
            //int objadsa = Convert.ToInt32(abvccdfd); // unxBoxing

            var result = getString(5);

            //// Call by value
            //int abc = 20;

            //getString(abc);

            //Console.WriteLine(abc);


            //// Call by Referece
            //int abcd = 20;

            //getStringByRef(ref abcd);

            //Console.WriteLine(abcd);

            //int number = 25;
            //int number3 = 30;
            //var sr = Math.Floor(20.2515);
            //var sr1 = Math.Ceiling(20.2515);
            //var sr23 = Math.Round(20.563);

            //Console.WriteLine(sr);
            //Console.WriteLine(sr1);
            //Console.WriteLine(sr23);

            //// While
            //// Do-while
            //// For //
            //// Foreach


            //List<string> list = new List<string>();
            //list.Add("Jigar");
            //list.Add("Vivek");
            //list.Add("I");
            //list.Add("M");
            //list.Add("K");
            //list.Add("HH");







            //    for (int i = 0; i < list.Count; i++)
            //    {

            //        if (list[i] == "I")
            //        {
            //            goto checkValidation;
            //        }
            //        Console.WriteLine(list[i]);

            //    }

            //    Console.WriteLine("Hello ");
            //    Console.WriteLine("Hello 123");

            //checkValidation:
            //    Console.WriteLine("Direct call Go to statement");


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i <= list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.ReadLine();

            //while (false) // False
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}
            //Console.ReadLine();


            //do
            //{
            //    Console.WriteLine(number);
            //    number++;

            //} while (false);







            //string temp = "Jigar";

            //var tempVariable = "hello";

            //Console.WriteLine(temp);




            //int number = 150;
            //long number1 = 1054;

            //float float122 = 150.12212454544121F;

            //double double12212 = 150.12212454544121D;

            //char character = 'A';

            //Console.WriteLine(float122);
            //Console.WriteLine(double12212);




            //// Implicit type
            //int intergerVariable = 15;
            //double intergerDoublr = intergerVariable;




            //// Explicit type 

            //double? intergerDoublr1 = null;

            //int convertIntointefger = (int)intergerDoublr1; /// Error 

            //int convertIntointefger123 = Convert.ToInt32(intergerDoublr1); // handle  >> 0

            //Console.ReadLine();


            //int a = 10;
            //int b = 20;
            //int c = a + b; // Arithmetic Operators


            //int x = 10;
            //Console.WriteLine(x++); 
            //Console.WriteLine(x);

            //Console.WriteLine("<br>");

            //int y = 10;
            //Console.WriteLine(++y); // 11 
            //Console.WriteLine(y); // 11 

            //Console.WriteLine("<br>");

            //int a = 10;
            //Console.WriteLine(a--); // 10
            //Console.WriteLine(a); // 10

            //Console.WriteLine("<br>");

            //int b = 10;
            //Console.WriteLine(--b); // 9
            //Console.WriteLine(b); // 10

            //Console.WriteLine("<br>");

            // Assignmnt : 
            //int a = 10;

            //a += 20;  // >> a = a + 20;  //30

            //a *= 20; // -10; a = a * 20;

            //Comparision




            //1 && 1 > 1 
            //0 && 1 > 0 
            //1 && 0 > 0
            //0 && 0 > 0


            //1 || 1 > 1 
            //0 || 1 > 1 
            //1 || 0 > 1
            //0 || 0 > 0





            //&& >> And and
            // || >> OR
            // !  >> NOT
            //int a = 10;
            //int b = 20;

            //int c = 30;
            //int d = 40;

            //string sreing = "Manis";


            //switch (sreing)
            //{
            //    case "10":
            //        break;
            //    case "jigar":
            //        Console.WriteLine("20");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}



            //var result = a < b && b > d;

            //var result1 = a < b || b > d;

            //var result2 = !(a < b || b > d);
            //if (a > b)
            //{
            //    Console.WriteLine("TRUE");
            //    if (true)
            //    {

            //        if (true)
            //        {
            //            if (true)
            //            {
            //                if (true)
            //                {

            //                }

            //            }

            //        }

            //    }

            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("ELSE IF TRUE");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("ELSE IF TRUE");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("ELSE IF TRUE");
            //}
            //else 
            //{
            //    Console.WriteLine("FALSE");
            //}

            //5!
            //    5 * 4 * 3 * 2 * 1 : 120;



            Console.WriteLine();
            Console.ReadLine();




            Console.ReadLine();

            // x++ >  post inc
            // ++x > pre

            //x-- >  post dec
            //--x >  pre dec



            // Operators :

            // 1. Arithmetic Operators (Unary Operators)
            // 2. Logical
            //3 .Conditional
            //4. Relational Operators
            //5. Assignment Operators
            //6  Ternary Operator
            // 7 Unary Operators
            //8. Bitwise operator


        }

        //// P
        ////  C
        //      C
        //        C3
        //            C5
        //            c6
        //        C4

        public static int getString(int abc)
        {

            //20 * 3 
            //    60 * 2

            // 5,4,3,2,1
            if (abc == 1)
            {
                return 1;
            }
            else
            {
                return (abc * getString(abc - 1));
            }

            //if (abc > 0)
            //{
            //    Console.WriteLine(abc);
            //    getString(abc - 1);
            //}

            //abc = 30;
            
        }

        public static void getStringByRef(ref int abc)
        {
            abc = 30;

        }

    }

}
