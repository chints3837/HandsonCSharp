using System;

class Demo
{
    public double convert(float iNo)
    {
        double dResult;
        dResult=iNo*1000;

        return dResult;
    }
}

class Program32
{
    public static void Main(String[] args)
    {
        float iValue=0.0f;
        Console.WriteLine("Enter Number :");
        iValue=Single.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        double dResult=dobj.convert(iValue);
        Console.WriteLine("Answer is :"+dResult);
    }
}