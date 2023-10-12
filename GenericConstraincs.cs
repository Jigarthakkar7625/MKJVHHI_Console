using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKJVHHI
{
    public class GenericConstraincs<T> where T : struct // Value Type   
    {
        public T Data12;

        public T[] Data = new T[15];

        public void Add(T item, int position)
        {

            //var abc = Data == null ? 0 : Data.Length;
            //Data = new T[abc];

            Data[position] = item;

        }

        public T[] ToList()
        {

            //var abc = Data == null ? 0 : Data.Length;
            //Data = new T[abc];

            return Data;

        }
        // Int, Boolean,
    }

    public class GenericConstraincsClass<T> where T : class // Value Type   
    {

        public T Data;

        public void Remove(T item)
        {


        }

    }


    public class GenericConstraincsNew<T> where T : new()
    {

        GenericConstraincsNew(int a) { 
        
        }
    }


    public class Customer
    {

    }


    public class Customer1 : Customer
    {

    }



    public class GenericConstraincsBaseClass<T> where T : Customer
    {

        
    }
}
