// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] NewArray (int size, int leftEdge, int rightEdge) // Метод для создания и заполнения массива
{
    double [] myArray = new double[size];
    for (int i = 0; i < size; i++)
    {   
        double rand = Math.Round((new Random().Next(leftEdge, rightEdge) + new Random().NextDouble()),2);
        // Console.Write(Math.Round(rand,2));
        myArray[i] = rand;
       
    }
    
    return myArray;
}

void ShowArray (double [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
       Console.Write(arrayPrint[i] + " " );
    }
    Console.WriteLine();
}

double DifElem (double [] array)  
{
    double difElem = 0;
    double minElem = array[1];
    double maxElem = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
          minElem = array[i];
        }
        else if (array[i] > maxElem)
             {
                maxElem = array[i];
             }
    }
    difElem = maxElem - minElem;
    return difElem;
}

Console.WriteLine("Enter your size: ");
int my_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your leftEdge: ");
int leftEdgeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your rightEdge: ");
int rightEdgeArray = Convert.ToInt32(Console.ReadLine());
double [] newArray = NewArray(my_size, leftEdgeArray, rightEdgeArray);
ShowArray(newArray);
double difElem = DifElem(newArray);
Console.WriteLine($"Dif  elements par seat in your array: {difElem}");