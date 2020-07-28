using System;
using System.Text;

// Логічні операції.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool operand1 = false, operand2 = false, result = false;

            #region Кон'юнкція

            // Таблиця істинності для кон'юнкції (І) - && - [AND]

            // Якщо хоч один з виразів операції кон'юнкції має значення false -
            // весь вираз має значення false, інакше - true

            // false && false = false                  true && false = false
            // false && true = false                   true && true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 && operand2;             // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);

            #endregion

            #region Диз'юнкція

            // Таблиця істинності для диз'юнкції (АБО) - || - [OR]

            // Якщо хоч один з виразів операції диз'юнкції має значення true -
            // весь вираз має значення true, інакше - false

            // false || false = false                  true || false = true         
            // false || true = true                    true || true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);

            #endregion

            #region Виколючне АБО

            // Таблиця істинності для виключного АБО - ^ - [XOR]

            // Якщо обидва вирази операції виключНОГО АБО мають однаковЕ значення -
            // весь вираз має значення false, якщо різні - true


            // false ^ false = false                   true ^ false = true
            // false ^ true = true                     true ^ true = false

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 ^ operand2;              // true

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);

            #endregion

            #region Заперечення

            // Таблиця істинності для Заперечення (НІ) -! - [NOT]

            // !false  = true
            // !true  = false       

            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
