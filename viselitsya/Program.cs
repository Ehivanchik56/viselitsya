using System;

namespace viselitsya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slova = new string[5] { "прогресс", "стол", "банан", "ночь", "утро", };
            Random rnd = new Random();
            int value = rnd.Next(0, slova.Length);

            string slovo = slova[value];

            string[] x = new string[slovo.Length];
            Console.Write("Ваше слово: ");
            for (int i = 0; i < slovo.Length; i++)
            {
                x[i] = "*";
                Console.Write(x[i]);
            }
            int popitki = slovo.Length;
            Console.WriteLine(" , у вас есть " + popitki + " попытки");

            int h = 0;


            Console.WriteLine("Введите букву:");
            for (int e = 0; e < popitki;)
            {

                int v = slovo.Length;

                if (popitki == 0)
                {
                    Console.WriteLine("Вы проиграли");
                    break;
                }
                else if (h == v)
                {
                    Console.WriteLine("Вы выиграли, поздравляем!");
                    break;
                }

                string b = Convert.ToString(slovo[h]);
                string r = Console.ReadLine();

                if (b == r)
                {
                    x[h] = b;
                    Console.Write("Ваше слово: ");
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        Console.Write(x[i]);
                    }
                    Console.WriteLine(" , у вас осталось " + popitki + " попытки");
                    h++;
                }
                else
                {
                    Console.Write("Ваше слово: ");
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        Console.Write(x[i]);
                    }
                    popitki--;
                    Console.WriteLine(" , у вас осталось " + popitki + " попытки");
                }
            }
        }
    }
}