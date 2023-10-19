using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MKJVHHI
{
    public delegate void PrintMsgFunctionDelgate(string Message);

    //File IO

    // Enc
    // Abs
    // Inheritance
    // Polymorphism

    //Access Modifier : 
    //Public : Anywhere in project

    //Private : { } :within { }
    //Protected : Class + Inharited class1 >> Inharited class2 ??
    //internal : Current Assembly 
    //protected internal ::  Current Assembly  +  Derive class
    // Private Protected :: Class+Derive class + Current Assembly 

    // Inharitace : 

    // Single
    // Multi level
    // Multiple level
    //Hybrid inh
    //Hirarchical inh





    public enum Days
    {
        [Description("January First Mnonth")]
        JanuaryFirstMnonth = 10,
        [Description("feb 2 Mnonth")]
        feb = 15,
        [Description("march 3 Mnonth")]
        march,
        [Description("april 4 Mnonth")]
        april = 20

    }


    public static class Program
    {

        delegate void Calculate(int a); // Declation


        public const int MyValue = 10;

        // User Define function
        // In build function
        static void Main(string[] args)
        {
            // Unitcast >> Single Method
            // Multicast >> Mutiple Method

            //Calculate calculate = new Calculate(StaticDemo.Add);

            //Calculate calculate = StaticDemo.Add; // initialization
            //calculate(10);


            //Calculate calculateMulti = StaticDemo.Multiplication; // initialization
            //calculateMulti(15); //invoke



            Calculate calculateMultiCast = StaticDemo.Add;
            calculateMultiCast += StaticDemo.Multiplication; // Multicast

            calculateMultiCast(22);




            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(1, "jigar"
                );

            Tuple<int, string, string, string, int, bool, int> tuple = Tuple.Create(1, "jigar", "jigar", "fdsd", 15, true, 12);

            var Item1 = tuple.Item1;
            var Item2 = tuple.Item2;
            var Item3 = tuple.Item3;



            var tuple123 = Tuple.Create(1, "jigar", "jigar", "fdsd", 15, true, 12, Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(1, 2, 3, 4, 5, 6, 7)));

            var Item8 = tuple123.Rest;

            var RestTuple1 = tuple123.Rest.Item1.Item1;




            FileInfo fileInfo = new FileInfo("E:\\Sample Text File\\My151120.txt");
            var fileName = fileInfo.FullName;


            DirectoryInfo directoryInfo = new DirectoryInfo("E:\\Sample Text File\\");

            if (directoryInfo.Exists)
            {
                var A = directoryInfo.GetFiles();

                for (int i = 0; i < A.Length; i++)
                {

                    FileInfo fileInfo123 = new FileInfo(A[i].FullName);

                    if (fileInfo123.Extension == ".txt")
                    {
                        // .txt

                    }

                }


            }



            StreamWriter streamWriter = File.CreateText("E:\\Sample Text File\\My151120.txt");


            streamWriter.WriteLine("Jigar Thakkar");

            streamWriter.Close();
            streamWriter.Dispose();


            //if (!fileInfo.Exists)
            //{
            //    fileInfo.Create();
            //}


            Console.WriteLine("File Created Successsfully!!");

            //using (TextReader w = File.OpenText("E:\\Sample Text File\\My.txt")) // Interview question
            //{
            //    w.ReadLine(); // FirstLine
            //    w.ReadToEnd();
            //    //w.WriteLine("Hello");
            //    //w.WriteLine("fdasfdsfds");
            //    //w.WriteLine("Helsdfsdfsdflo");
            //    //w.WriteLine("sdfsdfsf");
            //    //w.WriteLine("Hellsdfsdffdo");

            //}



            //FileStream fileStream = new FileStream("E:\\Sample Text File\\My.txt", FileMode.OpenOrCreate);
            //StreamReader streamWriter = new StreamReader(fileStream);

            //Console.WriteLine(streamWriter.ReadLine());

            //streamWriter.Close();
            //fileStream.Close();


            ////for (int i = 0; i < 40; i++)
            ////{
            //int myLength = 0;

            //while ((myLength = fileStream.ReadByte())!= -1) {

            //    Console.WriteLine((char)myLength);
            //}

            //fileStream.Close();
            //fileStream.Dispose();

            //}

            //byte[] bytes = Encoding.ASCII.GetBytes("My Name is Jigar");

            //fileStream.Write(bytes, 0, bytes.Length);

            //fileStream.Dispose();
            //fileStream.Close();
            //GenericConstraincsNew<Partial1236> genericConstraincsClass123 = new GenericConstraincsNew<Partial1236>();

            //GenericConstraincsBaseClass<ChildClassNew123> genericConstraincsBaseClass1 = new GenericConstraincsBaseClass<ChildClassNew123>();

            GenericConstraincsinterface<ChildInterfaceClass123> genericConstraincsinterface = new GenericConstraincsinterface<ChildInterfaceClass123>();


            GenericConstraincsinterface<IMyInterfaceChildTU, IMyInterfaceTU> genericConstraincsinterface1 = new GenericConstraincsinterface<IMyInterfaceChildTU, IMyInterfaceTU>();

            //genericConstraincsinterface1.MyMethod()


            //GenericConstraincsinterface<ChildWithoutInterfaceClass> genericConstraincsinterface12333 = new GenericConstraincsinterface<ChildWithoutInterfaceClass>();


            GenericConstraincs<int> genericConstraincs = new GenericConstraincs<int>();
            genericConstraincs.Add(10, 0);
            genericConstraincs.Add(20, 1);
            genericConstraincs.Add(30, 2);

            var abcList = genericConstraincs.ToList();

            //Generic Constrain
            //1. STruct
            //Class
            //new()
            //Baseclass
            //interface



            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("12", "sdfs");
            //hashtable.Add(null, "sfsdfdfs");
            //hashtable.Add("1225", "");


            // NON :

            // Array list
            // Dic
            // SortedList
            // hashtable
            // Stack and que

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("dsad");
            //arrayList.Add(false);
            //arrayList.Add(10);
            //arrayList.Add(10.5);
            //arrayList.Add('c');

            //ArrayList arrayList1 = new ArrayList();


            //arrayList1.Add("fdsf");


            //arrayList.AddRange(arrayList1);

            SortedList queue = new SortedList();// Fifo : First in First out
            queue.Add(15, "Value");

            //Dictionary dic = new Dictionary();

            Stack stack = new Stack();
            Queue Queue = new Queue();



            /*queue.Enqueue(10)*/
            ;

            // Generic Collection

            // List
            // Dictionary

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Jigar", "Jigar");
            dic.Add("Vivek", "Vivek");
            dic.Add("Ishita", "Ishita");
            dic.Add("Meet", "Meet");
            dic.Add("Meet12", null);


            SortedList<string, string> dic12 = new SortedList<string, string>();
            dic12.Add("Jigar", "Jigar");
            dic12.Add("Vivek", "Vivek");
            dic12.Add("Ishita", "Ishita");
            dic12.Add("Meet", "Meet");
            dic12.Add("Meet12", null);


            Queue<int> ints3 = new Queue<int>(); // Fifo : First in First out
            ints3.Enqueue(1);
            ints3.Enqueue(2);
            ints3.Enqueue(3);


            ints3.Dequeue();

            var abvvvv = ints3.Peek();


            Stack<int> sssssss = new Stack<int>(); // Lifo : Last in First out
            sssssss.Push(1);
            sssssss.Push(2);
            sssssss.Push(3);


            sssssss.Pop();

            var sssssssfgf = sssssss.Peek();


            //dic.ContainsKey("Vivek");
            //var abvcvcc =  dic["Ishita"];


            Partial2 partial2 = new Partial2();


            List<Partial1236> partial1236s = new List<Partial1236>();

            GenericConstraincsClass<Partial1236> genericConstraincsClass = new GenericConstraincsClass<Partial1236>(10);






            //GenericConstraincsNew<int> genericConstraincsNew = new GenericConstraincsNew<int>(10);

            //GenericConstraincsBaseClass<Customer> genericConstraincsBaseClass = new GenericConstraincsBaseClass<Customer>();

            //genericConstraincsClass.Remove(partial2);


            //genericConstraincsBaseClass.




            GenericConstraincs<long> genericConstraincs1 = new GenericConstraincs<long>();

            GenericConstraincs<bool> genericConstraincs2 = new GenericConstraincs<bool>();




            List<long> ints1 = new List<long>();

            ints1.Add(10);
            ints1.Add(15);

            ints1.Sort();

            var abbbbb = ints1.Find(x => x == 15);

            if (ints1.Contains(1500))
            {

            }


            List<string> ints2 = new List<string>();
            ints2.Add("");
            ints2.Add(null);

            List<Partial1236> obj = new List<Partial1236>();
            //{
            //        new Partial1236() {MyProperty = 15 },
            //        new Partial1236() {MyProperty = 20 }

            //};

            Partial1236 partialclass = new Partial1236();
            partialclass.MyProperty = 15;
            Partial1236 partialclass1 = new Partial1236();
            partialclass1.MyProperty = 20;
            obj.Add(partialclass);
            obj.Add(partialclass1);


            List<Partial1236> obj123 = new List<Partial1236>();
            Partial1236 partialclass12122 = new Partial1236();
            partialclass12122.MyProperty = 250;
            partialclass12122.FilterProp = "Jigar";

            Partial1236 partialclass112121 = new Partial1236();
            partialclass112121.MyProperty = 300;
            partialclass112121.FilterProp = "Vivek";





            obj123.Add(partialclass12122);
            obj123.Add(partialclass112121);

            var avcv = obj123.Find(x => x.FilterProp == "Vivek");

            obj.AddRange(obj123);


            foreach (var item in obj)
            {

                var abcccc = item;

            }






            //Partial1 partial = new Partial1();
            //partial.

            //Polymorphismcs polymorphismcs = new ChildPolymorphismcs();
            //var resultPoly =  polymorphismcs.get(10);

            ChildPolymorphismcs randObj = new ChildPolymorphismcs();
            var a = randObj.NextDouble(); // Custom result


            Random random = new Random();

            var bbbb = randObj.NextDouble();

            //var abc = randObj.Sample();


            //Random random = new Random();

            //var aabcdsdsd = random.samm();

            //            var aabcdd = random.Sample();





            //polymorphismcs.Get("");
            //polymorphismcs.Get(10);



            ChildClass childClass = new ChildClass();
            //childClass.MyParentProperty = 10;
            //childClass.MyChildProperty = 20;


            //ChildClass childClass1 = new ParentClass();

            ParentClass childClass1ss = new ChildClass();


            Class1 class1 = new Class1(10);


            string enumDesc = Days.JanuaryFirstMnonth.DescriptionAttr();
            string enumDesc1 = Days.JanuaryFirstMnonth.ToString();
            int enumDesc1s = (int)Days.JanuaryFirstMnonth;

            foreach (var item in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(item);
            }

            var jan = Days.JanuaryFirstMnonth;
            var feb = (int)Days.feb;
            var march = (int)Days.march;
            var april = (int)Days.april;

            // Try
            // Catch
            // Finally
            // Throw

            StructName structName = new StructName();
            structName.name = 10;

            //StructName structName = new StructName();
            //structName.MyMethod();


            int abcxs = 0;

            throw new Exception("This is my custom exception !!");

            try
            {


                // Open

                try
                {
                    try
                    {
                        int abcx = 0;

                        if (abcx == 0)
                        {
                            throw new Exception("This is my custom exception !!");

                        }

                        //var result = 10 / abcx; // Error
                    }
                    catch (Exception ex)
                    {


                        //throw;
                    }
                    finally
                    {

                        Console.WriteLine("");
                    }
                }
                catch (Exception)
                {

                    //throw;
                }

                finally
                {
                    // Close
                    Console.WriteLine("Finally");
                }


                // Close

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException" + e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("InvalidCastException");

            }
            catch (IOException e)
            {
                Console.WriteLine("IOException");

            }
            catch (FieldAccessException e)
            {
                Console.WriteLine("FieldAccessException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                // Close
                Console.WriteLine("Finally");
            }
            //  finally
            //{
            //    // Close
            //    Console.WriteLine("Finally");
            //}
            //catch (Exception)
            //{

            //    //throw;
            //}


            Console.WriteLine("jigar");


            // MyFunction(10, 25, "strig", true, false, 10.5, 'c', 45);
            // MyFunction(10, 25, "strig", true, false, 10.5, 'c', 45);

            Console.ReadLine();
            //Class1 class1 = new Class1("Jigar");
            //Class1 class52 = new Class1("Jigar12");
            //Class1 class45 = new Class1("Jigar362");

            //Class1.userName = "jigar";

            // Array : 

            // sIMPLE ARRQAY
            // tWO
            // mULTI
            //jAGGED ARRQAY

            int[,] array = new int[2, 2]; // 2D
            int[,,] arrays = new int[6, 6, 6]; // 2D

            int[][] jaggedARR = new int[3][];
            jaggedARR[0] = new int[10];
            jaggedARR[1] = new int[15];


            List<int> ints = new List<int>();



            //arrays[0, 0, 0] = 10;
            //arrays[0, 0, 0] = 10;
            //array[0, 2] = 10;
            //array[1, 1] = 10;
            //array[1, 2] = 10;


            //for (int i = 0; i < array.Count(); i++)
            //{
            //    var adfasdsf = array[i];
            //}



            Console.WriteLine(GC.GetTotalMemory(false));

            //Class1.userName = "jigasr";
            Class1 class33 = new Class1(10);

            Console.WriteLine(GC.GetGeneration(class33));

            Console.WriteLine(GC.CollectionCount(0));

            GC.Collect(0);

            Console.WriteLine(GC.CollectionCount(0));

            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();

            // Class1 class33 = new Class1();

            //Class1 class3344 = new Class1(class33);

            //// Constructor  :
            //// Default, Parameter less
            //// Parameterize Constructor
            //// Copy Constructor  
            //// Static Constructor
            //// Private Constructor



            ////Static

            //// Class
            //// Variable
            //// Method
            //// Constructor

            //var abcdd = StaticDemo.UserId;
            //StaticDemo.Get();


            //Class1 class2 = new Class1(15);
            //var userid =  class2.Method1(15);

            //Class1 class3 = new Class1();
            //var userid13 = class3.Method1(15);

            //int abccccccccc = 1500;

            //Class1 class2 = new Class1();
            //class2.Method1();
            //class2.StudentName = "fdfd";


            //ExampleOfout(out class2);



            //int dsddsd = 10;
            //Class1 class1 = new Class1();
            //class1.Method1();
            //class1.StudentName = "Meet";

            //getStringByRef(ref class1);


            ////Class1 class1 = new Class1();

            //class1.Method1();
            //class1.StudentName = "fdfd";

            // sTRING INTERPOLLATION
            // 

            // padRight and PadLeft

            var MyStting = "HelloW";

            var resultgbdf = MyStting.PadLeft(8, '0');
            var result23 = MyStting.PadRight(8, '0');



            string TEMP1 = "mYvVALUE";
            string TEMP2 = "mYvVALUEFSSFS";

            var newString = $"My New string : {TEMP1} {TEMP2} ";

            var newStringdsd = $"My New string " + TEMP1 + " " + TEMP2;


            //var a = 10;

            string abc = "Jigar"; // Create new abc object :store value in abc: 
            abc = "   Thakkar;Patel;    Shah;jain;Nadani    "; // Create new abc object :store value in abc >> abc : Garbage:

            //var NEWvARIABLE =  abc.TrimEnd();
            //var NEWvARIABLEWEW = abc.TrimStart();

            // String and string > variable declaration

            //abc = String.
            //abc.ToLower();
            //abc.ToUpper();
            var abccccc = abc.Split(';');

            var abcccccSDS = abc.Substring(2, 5);

            var ABCCC = abccccc[0];
            var ABCCCDSD = abccccc[1];
            var ABCCCDSDGFDG = abccccc[2];




            var aLength = abc.Length;

            var abcsss = abc.Clone();

            //if (abc.CompareTo("kk"))
            //{

            //}
            var compare = abc.LastIndexOf("a");


            //var compare = abc.StartsWith("O");

            //var compare = abc.CompareTo("Thakkar");


            if (true)
            {

            }



            var abcd = 10;

            abcd.ToString(); // Will not handle null value
            Convert.ToString(abcd); // // Will handle null value



            var booleanValue = (a == 10) ? true : false;

            if (a == 10)
            {

            }
            else
            {
                Console.WriteLine("FALSE");
                Console.WriteLine("hello");
                Console.WriteLine("hello");
                Console.WriteLine("hello");
                Console.WriteLine("hello");
                Console.WriteLine("hello");
            }

            //int abvccdfd = 20;
            //object obj = abvccdfd; // Boxing

            //object abvccdfdsdasd = 20;
            //int objadsa = Convert.ToInt32(abvccdfd); // unxBoxing

            //var result = getString(5);

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

        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }

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

        public static void getStringByRef(ref Class1 abc)
        {
            //abc = 30;
            //abc.StudentName = "Vivek";

        }
        public static void MyFunction(params int[] objects)
        {

            var a = objects[0];
            var b = objects[1];
            var c = objects[3];

            //abc = 30;
            //abc.StudentName = "Vivek";

        }

        public static int MyFunctions(params int[] objects)
        {
            return 1;

            Console.WriteLine("");


            //abc = 30;
            //abc.StudentName = "Vivek";

        }
        //public static void ExampleOfout(out Class1 abc)
        //{

        //    abc

        //    // businessdsdfs dssdsfs fss

        ////a = 2000;
        //}



    }

}
