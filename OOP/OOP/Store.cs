using System;
using Sharprompt;

namespace OOP
{
    class Shop : FurnitureItem
    {
        public List<Chair> Chairs { get; set; }

        public Shop(string name, List<Chair> chairs) : base(name, "", 0)
        {
            Name = name;
            Chairs = chairs;
        }

        public void addChair(Chair chair)
        {
            Chairs.Add(chair);
            Console.WriteLine($"\nСтул {chair}  успешно добавлен.");
        }

        public void removeChair(int index)
        {
            if (index < 0 || index >= Chairs.Count)
            {
                Console.WriteLine("Такого стула нет в списке");
            }

            Chair removedChair = Chairs[index];

            Chairs.RemoveAt(index);
            Console.WriteLine($"Стул \"{removedChair}\" успешно удален.");
        }

        public void updateChair()
        {

            int index = Prompt.Input<int>("Введите индекс стула");
            string name = Prompt.Input<string>("Название стула");
            string material = Prompt.Input<string>("Из чего он сделан");
            int height = Prompt.Input<int>("Высота стула (в см)");
            double price = Prompt.Input<double>("Цена (в рублях)");
            bool isAvaliable = Program._IsAvaliable();

            Chairs[index].Name = name;
            Chairs[index].Material = material;
            Chairs[index].Height = height;
            Chairs[index].Price = price;
            Chairs[index].IsAvaliable = isAvaliable;

            Console.WriteLine($"\nДанные о стуле \"{Chairs[index]}\" успешно обновлены");

        }

        public void printChairs()
        {
            Console.WriteLine($"Стулья в магазине \"{Name}\":");

            for (int i = 0; i < Chairs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Chairs[i].ToString()}");
            }
        }
    }
}
