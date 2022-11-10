// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.WriteLine("Введите число A: ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Exponentiation(A,B);

void Exponentiation (double number1, int number2)
{
    double exp = number1;
if (number2<0)
{
    Console.WriteLine ("Введите положительную степень: ");
}
  else
  if (number2==0)
  {
    Console.WriteLine("Число А возведенное в степень В равно: "+ 1);
  }
    else
    {
        
   for (int i = 1; i<number2; i++)
    {
        exp*=number1;
    }
  Console.WriteLine("Число А возведенное в степень В равно: "+ exp);
  }
  
}



