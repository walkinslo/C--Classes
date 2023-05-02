using System;
namespace OOP
{
	public class FurnitureItem
	{
		public string Name { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }

		public FurnitureItem(string name, string material, double price)
		{
			Name = name;
			Material = material;
			Price = price;
		}
	}
}

