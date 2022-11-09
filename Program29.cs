
using System;
class Demo
{
    public int difference(int iNo)
    {
        int iEven=0;
        int iOdd=0;
        int iDigit=0;
        int iRet=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit%2==0)
            {
                iEven=iEven+iDigit;
            }
            else
            {
                iOdd=iOdd+iDigit;
            }
            iNo=iNo/10;
        }
        iRet=iEven-iOdd;
        return iRet;
    }
}


class Program29
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.difference(iValue);
        Console.WriteLine("difference between odd and even :"+iResult);
    }
}
