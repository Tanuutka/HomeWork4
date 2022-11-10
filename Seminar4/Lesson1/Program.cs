//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine ($"Сумма чисел равна = {SumNumber(num)}");


int SumNumber(int number)
{
    int count=0;
    while (Math.Abs(number)>0)
    {
        count = count + Math.Abs(number)%10;
        number/=10;
    }
    return count;
}