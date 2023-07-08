// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];

    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}


void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void AverageInColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.WriteLine($"Cреднее арифметическое чисел в столбце {j}: {sum/matr.GetLength(0)}");
    }
}

//-----------------------------------------------------------------------

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] matrix = FillMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);

AverageInColumn(matrix);