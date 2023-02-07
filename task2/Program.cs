﻿// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.


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
        array[i] = new Random().Next(1,10);
    }
}


void PrintArray(int[] array)
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

int SumIndex(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j += 2)
    {
        sum = sum + array[j];
    }
    return sum;
}


int size = InputInt ("Введите количество элементов массива");
int[] array = new int [size];
CreatArray (array);
System.Console.WriteLine("Наш Массив: ");
PrintArray(array);
int result = SumIndex (array);
System.Console.Write($"сумма элементов на нечетных позициях = {result}");

