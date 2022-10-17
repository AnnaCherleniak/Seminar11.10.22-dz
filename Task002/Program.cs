
// Задать массив из 12 элементов, заполнить числами  из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива.

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
int SumPositiveElements(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum = sum + array[i];
    }
    return sum;
}
int SumNegativeElements(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum = sum + array[i];
    }
    return sum;
}
int length = 12;
int[] array = new int[length];
GenerateArrayElements(array, 0, 10);
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine($"Сумма положительных элементов массива: {SumPositiveElements(array)}");
Console.WriteLine($"Сумма отрицательных элементов массива: {SumNegativeElements(array)}");