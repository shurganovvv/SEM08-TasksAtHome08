// Задача 58: Задайте две матрицы. Напишите программу, которая 
//     будет находить произведение двух матриц.

int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-5, 8);
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

int[,] MultiMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < firstMartrix.GetLength(1); l++)
                sum += firstMartrix[i, l] * secomdMartrix[l, j];
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

System.Console.Write("Введите количество строк и столбцов Матриц (3 числа) через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = Math.Abs(lazyWrite[0]);
int n = Math.Abs(lazyWrite[1]);
int h = Math.Abs(lazyWrite[2]);

var mnMartrix = GetMatrix(m, n);
PrintMatrix(mnMartrix);
System.Console.WriteLine();

var nhMartrix = GetMatrix(n, h);
PrintMatrix(nhMartrix);
System.Console.WriteLine();

var mhMartrix = new int[m, h];

PrintMatrix(MultiMatrix(mnMartrix, nhMartrix, mhMartrix));
System.Console.WriteLine();