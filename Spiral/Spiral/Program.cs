using System;

class Program
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int S = 0;

        // Вычисляем сумму элементов первой строки
        for (int j = 0; j < n; j++)
        {
            S += matrix[0, j];
        }

        // Проверяем строки
        for (int i = 1; i < n; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            if (rowSum != S)
            {
                return false;
            }
        }

        // Проверяем столбцы
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < n; i++)
            {
                colSum += matrix[i, j];
            }
            if (colSum != S)
            {
                return false;
            }
        }

        // Проверяем главную диагональ
        int diagSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum += matrix[i, i];
        }
        if (diagSum != S)
        {
            return false;
        }

        // Проверяем побочную диагональ
        int antiDiagSum = 0;
        for (int i = 0; i < n; i++)
        {
            antiDiagSum += matrix[i, n - i - 1];
        }
        if (antiDiagSum != S)
        {
            return false;
        }

        // Если все проверки прошли успешно, то матрица является магическим квадратом
        return true;
    }

    static void Main(string[] args)
    {
        int[,] matrix = {
            {16, 23, 17},
            {78, 32, 21},
            {17, 16, 15}
        };

        if (IsMagicSquare(matrix))
        {
            Console.WriteLine("Матрица является магическим квадратом");
        }
        else
        {
            Console.WriteLine("Матрица не является магическим квадратом");
        }
    }
}
