using System;
using System.Text;

// Логічний зсув (shift).

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte operand = 0b_1000_0001;              // 1000 0001    
            Console.WriteLine("Число до зсуву: {0}", operand);

            // Логічний зсув числа вліво.

            operand = (byte)(operand << 2);   // 0000 0100
            Console.WriteLine("Число після зсуву вліво: {0}", operand);

            // Логічний зсув числа вправо.

            operand = (byte)(operand >> 1);   // 0000 0010

            Console.WriteLine("Число після зсуву вправо: {0}", operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
