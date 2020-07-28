using System;
using System.Text;

/*
 * Перетворення логічних змінних відповідно до теоремами Де Моргана.
 * Для застосування теорем Де Моргана до логічного оператору AND або OR і пари операндів, 
 * потрібно інвертувати обидва операнда, замінити (AND на OR) або (OR на AND) і 
 * інвертувати всі вирази повністю.
 * 
 *  Початковий вираз                                Еквівалентний вираз
 *     !A & !B                       =                  !(A | B)
 *     !A & B                        =                  !(A | !B)
 *     A & !B                        =                  !(!A | B)   
 *     A & B                         =                  !(!A | !B)
 *     !A | !B                       =                  !(A & B)
 *     !A | B                        =                  !(A & !B)
 *     A | !B                        =                  !(!A & B) 
 *     A | B                         =                  !(!A & !B)    
 */

namespace DeMorganTheorems
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool A = true;
            bool B = false;

            // Умова до застосування теореми Де Моргана.
            if (!A || !B)
                Console.WriteLine("!A || !B = {0}", !A || !B);
            else
                Console.WriteLine("!A || !B = {0}", !A || !B);

            // Умова після застосування теореми Де Моргана.
            if (!(A && B))
                Console.WriteLine("!(A && B) = {0}", !(A && B));
            else
                Console.WriteLine("!(A && B) = {0}", !(A && B));

            // Delay.
            Console.ReadKey();
        }
    }
}
