using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKJVHHI
{
    public class ParentClass // Parent, Base class
    {
        public int MyParentProperty { get; set; }

        public void MyParentMethod()
        {

        }

    }

    public class ChildClass : ParentClass // Child, Derive class
    {

        public int MyProperty { get; set; }

    }

    interface IA
    {
        void IAMethod();

    }

    interface IB
    {
        void IBMethod();

    }



    public class C : IA, IB // Child, Derive class
    {
        public void IAMethod()
        {
            var a=  3 * 2;
        }

        public void IBMethod()
        {
            var a = 3 * 3;
        }
    }




}
