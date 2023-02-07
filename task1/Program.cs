//Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите
//  программу, которая покажет количество чётных 
//  чисел в массиве.
//  Домашняя работа 5


Console.Clear ();
int InputInt(string message)
{
    System.Console.WriteLine(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreatArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}


void PrintArray(int[] array)
{ 
    System.Console.Write( "[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int Calculationofevennumb(int[] array)
{
    int count = 0;
    for (int j = 0;  j< array.Length; j++)
    {
        if(array[j] % 2 ==0)
        {
            count++;
        }   
    }
    return count;
}

int size = InputInt ("Введите количество элементов в массиве");
int[] array = new int [size];
CreatArray(array);
System.Console.WriteLine("Наш Массив: ");
PrintArray(array);
int result = Calculationofevennumb(array);
System.Console.WriteLine($"В данном массиве четные цифры > {result}");
