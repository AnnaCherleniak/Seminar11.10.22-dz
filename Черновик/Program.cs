// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
void GenerateArrayElements(int[]array, int min, int max)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}");
    Console.WriteLine();
}
int DiffMaxMinArray(int[]array)
{
    int min = array[0];
    int max = array[0];
    int x = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if(array[i] > max)
        {
            max = array[i];
        }
    }
    x = max - min;
    return x;
}
Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]array = new int[length];
GenerateArrayElements(array, 0, 10);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DiffMaxMinArray(array)}");
