// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

void GenerateArrayElements(int[]array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(1,10);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}");
    Console.WriteLine();
}
int length = 123;
int[] array = new int[length];
Console.WriteLine("Ваш массив - ");
GenerateArrayElements(array);
PrintArray(array);
Console.WriteLine();
//ДОДЕЛАТЬ!!!!