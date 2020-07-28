using System;
using System.Text;

// Побітові логічні операції.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte operand1 = 0, operand2 = 0;
            int result;

            #region Кон'юнкція

            // Таблиця істинності для операцій кон'юнкції (І) - & - [AND]

            // Якщо хоч один з операндів має значення 0 - вся конструкція має значення 0. Інакше - 1

            //    0 & 0 = 0         1 & 0 = 0
            //    0 & 1 = 0         1 & 1 = 1

            operand1 = 255;                          // [1111 1111 Bin] = [FF Hex] = [255 Dec]            
            operand2 = 1;                            // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 & operand2;            // [0000 0001 Bin] = [01 Hex] = [01 Dec]

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);

            #endregion

            #region Диз'юнкція

            // Таблиця істинності для диз'юнкції (АБО) - | - [OR]

            // Якщо хоч один з операндів має значення 1 - вся конструкція має значення 1. Інакше - 0

            //    0 | 0 = 0         1 | 0 = 1
            //    0 | 1 = 1         1 | 1 = 1

            operand1 = 2;                             // [0000 0010 Bin] = [02 Hex] = [02 Dec]            
            operand2 = 1;                             // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 | operand2;             // [0000 0011 Bin] = [03 Hex] = [03 Dec]

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);

            #endregion

            #region Виключне АБО

            // Таблиця істинності для виключного АБО - ^ - [XOR]

            // Якщо операнди мають однакове значення - результат операції 0,
            // Якщо операнди різні - 1

            //    0 ^ 0 = 0         1 ^ 0 = 1
            //    1 ^ 1 = 0         0 ^ 1 = 1  

            operand1 = 3;                             // [0000 0011 Bin] = [03 Hex] = [03 Dec]            
            operand2 = 1;                             // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 ^ operand2;             // [0000 0010 Bin] = [02 Hex] = [02 Dec]

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);

            #endregion

            #region Заперечення

            // Таблиця істинності для Заперечення (НІ) - ~ - [NOT]

            // ~ 0  = 1                                // [0000 0001] = [ 1 Dec]
            // ~ 1  = 0                                // [1111 1110] = [-2 Dec]    

            operand1 = 1;
            result = ~operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);

            #endregion

            #region Зміна знака числа

            // Формула зміни знака числа, з (+ N) на (-N) або навпаки.

            // Для того, щоб змінити знак числа, необхідно:
            // виконати його заперечення, а результат збільшити на 1.

            //  ~  +N + 1 = -N
            //  ~  -N + 1 = +N                      

            operand1 = 1;                               // [0000 0001]
            result = ~operand1;                         // [1111 1110]
            result++;                                   // [1111 1111]

            Console.WriteLine(" ~ {0} + 1 = {1} ", operand1, result);
            
            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
