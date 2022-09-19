/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
int[] slov = new int[90];
for (int i = 0; i < 89; i++) slov[i] =i;

Console.WriteLine("ВВедите количество строк трехмерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите количество столбцов трехмерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите объем трехмерного массива");
int o = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int g = 0; g < table.GetLength(2); g++)
            {
                Console.Write($"{table[i, j, g]}({i},{j},{g})  ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] FillArray(int m, int n, int o)
{
    int[,,] array = new int[m, n, o];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < o; g++)
            {
                int per = 0;
                bool pro = false;
                while (pro == false)
                {
                    per = slov[new Random().Next(0, 89)];
                    if (per != 0)
                    {
                        array[i, j, g] = per;
                        slov[per] = 0;
                        pro = true;
                    }
                }
            }
        }


    }
    return array;
}
int [,,] mas = FillArray(m,n,o);
PrintArray(mas);