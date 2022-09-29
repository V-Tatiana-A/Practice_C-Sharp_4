// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;

Clear();

WriteLine("Задача 25");
WriteLine("Введите число");
int A = int.Parse(ReadLine()!);
WriteLine("Введите натуральную степень");
int B = int.Parse(ReadLine()!);
if(B<=0) 
    WriteLine("Второе число должно быть натуральным");
else 
    WriteLine($"{A} в {B} степени равно {Exponentiation(A, B)}");


// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

WriteLine();
WriteLine("Задача 27");
WriteLine("Введите число");
int C = int.Parse(ReadLine()!);
WriteLine($"Сумма цифр в этом числе составляет {GetSumDigits(Math.Abs(C))}");

// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]

WriteLine();
WriteLine("Задача 29");
WriteLine("Введите число элементов массива");
int D = int.Parse(ReadLine()!);
PrintNewArray(D);

// для уменьшения чисел в массиве:
// WriteLine();
// WriteLine("Введите максимально возможное число в массиве");
// int E = int.Parse(ReadLine()!);
// PrintNewArrayShort(D, E);





// methods

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for(int i=1; i<=num2;i++) result=result*num1;
    return result;
}

int GetSumDigits(int num3)
{
    int result = 0;
    while(num3>=1)
    {
        result=result+num3%10;
        num3=num3/10;
    }
    return result;
}

void PrintNewArray(int length)
{
    Write("[");
    int[] array = new int[length];
    for(int i=0;i<length-1;i++)
    {
        array[i]=new Random().Next();
        Write($"{array[i]}, ");
    }  
    array[length-1]=new Random().Next();
    Write($"{array[length-1]}]");
}

// если задано максимальное число в массиве:
void PrintNewArrayShort(int length, int max)
{
    Write("[");
    int[] array = new int[length];
    for(int i=0;i<length-1;i++)
    {
        array[i]=new Random().Next(max);
        Write($"{array[i]}, ");
    }  
    array[length-1]=new Random().Next(max);
    Write($"{array[length-1]}]");
}