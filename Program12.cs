
using System;

class Demo
{
    public void convert(char ch)
    {
        if(ch>='a'&&ch<='z')
        {
            Console.WriteLine(char.ToUpper(ch));
        }
        else
        {
            Console.WriteLine(char.ToLower(ch));
        }
        
    }

}


class Program12
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Character :");
        char ch=Console.ReadLine()[0];

        Demo dobj=new Demo();
        dobj.convert(ch);

    }
}