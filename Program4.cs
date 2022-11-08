
using System;

class Demo
{
    public void display()
    {
        for(int i=5;i>0;i--)
        {
            Console.WriteLine("Value is :"+i);
        }
    }
}

class Program4
{
    public static void Main(string[] args)
    {
        Demo dobj=new Demo();
        dobj.display();
    }
}