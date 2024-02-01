/*
//Задача 1: Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void Between(int m, int n)
{
    Console.Write($"{m} ");
    if (m == n) return;
    Between(n > m ? m + 1 : m - 1, n);
}
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Between(m, n);
*/

/*
//Задача 2: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman (int first, int second)
{
    if (first == 0)
    return second+1;
    if (second == 0)
    {
        return Ackerman(first-1, 1);
    }
    return Ackerman(first-1, Ackerman(first,second-1));
}
Console.Write("Введите число m: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackerman(first,second));
*/

/*
//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

void ShowMirror(int[] array, int first = 0)
{
    if(first != array.Length) 
    {
        ShowMirror(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}
void ShowArray (int [] arrayToShow)
{
    foreach(int val in arrayToShow)
    {
        Console.Write($"{val} ");
    }
    Console.WriteLine();
}

int [] CreateArray (int size)
{
    int [] createArray = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        createArray[i] = rnd.Next(0, 10);
    }
    return createArray;
}
Console.WriteLine($"Веедите размерность массива:");
int[] mat = CreateArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(mat);
ShowMirror(mat);
*/