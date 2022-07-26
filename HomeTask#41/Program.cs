// Задача №41

Console.WriteLine("Домашнее задание. Задача №41: Пользователь вводит с клавиатуры массив чисел. ");
Console.WriteLine("Посчитайте, сколько чисел больше нуля ввёл пользователь.");

int FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int numbers = 0;
    while (index < length)
    {
        Console.Write("Введите число в составе массива: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        if (collection[index] > 0)
        {
            numbers++;
        }
        index++;
    }
    return numbers;
}
Console.WriteLine("Количество чисел в массиве: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[digit];
int numbers = FillArray(array);
Console.WriteLine("В данном массиве " + numbers + " положительных чисел.");
