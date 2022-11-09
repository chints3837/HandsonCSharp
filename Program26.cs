
using System;
class Demo
{
    public int count(int iNo)
    {
        int iCnt=0;
        int iDigit=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit>3&&iDigit<7)
            {
                iCnt++;
            }
            iNo=iNo/10;
        }

        return iCnt;
    }
}


class Program26
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.count(iValue);
        Console.WriteLine("Digits are in between 3 and 7 :"+iResult);
    }
}
