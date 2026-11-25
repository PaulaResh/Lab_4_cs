using System;

namespace TimeClass
{
    class Program2
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Console.WriteLine("Задание 6. Класс Time");
            byte h = InputHelper2.ReadByte("Часы (0-23): ", 23);
            byte m = InputHelper2.ReadByte("Минуты (0-59): ", 59);

            Time time = new Time(h, m);
            Console.WriteLine("Время: " + time);

            uint addMins = InputHelper2.ReadUInt("Добавить минут: ");
            Console.WriteLine("После добавления: " +
                time.AddMinutes(addMins));

            Console.WriteLine("\nЗадание 7. Операторы");
            h = InputHelper2.ReadByte("Часы (0-23): ", 23);
            m = InputHelper2.ReadByte("Минуты (0-59): ", 59);
            Time t = new Time(h, m);
            Console.WriteLine("Исходное: " + t);

            Time t1 = ++t;
            Console.WriteLine("++t = " + t1);

            Time t2 = --t1;
            Console.WriteLine("--t1 = " + t2);

            uint mins = InputHelper2.ReadUInt("Минуты для +/-: ");
            Console.WriteLine("t + " + mins + " = " + (t + mins));
            Console.WriteLine(mins + " + t = " + (mins + t));
            Console.WriteLine("t - " + mins + " = " + (t - mins));
            Console.WriteLine(mins + " - t = " + (mins - t));

            Console.WriteLine("(byte)t = " + (byte)t);

            if (t) Console.WriteLine("t != 00:00 (true)");
            else Console.WriteLine("t == 00:00 (false)");

            Console.WriteLine("\n[Нажмите любую клавишу...]");
            Console.ReadKey();
        }
    }
}
