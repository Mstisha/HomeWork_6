Console.WriteLine("Введите числа через пробел: ");
int count = 0;
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        count++;
}
Console.WriteLine($"Кол-во элементов > 0: {count}");