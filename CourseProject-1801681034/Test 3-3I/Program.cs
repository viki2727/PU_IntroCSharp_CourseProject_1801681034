using System;

namespace Test_3_3I
{
    class Program
    {
        //F(n)= 1 + 1/2^4 + 1/3^4 .. + .. 1/n^4
        //Да се състави програма ,която въвежда 2 цели положителни числа a и b и изчислява F(a+b).F(|a-b|).

        static void Main(string[] args)
        {
            Console.WriteLine("F(n)= 1 + 1/2^4 + 1/3^4 .. + .. 1/n^4");
            Console.WriteLine("F(a+b)*F(|a-b|) = ?");
            int a, b;
            do
            {
                Console.WriteLine("Enter a: ");
                a = int.Parse(Console.ReadLine());

                
            } while (a <= 0);

            do
            {
                Console.WriteLine("Enter b: ");
                b = int.Parse(Console.ReadLine());

            } while (b <= 0);
            double n = (a + b);
            double m = Math.Abs(a - b);
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum1 += 1 / Math.Pow(i, 4);

            }
            Console.WriteLine("F(a+b): " + sum1);
            for (int i = 1; i <= m; i++)
            {
                sum2 += 1 / Math.Pow(i, 4);
            }
            Console.WriteLine("F(|a-b|): " + sum2);
            Console.WriteLine(" The result is {0}", (sum1 * sum2));

        }
    }
}
