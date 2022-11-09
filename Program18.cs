using System;

class Demo
{
    public int difference(int iNo)
    {
        int iRet=0;
        int fact=0,nonFact=0;

        for(int i=1;i<iNo;i++)
        {
            if(iNo%i==0)
            {
                fact=fact+i;
            }
            else
            {
                nonFact=nonFact+i;
            }
        }
        iRet=fact-nonFact;
        return iRet;
    }
}

class Program18
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        int iResult=dobj.difference(iValue);
        Console.WriteLine("Difference is :"+iResult);
    }
}