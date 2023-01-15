// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] GetArrayRandom(int length)  // первая функция - выдача рандомных чисел
{
    int[] arr = new int[length];
    for (int i=0; i < length; i++)
    {
        arr[i] = new Random().Next(1,50);
    }
    return arr;
}

int[] array = GetArrayRandom(8);

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(GetArrayRandom(8));
