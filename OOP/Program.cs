using System;
using Sharprompt;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Магазин стульев", new List<Chair>());
            bool Done = false;

            while (!Done) {

                Menu();

                string userInput = Console.ReadLine();
                int parsedValue;

                if (!Int32.TryParse(userInput, out parsedValue)) {
                    Console.WriteLine("Такого пункта нет.");
                } else {
                    switch (parsedValue)
                    {
                        case 1:
                            shop.addChair(Add());
                            break;
                        case 2:
                            shop.removeChair(Remove());
                            break;
                        case 3:
                            shop.updateChair();
                            break;
                        case 4:
                            shop.printChairs();
                            break;
                        case 5:
                            Done = true;
                            break;
                        default:
                            break;
                    }
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

            return (int)index;
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
