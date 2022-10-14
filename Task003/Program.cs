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
Console.Write("Введите размер массива -  ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
GenerateArrayElements(array, 100, 1000);
PrintArray(array);
int x = 0;
int y = 0;
int i = 0;
while(i < array.Length)
{
    if(array[i] % 2 == 0) x+= 1;
    
    else
    {
        y+= 1;
    }
    i++;
}
Console.WriteLine($"Количество четных чисел - {x}");
Console.WriteLine($"Количество нечетных чисел - {y}");