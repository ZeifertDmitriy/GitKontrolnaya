﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный масиив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = { "hello", "2", "world", ":-)" };       // задаем массив с произольными значениями
int kolstr = 0;                                          // задаем переменную для хранения количества строк с количеством символов меньше либо равным 3
for (int i = 0; i < array.Length; i++)                   // узнаем количество строк с количеством символов меньше либо равным 3
{
    if (array[i].Length <= 3)
    {
        kolstr++;
    }
}
string[] array3 = new string[kolstr];                    // создание массива с найденым количеством строк
for (int i = 0; i < array3.Length; i++)                  // заполнение массива стоками с количеством символов меньше либо равным 3
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[i].Length <= 3)
        {
            array3[i] = array[j];
        }
    }
}
Console.WriteLine(kolstr);