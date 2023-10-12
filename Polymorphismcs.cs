using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MKJVHHI
{
    public class Polymorphismcs
    {

        public virtual string get(int a)
        {

            return a.ToString() + " Hello";

        }

        //public string Get(int b, int abc)
        //{
        //    return "";
        //}

        //public int Get(int a,int abcd)
        //{
        //    return 1;
        //}
    }

    public class ChildPolymorphismcs : Random
    {


        public override double NextDouble()
        {
            return base.NextDouble() * 10.25;
        }

        //public override int Next()
        //{
        //    return (int)(Sample() * int.MaxValue);
        //}


        //public string Get(int b, int abc)
        //{
        //    return "";
        //}

        //public int Get(int a,int abcd)
        //{
        //    return 1;
        //}
    }

}
