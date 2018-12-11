using System;

namespace Task_213д
{
    
    
        class Program
        {
            //Да се изчисли i^(1/i);

            static void Main(string[] args)
            {

                double i = 1;
                double a = 0;

                for (i = 1; i <= 49; i++)
                {
                    Console.WriteLine($"{i} root {i} = {Math.Pow(i, 1 / i)} ");
                    a = a + Math.Pow(i, 1 / i);

                }


                Console.WriteLine(a);



            }
        }
    
}
