using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();
        string output = FormatText(input);
        Console.WriteLine("Отформатированный текст: ");
        Console.WriteLine(output);
    }

    static string FormatText(string text)
    {
        string[] sentences = text.Split('.');
        string output = "";
        foreach (string sentence in sentences)
        {
            // Это без пробелов
            string trimmed = sentence.Trim();

            if (trimmed.Length > 0)
            {
                // Тут мы делаем первую букву заглавной
                char[] charArray = trimmed.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                string capitalized = new string(charArray);

                // Добавляем пробелы после точек
                output += capitalized + ". ";

                if (sentence.Length > trimmed.Length)
                {
                    output += sentence.Substring(trimmed.Length, sentence.Length - trimmed.Length);
                }
            }
        }
        return output;
    }
}
