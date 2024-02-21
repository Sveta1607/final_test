// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Основные этапы решения задачи :
// Функция вывода на печать элементов массива
// Функция создания массива из вводимых пользователем с клавиатуры значений
// Функция создания нового массива, с элементами по заданному в условии критерию

﻿void PrintArray(string[] array)
{
    for(int c = 0;c<array.Length;c++)
    {
        Console.Write(array[c]);
        Console.Write(", ");
    }
}

string[] Vvod ()
{
    Console.WriteLine("Введите значения через запятую в одну строку : ");
    string vvod = Console.ReadLine();
    string[] vvod_array  = (vvod.Split(","));
    return vvod_array;
}

string[] Len3_array()
{
    string[] array = Vvod();
    string new_string = String.Empty;
    for(int count = 0;count<array.Length;count++)
    {
        if(array[count].Length<=3)
        {
            new_string=new_string+array[count]+",";
        }
    }
    new_string = new_string.Remove(new_string.Length-1);
    string[] new_array = new_string.Split(",");
    return new_array;
}
PrintArray(Len3_array());