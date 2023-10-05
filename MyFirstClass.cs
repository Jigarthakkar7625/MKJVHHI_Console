using System;

public class Class1
{


    // must initialized while declataion
    // public const int MyValue;

    //public readonly int MyValue1;

    private int UserId { get; set; } // Non Static

    public static string userName { get; set; } // Static

    public Class1(int _UserId)
    {
        UserId = _UserId;
    }


    //public Class1() // Constructor
    //{
    //    //userName = _userName;
    //    UserId = 10;
    //}


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

    private int Method1(int a, int c = 1)
    {

        return UserId;

    }

}


 struct StructName
{
    public int id, name;

    //public string MyMethod()
    //{
    //    return "Jigar";
    //}
}