// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetBinarnyArray(int size)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i ++)
    {
        result[i] =new Random().Next(100, 1000);

    }
    return result;
}
Console.WriteLine("Введите количество элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GetBinarnyArray(n);
Console.WriteLine($"[ {String.Join (",", array )} ]");
int count = 0;
 for(int s = 0; s < n; s++)
{
    if(array[s] % 2 == 0)
    {
        count++;
    }
    //  Console.WriteLine($"Количество четных чисел в массиве = {count}");
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");


