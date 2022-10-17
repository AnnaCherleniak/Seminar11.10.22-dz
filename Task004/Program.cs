// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

void GenerateArrayElements(int[]array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(10,1000);
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int length = 123;
int[] array = new int[length];
Console.WriteLine("Ваш массив - ");
GenerateArrayElements(array);
PrintArray(array);
Console.WriteLine();
int n = 0;
int i = 10;
int x = 0;
int y = 0;
while(i < 100)
{
    n = array[i];
    while(n > 0)
    {
        x++;
        n = n / 10;
    }
    y = y + x;
    i++;
}
Console.WriteLine("Количество элементов из отрезка [10,99] - " + x);
///!!!!ДОДЕЛАТЬ!!!