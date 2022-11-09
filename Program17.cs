
using System;
class Demo
{
    public int addition(int iNo)
    {
        int iResult=0;
        for(int i=1;i<=iNo;i++)
        {
            if(iNo%i!=0)
            {
                iResult=iResult+i;
            }
        }
        return iResult;
    }
}


class Program17
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
       int iResult=dobj.addition(iValue);
       Console.WriteLine("Addition is :"+iResult);
    }
}