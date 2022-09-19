//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество столбцов первого двумерного массива и строк второго одним числом ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк первого двумерного массива   ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго двумерного массива   ");
int q = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int p, int o)
{
    int[,] array = new int[p, o];
    for (int i = 0; i < p; i++)
    {
        for (int j = 0; j < o; j++)
            array[i, j] = new Random().Next(0, 10);


    }
    return array;
}

int[,] mas = FillArray(n, m);
int[,] mas2 = FillArray(m, q);
int[,] proiz(int[,] arr, int[,] arr2)
{

    int[,] arr3 = new int[arr.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            arr3[i, j] = 0;

            for (int g = 0; g < arr.GetLength(1); g++)
            {
                arr3[i, j] += arr[i, g] * arr2[g, j];
            }
        }
    }
    return arr3;
}
PrintArray(mas);
Console.WriteLine("");
PrintArray(mas2);
Console.WriteLine("");
Console.WriteLine("");
PrintArray(proiz(mas,mas2));