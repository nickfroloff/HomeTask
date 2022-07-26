// Задача №62
Console.WriteLine();
Console.WriteLine("Домашнее задание.Задача №62: Заполните спирально массив 4 на 4.");
Console.WriteLine("****************************************************************");
Console.WriteLine();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int [,] array, int rows, int columns)
{
    int number = 1;
    for (int i = 0; i < columns; i++)
    {
        array[0,i] = number;
        number++;
    }
    for (int j = 1; j < rows; j++)
    {
        array[j,rows-1] = number;
        number++;
    }
    for (int i = columns-1-1; i >= 0; i--)
    {
        array[columns-1,i] = number;
        number++;
    }
    for (int j = rows-1-1; j > 0; j--)
    {
        array[j,0] = number;
        number++;
    }
    for (int i = 1; i < columns-1-1; i++)
    {
        array[1,i] = number;
        number++;
    }
    for (int j = 1; j < rows-1-1; j++)
    {
        array[j,rows-1-1] = number;
        number++;
    }
    for (int i = columns-1-1; i >= 1; i--)
    {
        array[columns-1-1,i] = number;
        number++;
    }
}
int rows = 4;
int columns = 4;
int[,] array = new int[rows,columns];
FillArray(array,rows,columns);
PrintArray(array);
Console.WriteLine();