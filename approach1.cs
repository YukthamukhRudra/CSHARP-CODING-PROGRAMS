using System;
public delegate void sampledelegate();
class dlgt
{
    public static void Main()
    {
        sampledelegate del1, del2, del3, del4;
        del1 = new sampledelegate(Samplemethodone);
        del2 = new sampledelegate(Samplemethodtwo);
        del3 = new sampledelegate(Samplemethodthree);
        del4 = del1 + del2 + del3;
        del4();
    }

    public static void Samplemethodone()
    {
        Console.WriteLine("Sample methodOne Invoked");
    }
    public static void Samplemethodtwo()
    {
        Console.WriteLine("Sample methodTwo Invoked");
    }
    public static void Samplemethodthree()
    {
        Console.WriteLine("Sample methodthree Invoked");
    }

   
}