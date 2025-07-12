public delegate void SampleDelegate();
class Pragim
{
    public static void Main()
    {
        SampleDelegate del = new SampleDelegate(Samplemethodone);
        del += Samplemethodtwo;
        del += Samplemethodthree;
        del();


    }
    public static void Samplemethodone()
    {
        Console.WriteLine("Sample methodone invoked");
    }

    public static void Samplemethodtwo()
    {
        Console.WriteLine("Sample methodtwo invoked");
    }

    public static void Samplemethodthree()
    {
        Console.WriteLine("Sample methodthree invoked");
    }
}