﻿using System;
using System.Text;

// Побітові логічні операції. (&, |)

// Наприклад:
// Ми маємо порт введення / виведення або регістр з певним значенням в ньому.
// Нам має бути увімкненим кероване першим бітом, встановивши перший біт в 1.
// Після нам буде потрібно вимкнути пристрій, скинувши перший біт в 0.
// 1 1 1 1   0 0 0 0 - початкове значення порту вводу / виводу.
// 7 6 5 4   3 2 1 0 - нумерація бітів управління пристроями.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte port = 0b_1111_0000;     // 1 1 1 1   0 0 0 0  -  початкове значення порту вводу / виводу.
            byte mask = 0b_0000_0010;     // 0 0 0 0   0 0 1 0  -  маска включення пристрою керованого першим бітом.
            Console.WriteLine("port = {0:X}", port);

            port = (byte)(port | mask);  // Включити пристрій керований першим бітом.
            Console.WriteLine("port = {0:X}", port);
            
            mask = 0b_1111_1101;          // 1 1 1 1   1 1 0 1  -  Створюємо маску виключення пристрою керованого першим бітом.

            port = (byte)(port & mask);  // Вимкнути пристрій керований першим бітом.
            Console.WriteLine("port = {0:X}", port);

            // Delay.
            Console.ReadKey();
        }
    }
}
