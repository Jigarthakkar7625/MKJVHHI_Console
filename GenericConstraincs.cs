using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKJVHHI


// Generic Contrian

// Struct : Value 
// Class : Reference : Parameterize contructor can be used
// new() : Default constructor
// Base class : koi parent 
// Interface : 
{
    public class GenericConstraincs<T> where T : struct // Value Type   
    {
        public T _Data;

        public T _Data1;

        public T[] Data = new T[15];

        public void Add(T Data, T Data1)
        {

            //var abc = Data == null ? 0 : Data.Length;
            //Data = new T[abc];

            //Data[position] = item;

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

        public GenericConstraincsClass(int a)
        {

        }

        public T Data;

        public void Remove(T item)
        {


        }

    }


    public class GenericConstraincsNew<T> where T : new()
    {
        public GenericConstraincsNew()
        {
        }
    }


    public class BaseClass
    {

    }


    public class ChildClassNew : BaseClass
    {

    }


    public class ChildClassNew123
    {

    }



    public class GenericConstraincsBaseClass<T> where T : BaseClass
    {


    }


    public interface IMyInterface
    {
        void GetString();

    }

    public class ChildInterfaceClass : IMyInterface
    {
        public void GetString()
        {
            throw new NotImplementedException(); // Custom
        }
    }

    public class ChildInterfaceClass123 : IMyInterface
    {
        public void GetString()
        {
            throw new NotImplementedException(); // Custom
        }
    }


    public class ChildInterfaceClass12354 : IMyInterface
    {
        public void GetString()
        {
            throw new NotImplementedException(); // Custom
        }
    }



    public class ChildWithoutInterfaceClass
    {


    }

    public class GenericConstraincsinterface<T> where T : IMyInterface
    {


    }



    public interface IMyInterfaceTU
    {

    }

    public class IMyInterfaceChildTU : IMyInterfaceTU
    {

    }

    public class GenericConstraincsinterface<T, U> where T : U
    {
        public void MyMethod(T sub, U baseclass)
        {

        }

    }




}
