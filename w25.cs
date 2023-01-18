// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();

Console.Write("Введите число возводимое в степень: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
double b = Convert.ToInt32(Console.ReadLine());
double s=a;
//double s=Math.Pow(a,b); так можно, но это не цикл, а программа? for цикл?
for (int i=1; i<b; i++)
{
    s=s*a;
}
Console.Write(a + "^" + b + "=" + s);