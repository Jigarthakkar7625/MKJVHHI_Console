using System;

public class Class1
{


    // must initialized while declataion
    // public const int MyValue;

    //public readonly int MyValue1;

    public int UserId { get; set; } // Non Static

    public static string userName { get; set; } // Static

    static Class1()
    {
        userName = "Jigar";
        
    }


    public Class1() // Constructor
    {
        //userName = _userName;
        UserId = 10;
    }


    //~Class1() { 

    //}
    //public Class1(int userId = 150, int userId12 = 150) // Constructor
    //{
    //}

    //public Class1(int userId = 150, int userId12 = 150, int userId12s = 150) // Constructor
    //{
    //}


    //public Class1(Class1 class1) // Constructor
    //{

    //    //UserId = userId;
    //}


    //public int StudentId { get; set; }
    //public string StudentName { get; set; }

    //public int Method1(int a, int c = 1)
    //{
    //    return UserId;

    //}

}
