/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
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
            array[i, j] = new Random().Next(0, 10);


    }
    return array;
}

int[,] mas = FillArray(m, n);

int poisk(int[,] arr)
{
    int mins = 0;
    int strok = 0;
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + arr[i, j];

        }
        if (mins == 0) mins = sum;
        else
        {
            if (sum <= mins)
            {
                mins = sum;
                strok = i;
            }
        }
    }
    return strok;

}

PrintArray(mas);
Console.WriteLine("");
Console.WriteLine(poisk(mas));