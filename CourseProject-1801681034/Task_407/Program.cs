using System;

namespace Task_407
{

    class Program
    {
        /*
       Да се въведе едномерен целочислен масив с дължина (брой елементи) в интервала 2, 30. Да се контролира въвеждането
       на дължината в този интервал. Да се напише метод , който връща средноаретметичното на тези елементи на масива, които принадлежат на интервала 
       и се делят на 5 без остатък. Да се въведе от клавиатурата цяло положително число к. Да се извика методът за въведения
       масив и резултатът от него да се отпечата на екрана.
       */



        static void Main(string[] args)
        {
            int number;
            int k;
            int[] arrOfNums;

            do
            {
                Console.Write("Input a number between 2 and 30: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 2 || number >= 30);

            arrOfNums = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Number {0}: ", i);
                arrOfNums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input k: ");
            k = Convert.ToInt32(Console.ReadLine());

            Sredno(k, arrOfNums);
        }

        public static void Sredno(int k, int[] arrOfNums)
        {
            int counter = 0;
            System.Collections.Generic.List<int> numbersList = new System.Collections.Generic.List<int>();

            double average = 0.0d;

            for (int i = 0; i < arrOfNums.Length; i++)
            {
                if ((arrOfNums[i] >= -k && arrOfNums[i] <= k) && arrOfNums[i] % 5 == 0)
                {
                    numbersList.Add(arrOfNums[i]);
                }
            }

            foreach (int number in numbersList)
            {
                counter++;
                average += number;
            }

            if (counter != 0)
            {
                Console.WriteLine("The average is: " + average / counter);
            }
        }
    }
}
    


