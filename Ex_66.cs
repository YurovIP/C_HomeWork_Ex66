// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalsBetweenMN(int m, int n)
{
    int sum = m;
    if (m == n) return sum;
    return sum + SumNaturalsBetweenMN(m + 1, n);
}

System.Console.WriteLine("Значение M= ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Значение N= ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("M = " + m + "; N = " + n + " -> " + SumNaturalsBetweenMN(m, n));