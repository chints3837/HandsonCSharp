using System;

class Demo
{
    public int multiplication(int iNo)
    {
        int iResult=1;

        for(int i=1;i<iNo;i++)
        {
            if(iNo%i==0)
            {
                iResult=iResult*i;
            }
        }

        return iResult;
    }
}

class Program14
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.multiplication(iValue);
        Console.WriteLine("multiplication is :"+iResult);

    }
}