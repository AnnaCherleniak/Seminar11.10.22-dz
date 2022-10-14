// Задать массив из 8 элементов, заполнить нулями и единицами, вывести их на экран.
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
int length = 8;
int[] array = new int[length];
GenerateArrayElements(array, 0, 2);
Console.WriteLine("Ваш массив: ");
PrintArray(array);

