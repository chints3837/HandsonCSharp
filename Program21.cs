

using System;

class Demo
{
    public int frequency(int iNo)
    {
        int iDigit=0;
        int iCnt=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit==2)
            {
               iCnt++;
            }
            iNo=iNo/10;
        }
        return iCnt;
    }
}


class Program21
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Entrt Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iCount=dobj.frequency(iValue);
        Console.WriteLine("Frequency is of 2 :"+iCount);

    }
}