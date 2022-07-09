/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write(col[position] + ".");
        }
        else
        {
            Console.Write(col[position] + ", ");
        }
        position++;
    }
}

Console.WriteLine("Введите число:");
int N;
while (!int.TryParse(Console.ReadLine(), out N))
{
    System.Console.WriteLine("Введите корректное значение:");
}

int i = 0;
int n = 1;
int[] array = new int[N];
while (n <= N)
{
    array[i] = n*n*n;
    i++;
    n++;
}

PrintArray(array);
