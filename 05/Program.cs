/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:*/
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
int[,] FillArray()
{
    int per3 = 0;
    int x = 3;
    int y = 3;
    int a =0;
    bool per1 = false;
    bool per2 = false;
    int[,] arr = new int[4, 4];
    int i = 0;
    int j = 0;
    int b =0;
    while (x > 0 && y > 0)
    {
        if (per1 == false && per2 == false)
        {a=0;
            while (a < x)
            {
                arr[j, i] = per3;
                per3++;
                i++;
                a++;
            }


            per2 = true;
        }

        if (per1 == false && per2 == true)
        {a=0;
            while (a < y)
            {
                arr[j, i] = per3;
                per3++;
                j++;
                a++;
            }

            per1 = true;
        }

        if (per1 == true && per2 == true)
        {
            while (i > b)
            {
                arr[j, i] = per3;
                per3++;
                i--;

            }
            per2 = false;
        }

        if (per1 == true && per2 == false)
        {
            while (j > b)
            {
                arr[j, i] = per3;
                per3++;
                j--;
            }
            per1 = false;
        }
        j++;
        i++;
        b++;
        x = x - 2;
        y = y - 2;

    }
    Console.WriteLine($"{x}  {y}");
    return arr;
}
PrintArray(FillArray());