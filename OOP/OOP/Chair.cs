using System;
namespace OOP
{
	public class Chair
	{
        public string Color { get; set; }
        public string Material { get; set; }
        public int Height { get; set; }
        
        public void UpdateColor(string newColor)
        {
            this.Color = newColor;
        }

        public void UpdateHeight(int newHeight)
        {
            this.Height = newHeight;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Material: {this.Material}");
            Console.WriteLine($"Height: {this.Height}");
        }
    }
}

