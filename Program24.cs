
using System;
class Demo
{
    public int countEven(int iNo)
    {
        int iCnt=0;
        int iDigit=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit%2==0)
            {
                iCnt++;
            }
            iNo=iNo/10;
        }

        return iCnt;
    }
}


class Program24
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.countEven(iValue);
        Console.WriteLine("Frequency of Even is :"+iResult);
    }
}