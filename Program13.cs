

using System;

class Demo
{
    public bool check(char ch)
    {
        if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
        {
            return true;
        }
        else
        {
          return false;
        }
       
        
    }

}


class Program13
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Character :");
        char ch=Console.ReadLine()[0];

        Demo dobj=new Demo();
       bool bRet= dobj.check(ch);

       if(bRet)
       {
        Console.WriteLine("Given Character is ovel");
       }
       else
       {
        Console.WriteLine("Given Character is not ovel");
       }

    }
}
