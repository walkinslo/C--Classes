using System;
using System.IO;

namespace Array_Debugging
{
    internal class Program
    {
        static int[] Array = new int [1000];
        static readonly string pathToFile = @"./PR-5.txt";

        static void Main()
        {
            PopulateArray();
            CreateFile();
            WriteEverything(pathToFile);
        }

        static void CreateFile()
        {
            if (File.Exists(pathToFile))
            {
                Console.WriteLine("File exists.\n");
            }
            else
            {
                var myFile = File.Create(pathToFile);
                Console.WriteLine("File was created.\n");
                myFile.Close();
            }
        }

        static void WriteEverything(string pathToFile)
        {
            using StreamWriter streamWriter = new StreamWriter(pathToFile);

            int ElementIndex;
            int ArrayElement;
            int SumElementNumbers;

            if (Array != null)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    ElementIndex = i;
                    ArrayElement = Array[i];
                    SumElementNumbers = SumAllNumbers(Array[i]);

                    string dataToWrite = $"{ElementIndex} | {ArrayElement} | {SumElementNumbers}";

                    streamWriter.WriteLine(dataToWrite);
                }
            }
            else
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine("Array is NULL.\n");
            }
        }

        static void PopulateArray()
        {
            int RandomInt;
            Random Random = new Random();

            if (Array != null)
            {
                for (int i = 1; i < Array.Length; i++)
                {
                    RandomInt = Random.Next(-10000, 10000);
                    Array[i] = RandomInt;
                }
            }
            else
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine("Array is NULL.\n");
            }
        }
        static int SumAllNumbers(int Number)
        {
            if (Number == 0)
            {
                return -1;
            }

            int Sum = 0;
            while (Number != 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }

            return Sum;
        }
    }
}