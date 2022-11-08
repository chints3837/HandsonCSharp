using System;


class Demo
{
    public void display(int no)
    {
        for(int i=0;i<no;i++)
        {
            Console.WriteLine("*");
        }
    }
}


class Program6
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter Number :");
        int no=int.Parse(Console.ReadLine());

        Demo dobj=new Demo();

        dobj.display(no);
    }
}