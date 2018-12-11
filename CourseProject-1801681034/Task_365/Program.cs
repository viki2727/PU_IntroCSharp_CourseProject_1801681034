using System;

namespace _365
{
    class Program
    {
        //Съставете метод,който при зададен ЕГН връща датата на раждане на притежателя на ЕГН по следния начин:
        //а)Дата на раждане 16.04.1875г.
        //б)Дата на раждане 16-ти април 1875г.
        //в)Дата на раждане шестнадесети април 1875г.
        //г)Мъжът е роден на 16.04.1875г.

        static void Main(string[] args)
        {
            {
                int brd = 0, male;
                Console.WriteLine("Въведете ЕГН: "); string egn = Console.ReadLine();
                egn = egn.Trim();
                if (egn.Length != 10)
                {
                    Console.WriteLine("Некоректна дължина! ");
                    Console.ReadKey(true); Environment.Exit(0);
                }

                int[] r = new int[10];
                for (int i = 0; i < 10; i++) r[i] = egn[i] - '0';
                int god = r[0] * 10 + r[1];
                int mes = r[2] * 10 + r[3];
                int mesec = r[2] * 10 + r[3];
                int den = r[4] * 10 + r[5];
                int dni = r[4] * 10 + r[5];
                if (mes > 0 && mes < 13) god = 1900 + god;
                else if (mes > 20 && mes < 33) { god = 1800 + god; mes = mes - 20; }
                else if (mes > 40 && mes < 53) { god = 2000 + god; mes = mes - 40; }
                else
                {
                    Console.WriteLine("Некоректно въведен месец! ");
                    Console.ReadKey(true); Environment.Exit(0);
                }

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: brd = 31; break;
                    case 2:
                        if (god % 400 == 0 || god % 4 == 0 && god % 100 != 0)
                            brd = 29;
                        else brd = 28; break;
                    case 4: case 6: case 9: case 11: brd = 30; break;
                }

                if (den < 1 || den > brd)
                {
                    Console.WriteLine("Некоректно въведен ден! ");
                    Console.ReadKey(true); Environment.Exit(0);
                }

                {
                    Console.WriteLine("a) Дата на раждане " + den + "." + mes + "." + god + "г.");
                }

                switch (mesec)
                {
                    case 1: Console.WriteLine("януари"); break;
                    case 3: Console.WriteLine("март"); break;
                    case 5: Console.WriteLine("май"); break;
                    case 7: Console.WriteLine("юли"); break;
                    case 8: Console.WriteLine("август"); break;
                    case 10: Console.WriteLine("октомври"); break;
                    case 12: Console.WriteLine("декември"); break;
                    case 2: Console.WriteLine("февруари"); break;
                    case 4: Console.WriteLine("април"); break;
                    case 6: Console.WriteLine("юни"); break;
                    case 9: Console.WriteLine("септември"); break;
                    case 11: Console.WriteLine("ноември"); break;
                }
                {
                    Console.WriteLine("б) Дата на раждане " + den + "-ти" + " " + mesec + " " + god + "г.");
                }
                switch (dni)
                {
                    case 1: Console.WriteLine("първи"); break;
                    case 2: Console.WriteLine("втори"); break;
                    case 3: Console.WriteLine("трети"); break;
                    case 4: Console.WriteLine("четвърти"); break;
                    case 5: Console.WriteLine("пети"); break;
                    case 6: Console.WriteLine("шести"); break;
                    case 7: Console.WriteLine("седми"); break;
                    case 8: Console.WriteLine("осми"); break;
                    case 9: Console.WriteLine("девети"); break;
                    case 10: Console.WriteLine("десети"); break;
                    case 11: Console.WriteLine("единадесети"); break;
                    case 12: Console.WriteLine("дванадесети"); break;
                    case 13: Console.WriteLine("тринадесети"); break;
                    case 14: Console.WriteLine("четиринадесети"); break;
                    case 15: Console.WriteLine("педнадесети"); break;
                    case 16: Console.WriteLine("шестнадесети"); break;
                    case 17: Console.WriteLine("седемнадесети"); break;
                    case 18: Console.WriteLine("осемнадесети"); break;
                    case 19: Console.WriteLine("деветнадесети"); break;
                    case 20: Console.WriteLine("двайсти"); break;
                    case 21: Console.WriteLine("двадесет и първи"); break;
                    case 22: Console.WriteLine("двадесет и втори"); break;
                    case 23: Console.WriteLine("двадесет и трети"); break;
                    case 24: Console.WriteLine("двадесет и четвърти"); break;
                    case 25: Console.WriteLine("двадесет и първи"); break;
                    case 26: Console.WriteLine("двадесет и шести"); break;
                    case 27: Console.WriteLine("двадесет и седми"); break;
                    case 28: Console.WriteLine("двадесет и осми"); break;
                    case 29: Console.WriteLine("двадесет и девети"); break;
                    case 30: Console.WriteLine("трийсти"); break;
                    case 31: Console.WriteLine("тридесет и първи"); break;
                }
                {
                    Console.WriteLine("в) Дата на раждане " + dni + " " + " " + mesec + " " + god + "г.");
                }

                if (r[8] % 2 == 0) male = 1; else male = 0;
                int k = r[0] * 2 + r[1] * 4 + r[2] * 8 + r[3] * 5 + r[4] * 10 + r[5] * 9 + r[6] * 7 + r[7] * 3 + r[8] * 6;
                k = k % 11;
                if (k == 10) k = 0;
                if (k != r[9])

                    if (male == 1)
                    {
                        Console.WriteLine("г) Мъжът е роден на " + den + "." + mes + "." + god + "г.");
                    }
                    else
                    {
                        Console.WriteLine("г) Жената е родена на " + den + "." + mes + "." + god + "г.");
                    }

            }
        }
    }

}


