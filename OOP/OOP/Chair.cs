using System;
namespace OOP
{
	public class Chair
	{
        public string Name { get; set; }
        public string Material { get; set; }
        public int Height { get; set; }
        public double Price { get; set; }
        public bool IsAvaliable { get; set; }
        
        public Chair(
            string name,
            string material,
            int height,
            double price,
            bool isAvaliable
            )
        {
            Name = name;
            Material = material;
            Height = height;
            Price = price;
            IsAvaliable = isAvaliable;
        }

        public override string ToString()
        {
            return $"Название: {Name}, Цена: {Price}, Материал: {Material}, Высота: {Height}, Наличие: {(IsAvaliable ? "В наличии":" Нет в наличии")}";
        }
    }
}

