


using System;

class Demo
{
    public bool check(int iNo1)
    {
        if(iNo1%2==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program9
{
    public static void Main(String[] args)
    {
        int no1=0;
      

        Console.WriteLine("Enter First Number :");
        no1=int.Parse(Console.ReadLine());
       

        Demo dobj=new Demo();
        bool bRet=dobj.check(no1);

        if(bRet)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
    }
}