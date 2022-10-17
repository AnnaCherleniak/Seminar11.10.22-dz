// Задать массив, заполнить случайными положительными трехзначными числами. 
//Показать количеств четных/нечетных чисел.

void GenerateArrayElements(int[]array, int min, int max)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int CountEvenNumber(int[]array)
{
    int x = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) x++;
    }
    return x;
}
int CountOddNumber(int[]array)
{
    int x = 0;
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        n = array[i] % 2;
        if(n > 0) x++;
    }
    return x;
}
Console.Write("Введите размер массива -  ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
GenerateArrayElements(array, 100, 1000);
PrintArray(array);
Console.WriteLine($"Количество четных чисел - {CountEvenNumber(array)}");
Console.WriteLine($"Количество нечетных чисел - {CountOddNumber(array)}");