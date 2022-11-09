
using System;
class Demo
{
    public double area(float iNo)
    {
        double iRet=0.0;

        iRet=3.14*iNo*iNo;
        return iRet;
    }
}


class Program30
{
    public static void Main(String[] args)
    {
        float iValue=0;
        Console.WriteLine("Enter Number ::");
        iValue = Single.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        double iResult=dobj.area(iValue);
        Console.WriteLine("Area is :"+iResult);
    }
}
