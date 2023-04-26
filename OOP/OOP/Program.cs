using System;
using Sharprompt;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Магазин стульев", new List<Chair>());

            string name = Prompt.Input<string>("Название стула: ");
            string material;
            int height;
            double price;
            bool isAvaliable;


            shop.addChair
            (
                new Chair
                (
                    "Стул №1",
                    "Дерево",
                    80,
                    1599.99,
                    true
                )
            );
            System.Threading.Thread.Sleep(1000);
            shop.addChair
            (
                new Chair
                (
                    "Стул №2",
                    "Пластик",
                    80,
                    599.99,
                    false
                )
            );
            System.Threading.Thread.Sleep(1000);
            shop.addChair
            (
                new Chair
                (
                    "Стул №3",
                    "Металл",
                    50,
                    1299.99,
                    true
                )
            );

            shop.printChairs();

            shop.updateChair
            (
                    1,
                    "Стул №2 (обновленный)",
                    "Пластик",
                    80,
                    599.99,
                    true
            );
            System.Threading.Thread.Sleep(1000);

            shop.RemoveChair(2);

            System.Threading.Thread.Sleep(500);
            shop.printChairs();
        }

    }

}