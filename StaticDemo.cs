using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKJVHHI
{
    public static class StaticDemo
    {
        public static int UserId { get; set; }

        public static void Get()
        {

        }


        public static void Add(int a)
        {

            Console.WriteLine("This is Method Add : " + a);
        }

        public static void Multiplication(int a)
        {

            Console.WriteLine("This is Method Multiplication : " + a);
        }

    }
}
