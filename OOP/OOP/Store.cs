using System;
namespace OOP
{
    class Shop
    {
        public string Name { get; set; }
        public List<Chair> Chairs { get; set; }

        public Shop(string name, List<Chair> chairs)
        {
            Name = name;
            Chairs = chairs;
        }

        public void addChair(Chair chair)
        {
            Chairs.Add(chair);
            Console.WriteLine($"Стул \"{chair}\" успешно добавлен   .");
        }

        public void RemoveChair(int index)
        {
            if (index < 0 || index >= Chairs.Count)
            {
                Console.WriteLine("Такого стула нет в списке");
            }

            Chair removedChair = Chairs[index];

            Chairs.RemoveAt(index);
            Console.WriteLine($"Стул \"{removedChair}\" успешно удален.");
        }

        public void updateChair(
            int index,
            string name,
            string material,
            int height,
            double price,
            bool isAvaliable
            )
        {
            Chair updatedChair = Chairs[index];
            updatedChair.Name = name;
            updatedChair.Material = material;
            updatedChair.Height = height;
            updatedChair.Price = price;
            updatedChair.IsAvaliable = isAvaliable;

            Console.WriteLine($"Данные о стуле \"{Name}\" успешно обновлены");

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
