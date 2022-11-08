using System;

class Demo
{

    public void display(int no)
    {
        if(no<10)
        {
            Console.WriteLine("Hello");
        }
        else{
            Console.WriteLine("Demo");
        }
    }
}

class Program7
{
    public static void Main(String[] args)
    {
        int no=0;

        Console.WriteLine("Enter Number :");
        no=int.Parse(Console.ReadLine());
        Demo dobj=new Demo();
        dobj.display(no);
    }
}