// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"После возведения числа {A} в степень {B} - получилось {GetMult(A)}.");

int GetMult(int limit)
{int num = A;

    for (int i = 1; i < B; i++)
    {
        num = num * A;
    }
    return num;
}