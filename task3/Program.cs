// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите количество элементов в вашем массиве ");
int N = int.Parse(Console.ReadLine());
double[] array = new double[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101) + new Random().NextDouble();
}
Console.WriteLine($"Ваш массив [{string.Join(", ", array)}]");
double max = array[0];
double min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
     if(array[i] < min) min = array[i];
}
Console.Write($"Минимальное значение =  {min}");
Console.WriteLine(" ");
Console.Write($"Максимальное значение =  {max}");
double result = max - min;
Console.WriteLine(" ");
Console.Write($"Разница между максимальным и минимальным =  {result}");