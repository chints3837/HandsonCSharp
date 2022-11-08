using System;

class Demo
{
    public bool check(int no)
    {
        bool bRet=false;
        
        if(no/5==0)
        {
            bRet=true;
            return bRet;
        }
        return bRet;
    } 
}

class Program5
{
    public static void Main(String[] args)
    {
        int iNo1=0;
        Console.WriteLine("Enter Number :");
        iNo1=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        bool bResult=dobj.check(iNo1);
        if(bResult==true)
        {
            Console.WriteLine("Number is divided by 5");
        }
        else
        {
            Console.WriteLine("Number is not divisible by 5");
        }

    }
}