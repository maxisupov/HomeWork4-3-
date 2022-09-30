// Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

int[] ar = FillArray();
PrintArray(ar);

int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}    