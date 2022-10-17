// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
void MultiplicationNumber(int[]array)
{
    int x = 0;
    int min = 0;
    int max = array.Length - 1;
    int n = 1;
    while(min < max)
    {
        x = array[min] * array[max];
        Console.WriteLine($"Произведение {n} пары чисел: {x}");
        min++;
        max--;
        n++;
    }
}
Console.Write("Введите длину массива- ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]array = new int[length];
GenerateArrayElements(array, 1, 10);
PrintArray(array);
MultiplicationNumber(array);