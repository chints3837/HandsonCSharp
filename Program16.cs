
using System;

class Demo
{
    public void display(int iNo)
    {
        for(int i=1;i<=iNo;i++)
        {
            if(iNo%i!=0)
            {
                Console.Write(i+"\t");
            }
        }
    }
}

class Program16
{
    public static void Main(String[] args)
    {
        int iValue=0;
        Console.WriteLine("Enter Number :");
        iValue=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        dobj.display(iValue);
    }
}