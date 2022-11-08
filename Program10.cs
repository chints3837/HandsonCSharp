
using System;

class Demo
{
    public void display(int no)
    {
        for(int i=1;i<=no;i++)
        {
            Console.Write(2*i+"\t");
        }
    }
}
class Program10
{
    public static void Main(String[] args)
    {
        int no=0;
        Console.WriteLine("Enter Number ");
        no=int.Parse(Console.ReadLine());

        Demo dobj=new Demo();
        dobj.display(no);
    }
}