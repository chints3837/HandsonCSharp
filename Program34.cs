
using System;

class Demo
{
    public double convert(float area)
    {
        return area*0.0929;
    }
}

class Program34
{
    public static void Main(String[] args)
    {
        float fValue=0.0f;
        Console.WriteLine("Enter Area :");
        fValue=Single.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        double dResult=dobj.convert(fValue);
        Console.WriteLine("Conerted area in square meter is :"+dResult);

    }
}