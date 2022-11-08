
using System;

class Demo
{
    public void display(int iNo1,int iNo2)
    {
 
        for(int i = 0;i<=iNo2;i++)
        {
            Console.WriteLine("Hello :"+iNo1);
        }
    }
}

class Program8
{
    public static void Main(String[] args)
    {
        int no1=0;
        int no2=0;

        Console.WriteLine("Enter First Number :");
        no1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number :");
        no2=int.Parse(Console.ReadLine());

        Demo dobj=new Demo();
       
        dobj.display(no1,no2);
    }
}