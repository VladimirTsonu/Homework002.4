// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] NewArray (int size, int leftEdge, int rightEdge) // Метод для создания и заполнения массива
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(leftEdge, rightEdge + 1);
    }
    return myArray;
}

void ShowArray (int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
       Console.Write(arrayPrint[i] + " " );
    }
    Console.WriteLine();
}
/*
int SumElementsPar (int [] array) // Первый вариант
{
    int sumElem = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
       sumElem += array[i];
    }
    return sumElem;
}
*/

int SumElementsPar (int [] array) // Второй вариант
{
    int sumElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
           sumElem += array[i];
        }
    }
    return sumElem;
}

Console.WriteLine("Enter your size: ");
int my_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your leftEdge: ");
int leftEdgeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your rightEdge: ");
int rightEdgeArray = Convert.ToInt32(Console.ReadLine());
int [] newArray = NewArray(my_size, leftEdgeArray, rightEdgeArray);
ShowArray(newArray);
int sumElementsPar = SumElementsPar(newArray);
Console.WriteLine($"Sum  elements par seat in your array: {sumElementsPar}");
