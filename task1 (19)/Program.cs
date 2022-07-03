// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number;

Console.WriteLine("Введите пятизначное число:");
while (!int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Введите корректное значение:");
}

while (number < 9999 || number > 100000)
{
    System.Console.WriteLine("Введите корректное значение:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Введите корректное значение:");
    }
}

int i = 0;
int n = number;
int[] array = new int[5];

while (i < 5)
{
    array[i] = n % 10;
    i++;
    n /= 10;
}

if (array[0] == array[4] && array[1] == array[3])
{
    System.Console.WriteLine(number + " является палиндромом.");
}
else
{
    System.Console.WriteLine(number + " не палиндром.");
}
