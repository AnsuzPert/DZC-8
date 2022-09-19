/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.*/
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

Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(0, 100);


    }
    return array;
}

int[,] mas = FillArray(m, n);

int[,] sort(int[,] arr)
{

    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n - 1; j++)
        {
            for (int g = j + 1; g < n; g++)
            {
                if (arr[i, j] < arr[i, g])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, g];
                    arr[i, g] = temp;
                }
            }
        }

    }
    return arr;
}
PrintArray(mas);
sort(mas);
Console.WriteLine("");
PrintArray(sort(mas));