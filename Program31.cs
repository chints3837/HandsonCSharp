
using System;
class Demo
{
    public double area(float iNo1,float iNo2)
    {
        return iNo1*iNo2;
    }
}


class Program31
{
    public static void Main(String[] args)
    {
        float iHeight=0;
        Console.WriteLine("Enter Number Height :");
        iHeight=Single.Parse(Console.ReadLine());

        float iWeidth=0;
        Console.WriteLine("Enter Number Weidth :");
        iWeidth=Single.Parse(Console.ReadLine());

        Demo dobj=new Demo();
        double iResult=dobj.area(iHeight,iWeidth);
        Console.WriteLine("Area of Rectangle is :"+iResult);
    }
}
