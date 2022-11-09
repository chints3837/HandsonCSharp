using System;

class Demo
{
    public void display(int iNo)
    {
        int iDigit=0;
        while (iNo!=0)
        {
            iDigit=iNo%10;
            Console.WriteLine(iDigit);
            iNo=iNo/10;
        }
    }
}



class Program19
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