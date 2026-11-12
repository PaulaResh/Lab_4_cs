using System;

namespace TimeClass
{
    public static class InputHelper
    {
        public static byte ReadByte(
            string prompt = "",
            byte max = 255)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (byte.TryParse(
                        input, out byte result))
                {
                    if (result > max)
                    {
                        Console.WriteLine(
                            $"Ошибка: " +
                            $"максимум {max}.");
                        continue;
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine(
                        "Ошибка: " +
                        "некорректное число.");
                }
            }
        }

        public static uint ReadUInt(
            string prompt = "")
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
                else
                {
                    Console.WriteLine(
                        "Ошибка: " +
                        "некорректное число.");
                }
            }
        }
    }
}