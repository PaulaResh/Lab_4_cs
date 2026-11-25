using System;

namespace CollectionsTasks
{
    public static class InputHelper1
    {
        public static int ReadInt(
            string prompt = "",
            bool allowNegative = true)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(
                        input, out int result))
                {
                    if (!allowNegative && result < 0)
                    {
                        Console.WriteLine(
                            "Ошибка: неотрицательное.");
                        continue;
                    }
                    return result;
                }
                Console.WriteLine(
                    "Ошибка: некорректное число.");
            }
        }

        public static uint ReadUInt(string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (uint.TryParse(
                        input, out uint result))
                {
                    return result;
                }
                Console.WriteLine(
                    "Ошибка: некорректное число.");
            }
        }

        public static string ReadString(string prompt = "")
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                Console.WriteLine(
                    "Ошибка: непустая строка.");
            }
        }
    }
}
