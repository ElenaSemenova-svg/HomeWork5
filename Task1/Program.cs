// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] InitArray()
{
    int[] arr = new int[50];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

int CheackEvenInterger(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2 == 0) 
            {
                n = n + 1;
            }
        }
    return n;
}

int[] arr = InitArray();
PrintArray(arr);
int evenInt = CheackEvenInterger(arr);
Console.WriteLine($"Количество четных чисел в массиве {evenInt}");
