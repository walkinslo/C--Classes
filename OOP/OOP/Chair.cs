using System;
namespace OOP
{
	public class Chair : FurnitureItem
	{
        public int Height { get; set; }
        public bool IsAvaliable { get; set; }
        
        public Chair(
            string name,
            string material,
            int height,
            double price,
            bool isAvaliable
            ) : base(name, material, price)
        {
            Height = height;
            IsAvaliable = isAvaliable;
        }

        public override string ToString()
        {
            return $"\n[Название]: {Name},\n" +
                $"[Цена]: {Price},\n" +
                $"[Материал]: {Material},\n" +
                $"[Высота]: {Height},\n" +
                $"[Наличие]: {(IsAvaliable ? "В наличии":" Нет в наличии")}";
        }
    }
}

