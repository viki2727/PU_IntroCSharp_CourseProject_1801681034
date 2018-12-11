using System;

namespace _15
{
    class Program
    {
       // Да се състави алгоритъм за изчислявяне на разстоянието d между две точки в равнината - A и B,зададени със своите декартови координати -xa,ya и xb,yb.
        static void Main(string[] args)
        {
            double Xa, Ya, Xb, Yb;
            Console.WriteLine("Въведете Xa:");
            Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете Ya:");
            Ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете Xb:");
            Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете Yb:");
            Yb = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(Xa + Xb, 2) + Math.Pow(Ya + Yb, 2));
            Console.WriteLine("Разстоянието от точка A и точка B е : " + d);








        }
    }
}
