using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumeralSystem

{
    class Program
    {
        //Преобразувайте числото 2034 от десетична в двоична,осмична и шестанайсетична бройна система.
        static void Main(string[] args)
        {
            Console.WriteLine("My number is 2034");
            Console.WriteLine("2034 to binary:{0}.", Convert.ToString(2034, 2));
            Console.WriteLine("2034 to octal:{0}.", Convert.ToString(2034, 8));
            Console.WriteLine("2034 to hexadecimal:{0}.", Convert.ToString(2034, 16));

        }
    }
}
