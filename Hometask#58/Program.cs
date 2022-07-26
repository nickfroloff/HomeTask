// Задача №58
Console.WriteLine();
Console.WriteLine("Домашнее задание. Задача №58: Задайте две матрицы. ");
Console.WriteLine("Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("*********************************************************************");
Console.WriteLine();
void FillArray(int[,] array, int rows, int columns)
{
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void MultArray(int[,] fArray, int[,] sArray)
{
    for (int i = 0; i < fArray.GetLength(0); i++)
    {
        for (int j = 0; j < fArray.GetLength(1); j++)
        {
            Console.Write(fArray[i, j] * sArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = new int[rows, columns];
Console.WriteLine();
Console.WriteLine("Первый массив: ");
FillArray(firstArray, rows, columns);
Console.WriteLine();
int[,] secondArray = new int[rows, columns];
Console.WriteLine("Второй массив: ");
FillArray(secondArray, rows, columns);
Console.WriteLine();
Console.WriteLine("Произведение двух этих массивов будет равно следующему массиву: ");
MultArray(firstArray, secondArray);