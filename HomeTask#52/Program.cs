// Задача №52

Console.WriteLine("Домашнее задание. Задача №52: Задайте двумерный массив из целых чисел. ");
Console.WriteLine("Найдите среднее арифметическое элементов в каждом столбце.");

Console.Write("Количество строк массива: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Random rnd = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array[i,j] = rnd.Next(-10,10);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
for (int j=0; j<n; j++)
{
double sr=0;
    for (int i=0; i<m; i++)
    {
        sr = sr + array[i,j];
        Console.Write(array[i,j]+" + ");
    }
    Console.WriteLine(" среднее арифметическое в столбце = "+ sr/m);
} 
