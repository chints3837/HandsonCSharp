


using System;

class Demo
{
    public void displayEvenFactor(int no)
    {
        for(int i=1;i<no;i++)
        {
            if(no%i==0)
            {
                if(i%2==0)
                {
                    Console.Write(i+"\t");
                }
            }
        }
    }
}
class Program11
{
    public static void Main(String[] args)
    {
        int no=0;
        Console.WriteLine("Enter Number ");
        no=int.Parse(Console.ReadLine());

        Demo dobj=new Demo();
        dobj.displayEvenFactor(no);
    }
}