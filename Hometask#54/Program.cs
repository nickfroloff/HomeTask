// Задача №54

Console.WriteLine("Домашнее задание. Задача №54: Задайте двумерный массив.");
Console.WriteLine("Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("********************************************************************************************");
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
Random rnd = new Random();
Console.WriteLine("Начальный массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rnd.Next(0, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
void SortArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            for (int j = 0; j < columns - k - 1; j++)
            {
                if (array[i, j] > array[i, j + 1])
                {
                    int temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
SortArray(array);
Console.WriteLine("Итоговый массив: ");
PrintArray(array);
