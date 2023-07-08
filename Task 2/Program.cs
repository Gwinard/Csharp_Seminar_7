// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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


int ReadIntPos(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Search(int pos1, int pos2, int[,] matrix)
{
    if (pos1 < 0 | pos1 > matrix.GetLength(0) - 1 | pos2 < 0 | pos2 > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
    {
        Console.WriteLine($"Значение искомого элемента массива: {matrix[pos1, pos2]}");
    }
}
//-----------------------------------------------------------------------

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] matrix = FillMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);

int rowNum = ReadIntPos("Введите номер строки: ");
int colNum = ReadIntPos("Введите номер столбца: ");

Search(rowNum, colNum, matrix);