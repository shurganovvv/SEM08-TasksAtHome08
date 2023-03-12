// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//     будет находить строку с наименьшей суммой элементов.

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

int FindMinSumRowMatrix(int[,] matrix)
{
    int minRow = 1;
    int minSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        minSum += matrix[0, j];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumCurrentRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumCurrentRow += matrix[i, j];
        if (minSum > sumCurrentRow)
        {
            minSum = sumCurrentRow;
            minRow = i + 1;
        }
    }
    return minRow;
}

Meta:
System.Console.Write("Введите количество строк и столбцов Матрицы через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = Math.Abs(lazyWrite[0]);
int n = Math.Abs(lazyWrite[1]);

if (m == n || m == 1 || n == 1)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Пусть массив будет двумерный и прямоугольный.");
    goto Meta;
}

var theMatrix = GetMatrix(m, n);
PrintMatrix(theMatrix); System.Console.WriteLine();
System.Console.WriteLine($"Строка с № {FindMinSumRowMatrix(theMatrix)} имеет наименьшую сумму элементов");