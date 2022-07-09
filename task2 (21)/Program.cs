// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


void FillArray(int[] collection)
{
    int index = 0;
    while (index < 3)
    {
        Console.Write("кордината точки:");
        collection[index] =  int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int position = 0;
    while (position < 3)
    {
        if (position == 2)
        {
            Console.WriteLine(col[position]);
        }
        else 
        {
            Console.Write(col[position] + " ");
        }
        position++;
    }
}

int[] array1 = new int [3]; //определила массив 1
int[] array2 = new int [3]; //определила массив 2

Console.WriteLine("введите координаты точки №1 в трехмерном пространстве:");
FillArray(array1); //вызвала функцию заполнения массива
Console.WriteLine("координаты точки №1:");
PrintArray(array1); //вызвала функцию печати массива

Console.WriteLine("введите координаты точки №2 в трехмерном пространстве:");
FillArray(array2); //вызвала функцию заполнения массива
Console.WriteLine("координаты точки №2:");
PrintArray(array2); //вызвала функцию печати массива


double dist;
Console.Write("расстояние между двумя точками равно:");
dist = Math.Sqrt(Math.Pow((array2[0]-array1[0]), 2) + Math.Pow((array2[1]-array1[1]), 2) + Math.Pow((array2[2]-array1[2]), 2));
Console.WriteLine(Math.Round(dist, 2));