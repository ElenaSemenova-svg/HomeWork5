// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] InitArray()
{
    int[] arr = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

int SumOddIElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
        {
            sum = sum + array[i];
        }
    return sum;
}

int[] arr = InitArray();
PrintArray(arr);
int sumInt = SumOddIElement(arr);
Console.WriteLine($"Сумма нечетных элементов массиве {sumInt}");

