using System;
using System.IO;
using ClassLibrary_kt_klass_kat;

namespace FirsovTimofey_CatApplication 
{ 
    internal class Program
    {
        static Cat[] GenerateRandomCats(uint count)
        {
            Cat[] cats = new Cat[count];
            Random random = new Random();

            for (int i = 0; i < cats.Length; i++)
            {
                bool created = false;

                while (!created)
                {
                    try
                    {
                        int catType = random.Next(0, 2);

                        int fluffiness = random.Next(-20, 121);

                        if (catType == 0)
                        {
                            double weight = random.Next(50, 161);

                            cats[i] = new Tiger(weight, fluffiness);
                        }
                        else
                        {
                            cats[i] = new CuteCat(fluffiness);
                        }

                        created = true;
                    }
                    catch (CatException ex)
                    {
                        Console.WriteLine(
                            $"Возникло исключение: {ex.Message}");
                    }
                }
            }

            return cats;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (Cat cat in catsArr)
                {
                    string info =
                        $"{cat.FluffinessCheck()} | {cat}";

                    Console.WriteLine(info);
                    writer.WriteLine(info);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество котов: ");
            uint catCount = uint.Parse(Console.ReadLine());

            Cat[] cats = GenerateRandomCats(catCount);

            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            DisplayCatInfo(cats, path);

            Console.WriteLine("Готово.");
        }
    }
}