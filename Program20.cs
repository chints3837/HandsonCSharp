using System;

class Demo
{
    public bool checkZero(int iNo)
    {
        bool bRet=false;
        int iDigit=0;
        while(iNo!=0)
        {
            iDigit=iNo%10;
            if(iDigit==0)
            {
                bRet=true;
                break;
            }
            iNo=iNo/10;
        }
        return bRet;
    }
}


class Program20
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Entrt Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        bool bRet=dobj.checkZero(iValue);
        if(bRet)
        {
            Console.WriteLine("This number contains Zero");
        }
        else
        {
            Console.WriteLine("This number not contains Zero");
        }

    }
}