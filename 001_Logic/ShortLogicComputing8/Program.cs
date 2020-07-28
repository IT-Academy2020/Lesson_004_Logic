using System;
using System.Text;

/*   
  * КОРОТКОЗАМКНЕНЕ ОБЧИСЛЕННЯ - техніка працює за наступним принципом:
  * Якщо значення першого операнда в операції AND (&&) є помилковим, то другий операнд не буде вираховуватись,
  * бо повний вираз в будь-якому випадку буде помилковим. 
  */

namespace ShortLogicComputing
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;

            // Умова, яка працює з використанням техніки КОРОТКОЗАМКНЕНЕ ОБЧИСЛЕННЯ.
            // Якби цей вислів обчислювався повністю, то операція ділення у другому операнді,
            // генерувала б помилку ділення на 0.

            if ((denominator != 0) && (item / denominator) > MIN_VALUE) // Залиште один оператор &
            {
                Console.WriteLine("Ми в блоці IF");
            }
            else
            {
                Console.WriteLine("Ми в блоці ELSE");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
