
using System;
class Demo
{
    public int frequency(int iNo)
    {
        int iCnt=0;
        int iDigit=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit<6)
            iCnt++;
            iNo=iNo/10;
        }

        return iCnt;
    }
}


class Program23
{
    public static void Main(string[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.frequency(iValue);
        Console.WriteLine("Number of Frequency less than 6 :"+iResult);
    }
}