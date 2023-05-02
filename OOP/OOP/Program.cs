using System;
using Sharprompt;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Магазин стульев", new List<Chair>());

            while (true) {

                Menu();

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    shop.addChair(Add());
                }
                else if (choice == 2)
                {
                    shop.removeChair(Remove());
                }
                else if (choice == 3)
                {
                    shop.updateChair();
                }
                else if (choice == 4)
                {
                    shop.printChairs();
                }
                else // [5]
                {
                    break;
                }

            }

        }

        static Chair Add()
        {
            string name = Prompt.Input<string>("Название стула");
            string material = Prompt.Input<string>("Из чего он сделан");
            int height = Prompt.Input<int>("Высота стула (в см)");
            double price = Prompt.Input<double>("Цена (в рублях)");
            bool isAvaliable = _IsAvaliable();

            Shop shop = new Shop("Магазин стульев", new List<Chair>());

            return new Chair
                (
                    name,
                    material,
                    height,
                    price,
                    isAvaliable
                );
        }

        static int Remove()
        {
            Console.WriteLine("Какой стул вы хотите удалить?\n");

            int index = int.Parse(Console.ReadLine());

            return index;
        }

        public static bool _IsAvaliable()
        {
            bool isAvaliable;

            var temp = Prompt.Select("Доступность: ", new[] { "В наличии", "Не в наличии" });
            if (temp == "В наличии")
            {
                isAvaliable = true;
            }
            else
            {
                isAvaliable = false;
            }

            return isAvaliable;
        }

        static void Menu()
        {
            Console.WriteLine
                    ("\n" + "Что вы хотите сделать?\n" +
                    "1: Добавить стул\n" +
                    "2: Удалить стул\n" +
                    "3: Изменить стул\n" +
                    "4: Посмотреть все стулья\n" +
                    "5: Выйти" + "\n"
                    );
        }
    }

}