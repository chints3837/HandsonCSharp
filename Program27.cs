
using System;
class Demo
{
    public int multiplication(int iNo)
    {
        int iMult=1;
        int iDigit=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit==0)
            {
                iDigit=1;
            }
            iMult=iMult*iDigit;
            iNo=iNo/10;
        }

        return iMult;
    }
}


class Program27
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.multiplication(iValue);
        Console.WriteLine("Multiplication is :"+iResult);
    }
}
