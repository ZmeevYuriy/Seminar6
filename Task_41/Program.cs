// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

void PrintArray(int[] array)
{
    Console.Write(" ");
    int lenght = array.Length;
    int i1 = 0;
    while (i1 < (lenght - 1))
    {
        Console.Write(array[i1] + ",");
        i1++;
    }
    Console.Write(array[lenght - 1] + " ");
}
Console.WriteLine("Исходный массив:");

PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: {count}");



