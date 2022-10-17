// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
void GenerateArrayElements(double[]array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 10) + random.NextDouble();
}
void PrintArray(double[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"{array[i]}");
    Console.WriteLine();
}
double DiffMaxMinArray(double[]array)
{
    double min = array[0];
    double max = array[0];
    double x = 0;
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
double[]array = new double[length];
GenerateArrayElements(array);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DiffMaxMinArray(array)}");
