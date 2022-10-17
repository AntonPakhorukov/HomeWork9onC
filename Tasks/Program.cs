/*
Задача 64: Задайте значения N и M. Напишите программу, которая выведет все 
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30

Задача 68: Задайте значения M и N. Напишите программу, 
которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7

Дополнительная задача (70): 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29

Дополнительная задача 2 (72): Напишите программу, которая выводит монотонную последовательность
 из N элементов в виде равностороннего треугольника с помощью рекурсии
N = 5 -> https://ibb.co/9nZgLtY
*/
Console.Clear();
int GetNumbers()
{
    Console.Write("Введите значение: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 64:
        Task64();
        break;
    case 66:
        Task66();
        break;
    case 68:
        Task68();
        break;
    case 70:
        Task70();
        break;
}
void Task64()
{
    /*
    Задача 64: Задайте значения N и M. Напишите программу, которая выведет все 
    чётные натуральные числа в промежутке от M до N с помощью рекурсии.
    M = 1; N = 5 -> 2, 4
    M = 4; N = 8 -> 4, 6, 8
    */
    int m = GetNumbers();
    int n = GetNumbers();
    void PrintEvenNumbers(int m, int n)
    {
        if (m <= n)
        {
            if (m % 2 == 0)
            {
                Console.Write(m + " ");
                m = m + 2;
            }
            else
            {
                m++;
            }
        }
        else
        {
            return;
        }
        PrintEvenNumbers(m, n);
    }
    PrintEvenNumbers(m, n);
}
void Task66()
{
    /*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
    натуральных элементов в промежутке от M до N с помощью рекурсии.
    M = 1; N = 15 -> 120
    M = 4; N = 8 -> 30
    */
    Console.Clear();
    int m = GetNumbers();
    int n = GetNumbers();
    int sum = 0;
    void PrintSumNaturals(int m, int n, int sum)
    {
        if (m <= n)
        {
            sum = sum + m;
            m++;
        }
        else
        {
            Console.WriteLine(sum);
            return;
        }
        PrintSumNaturals(m, n, sum);
    }
    PrintSumNaturals(m, n, sum);
}
void Task68()
{
    /*
    Задача 68: Задайте значения M и N. Напишите программу, 
    которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
    M = 28; N = 7 -> 7
    */
    Console.Clear();
    int m = GetNumbers();
    int n = GetNumbers();
    int del;
    if (m < n)
    {
        del = m;
    }
    else
    {
        del = n;
    }
    void GetMaxDelitel(int m, int n, int del)
    {
        if (m % del == 0 && n % del == 0)
        {
            Console.WriteLine(del);
            return;
        }
        else
        {
            del--;
        }
        GetMaxDelitel(m, n, del);
    }
    GetMaxDelitel(m, n, del);
}
void Task70()
{

}
