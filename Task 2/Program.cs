// Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N
// 4->24
// 5->120
int f(int a)
{
  int res = 1;
  for (int i = 2; i <= a; i++)
    res *= i;
  return res;
}
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));