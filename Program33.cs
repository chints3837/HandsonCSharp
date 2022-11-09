
using System;

class Demo
{
    public double convert(int iNo)
    {
        double dRet=0.0;
        iNo=iNo-32;
       int iCal=5/9;
        Console.WriteLine("vvvv:"+iNo);
        Console.WriteLine("vvvv:"+iCal);
        dRet=iNo*iCal;

         return dRet;

    }
}

class Program33
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        double dResult=dobj.convert(iValue);
        Console.WriteLine("Answer is ::"+dResult);
    }
}
