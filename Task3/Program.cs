// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

float[] InitArray()
{
    float[] arr = new float[6];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

float MinInt(float[] array)
{
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i]) min = array[i];
        }
    return min;
}
float MaxInt(float[] array)
{
    float max = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i]) max = array[i];
        }
    return max;
}


float[] arr = InitArray();
PrintArray(arr);
float min = MinInt(arr);
float max = MaxInt(arr);
Console.WriteLine($"Разность между максимальным {max} и минимальным числом массива {min} =  {max - min}");
