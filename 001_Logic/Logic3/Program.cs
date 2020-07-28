using System;
using System.Text;

// Побітові логічні операції. (^)

// Наприклад:
// Використовуючи операцію XOR, ми можемо зашифрувати повідомлення.
// У такому вигляді шифрування використовується один ключ, як для шифрування, так і для розшифровки.
// Крипостійкість такого ключа, можна збільшити, якщо збільшити його довжину.

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ushort secretKey = 0x0088; // Секретний ключ (довжина - 16 bit).
            char character = 'A';      // Вихідний символ для шифрування.

            Console.WriteLine("Вихідний символ: {0}, його код в кодовій таблиці: {1:X}", character, (byte)character);
            Console.WriteLine("Розмір символу: {0} = {1} біт ", character, sizeof(char) * 8);

            // Зашифровувати символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Зашифрований символ: {0}, його код в кодовій таблиці: {1:X}", character, (byte)character);

            // Розшифровуємо символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Розшифрований символ: {0}, його код в кодовій таблиці: {1:X} ", character, (byte)character);

            // Delay.
            Console.ReadKey();
        }
    }
}
