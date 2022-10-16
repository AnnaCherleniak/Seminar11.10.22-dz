// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

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
int SumArray(int[]array)
{
    int sum = 0;
    int x = 0;
    for(int i = 0; i < array.Length; i++)
    {
        x = i % 2;
        if (x > 0)
        {
            sum+=array[i];
        }
    }
    return sum;
    
}
Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
GenerateArrayElements(array, 1, 10);
PrintArray(array);
Console.WriteLine($"Сумма чисел на нечетной позиции: {SumArray(array)}");