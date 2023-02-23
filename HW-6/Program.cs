using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        int a = 5;
        int b = 20;
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine("Міняємо значення місцями");
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}"); // Виведе "a = 20, b = 10"

        int number = 11113;
        int digitCount;
        int count = CountDigits(number, out digitCount);
        Console.WriteLine($"Число {number} містить {digitCount} цифр."); // Виведе "Число 11113 містить 5 цифр."

        string str = "Hello, world!";
        char result;
        GetCharacterAt(str, 4, out result);
        Console.WriteLine($"Символ у позиції 4: {result}"); // Виведе "Символ у позиції 4: o"
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static int CountDigits(int number, out int digitCount)
    {
        digitCount = 0;
        int temp = number;
        while (temp != 0)
        {
            digitCount++;
            temp /= 10;
        }
        return digitCount;
    }

    public static void GetCharacterAt(string str, int index, out char result)
    {
        if (index >= 0 && index < str.Length)
        {
            result = str[index];
        }
        else
        {
            result = '\0'; // Повернути нульовий символ, якщо індекс невірний
        }
    }
}