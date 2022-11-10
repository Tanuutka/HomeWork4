// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.Clear();

int[] array = EnterArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] EnterArray (int size)
{
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
        result[i]=new Random().Next(0,101);
    }
    return result;
}