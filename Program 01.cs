// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int QuantityElements (int [] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity += 1;
        }
    }
    return quantity;
}

Console.WriteLine("Enter your size: ");
int my_size = Convert.ToInt32(Console.ReadLine());
int leftEdgeArray = 100;
int rightEdgeArray = 1000;
int [] newArray = NewArray(my_size, leftEdgeArray, rightEdgeArray);
ShowArray(newArray);
QuantityElements(newArray);
int quantityElements = QuantityElements(newArray);
Console.WriteLine($"Number of paired elements in your array: {quantityElements}");
