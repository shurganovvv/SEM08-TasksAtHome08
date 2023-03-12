// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//     упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-20, 21);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

int[,] SortMatrixRowsDoun(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(1) - j - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l];
                    matrix[i, l] = matrix[i, l + 1];
                    matrix[i, l + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

var theMatrix = GetMatrix(new Random().Next(3, 5), new Random().Next(3, 7));
PrintMatrix(theMatrix);
System.Console.WriteLine();

PrintMatrix(SortMatrixRowsDoun(theMatrix));
System.Console.WriteLine();