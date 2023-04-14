// Ввести текст. Определить, является ли он текстом на русском языке. 
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        if (CheckText(text))
        {
            Console.WriteLine("Строка написана на русском");
        } else
        {
            Console.WriteLine("Строка не содержит русские буквы");
        }
    }

    static bool CheckText(string text)
    {
        Regex regex = new Regex(@"[\u0400-\u04FF]+");
        return regex.IsMatch(text);
    }
}