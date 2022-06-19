﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный масиив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void Print(string[] array)                                 // вывод на экран массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
string[] Mass3(string[] array)
{
    int kolstr = 0;                                          // задаем переменную для хранения количества строк с количеством символов меньше либо равным 3
    for (int i = 0; i < array.Length; i++)                   // узнаем количество строк с количеством символов меньше либо равным 3
    {
        if (array[i].Length <= 3)
        {
            kolstr++;
        }
    }
    string[] array3 = new string[kolstr];                    // создание массива с найденым количеством строк
    int str = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array3[str] = array[i];
            str++;
        }
    }
    return array3;
}

string[] array = { "hello", "2", "world", ":-)" };       // задаем массив с произольными значениями
Print(Mass3(array));