using System;

namespace _36d
{
    class Program
    {
        //Запишете израз ,който е истина при изпълнение на указаното условие и лъжа в противен случай:
        //д)всяко от числата x,y,z е положително;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for x,y,z");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0 && z > 0) ;

            {

                Console.WriteLine("true");
            } 

             else
            {

                Console.WriteLine("false");
            }
        }
    }
}