
using System;


class Demo
{
    public void display(int iNo)
    {
        for(int i=iNo/2;i>0;i--)
        {
            if(iNo%i==0)
            {
                Console.Write(i+"\t");
            }
        }

    }
}



class Program15
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