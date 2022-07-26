// Задача №50

Console.WriteLine("Домашнее задание. Задача №50:  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");

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
        array[i,j] = rnd.Next(-100,100);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Номер строки искомого элемента: ");
int m1=Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца искомого элемента: ");
int n1=Convert.ToInt32(Console.ReadLine());
if (m1<=m && n1<n) 
{
    Console.WriteLine("Искомый элемент: " + array[m1-1,n1-1]);
}
else
{
    Console.WriteLine("Искомый элемент отсутствует в массиве.");
}
