using System;
using System.Text;

// Логічні операції.

// Наприклад:
// Щоб перевірити умову A < x < B, не можна записати його в умовному операторі безпосередньо,
// так як кожна операція відношення повинна мати два операнди.
// Правильний спосіб запису: i f (A <x && x <B).

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int A = 0, B = 5, x = 3;


            if (A < x && x < B) // A < x < B
            {
                Console.WriteLine("Число {0} знаходиться в діапазоні чисел від {1} до {2}. ", x, A, B);
            }
            else
            {
                Console.WriteLine("Число {0} потрапляє в діапазон чисел від {1} до {2}.", x, A, B);
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
