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

            // Умова, яка не працює з використанням техніки КОРОТКОЗАМКНЕНЕ ОБЧИСЛЕННЯ.
            // Через те що, операція && (And) обчислюється зліва направо,
            // даний логічний вираз працювати не буде!

            if (((item / denominator) > MIN_VALUE) && (denominator != 0))
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
