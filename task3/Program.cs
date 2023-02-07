// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

int InputInt(string message)
{
    System.Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreatArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
}


void PrintArray(double[] array)
{
    System.Console.Write(" [ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length -1)
        {
            System.Console.Write(" , ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

void Calculation(double[] array)
{
   double min = array[0];
   double max = array[0];
   for (int j = 0; j < array.Length; j++)
   {
    if(array[j] > max)
    {
        max = array[j];
    }
    if(array[j] < min)
    {
      min = array[j];  
    }
   }
   System.Console.WriteLine($"Максимальное значение элемента в массиве = {max}. ");
   System.Console.WriteLine($"Минимальное значение элемента в массиве = {min}");
   System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

int size = InputInt ("Введите количество элементов массива");
double[] array = new double [size];
CreatArray (array);
System.Console.WriteLine("Наш Массив: ");
PrintArray(array);
Calculation (array);
