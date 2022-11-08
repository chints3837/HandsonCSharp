using System;

class Test
{
    public int divide(int no1,int no2)
    {
        if(no1<no2||no2<=0)
        {
            return 0;
        }
        int result=no1/no2;
        return result;
    }
}
class Program2
{
    public static void Main(String[] args)
    {
        int iValue1=0;
        int iValue2=0;

        Console.WriteLine("Enter First Number :");
        iValue1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter First Number :");
       iValue2=int.Parse(Console.ReadLine());

        Test tobj=new Test();

        int result=tobj.divide(iValue1,iValue2);
        if(result==0)
        {
            Console.WriteLine("Please Enter Proper Input");
        }
        else
        {
           Console.WriteLine("Result is :"+result);
   
        }
      

    }
}