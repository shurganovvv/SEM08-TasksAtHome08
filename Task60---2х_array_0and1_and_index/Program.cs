// Задача 60: Сформируйте трёхмерный массив из двузначных чисел. 
//     Напишите программу, которая будет построчно выводить массив, 
//         добавляя индексы каждого элемента.

void Get3Dmassa(int[,,] XXX)
{
    int[] temp = new int[XXX.GetLength(0) * XXX.GetLength(1) * XXX.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < XXX.GetLength(0); x++)
    {
        for (int y = 0; y < XXX.GetLength(1); y++)
        {
            for (int z = 0; z < XXX.GetLength(2); z++)
            {
                XXX[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void Print3Dmassa(int[,,] XXX)
{
    for (int i = 0; i < XXX.GetLength(0); i++)
    {
        for (int j = 0; j < XXX.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int l = 0; l < XXX.GetLength(2); l++)
                Console.Write($"Z({l})={XXX[i, j, l]}; ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

System.Console.Write("Введите размеры массива (3 числа) через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = Math.Abs(lazyWrite[0]);
int n = Math.Abs(lazyWrite[1]);
int h = Math.Abs(lazyWrite[2]);
var mass3D = new int[m, n, h];
Get3Dmassa(mass3D);
Print3Dmassa(mass3D);
System.Console.WriteLine();