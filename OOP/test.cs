using System;
using Sharprompt;

namespace OOP
{
    class Program
    {
        private bool Done = false;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Shop shop = new Shop("Магазин стульев", new List<Chair>());

            while (!Done) {
                DisplayMenu();

                string userInput = Console.ReadLine();
                HandleUserInput(userInput, shop);
            }
        }

        private void HandleUserInput(string userInput, Shop shop)
        {
            int parsedValue;

            if (!Int32.TryParse(userInput, out parsedValue)) {
                Console.WriteLine("Такого пункта нет.");
            } else {
                switch (parsedValue)
                {
                    case 1:
                        shop.addChair(Add(shop));
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

        private Chair Add(Shop shop)
        {
            string name = Prompt.Input<string>("Название стула");
            string material = Prompt.Input<string>("Из чего он сделан");
            int height = Prompt.Input<int>("Высота стула (в см)");
            double price = Prompt.Input<double>("Цена (в рублях)");
            bool isAvaliable = _IsAvaliable();

            return new Chair(name, material, height, price, isAvaliable);
        }

        private int Remove()
        {
            Console.WriteLine("Какой стул вы хотите удалить?\n");
            int index = int.Parse(Console.ReadLine());
            return (int)index;
        }

        public static bool _IsAvaliable()
        {
            bool isAvaliable;

            var temp = Prompt.Select("Доступность: ", new[] { "В наличии", "Не в наличии" });
            isAvaliable = (temp == "В наличии");

            return isAvaliable;
        }

        private void DisplayMenu()
        {
            Console.WriteLine
                ("\n" + "Что вы хотите сделать?\n" +
                "1: Добавить стул\n" +
                "2: Удалить стул\n" +
                "3: Изменить стул\n" +
                "4: Посмотреть все стулья\n" +
                "5: Выйти" + "\n");
        }
    }
}
