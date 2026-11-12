using System;

namespace TimeClass
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            // ЗАДАНИЕ 6: Тестирование Time
            Console.WriteLine(
                "Задание 6. Класс Time");
            byte h = InputHelper.ReadByte(
                "Часы (0-23): ", 23);
            byte m = InputHelper.ReadByte(
                "Минуты (0-59): ", 59);
            Time time = new Time(h, m);
            Console.WriteLine(
                "Время: " + time);

            uint addMins = InputHelper.ReadUInt(
                "Добавить минут: ");
            Time newTime = time.AddMinutes(addMins);
            Console.WriteLine(
                "После добавления " + addMins +
                " мин: " + newTime);


            // ЗАДАНИЕ 7: Перегрузка операций
            Console.WriteLine(
                "\nЗадание 7. " +
                "Перегрузка операций");

            h = InputHelper.ReadByte(
                "Часы (0-23): ", 23);
            m = InputHelper.ReadByte(
                "Минуты (0-59): ", 59);
            Time t = new Time(h, m);
            Console.WriteLine(
                "Исходное время: " + t);

            Time t1 = ++t;
            Console.WriteLine(
                "++t = " + t1);

            Time t2 = --t1;
            Console.WriteLine(
                "--t1 = " + t2);

            uint mins = InputHelper.ReadUInt(
                "Минуты для +: ");
            Time t3 = t + mins;
            Console.WriteLine(
                "t + " + mins + " = " + t3);

            Time t4 = mins + t;
            Console.WriteLine(
                mins + " + t = " + t4);

            Time t5 = t - mins;
            Console.WriteLine(
                "t - " + mins + " = " + t5);

            Time t6 = mins - t;
            Console.WriteLine(
                mins + " - t = " + t6);

            byte hoursOnly = (byte)t;
            Console.WriteLine(
                "(byte)t = " + hoursOnly +
                " (только часы)");

            // Неявное приведение к bool
            if (t)
            {
                Console.WriteLine(
                    "t != 0:0 (true)");
            }
            else
            {
                Console.WriteLine(
                    "t == 0:0 (false)");
            }

            Time zero = new Time(0, 0);
            if (zero)
            {
                Console.WriteLine(
                    "zero != 0:0 (true)");
            }
            else
            {
                Console.WriteLine(
                    "zero == 0:0 (false)");
            }

            Console.WriteLine(
                "\n[Нажмите любую клавишу...]");
            Console.ReadKey();
        }
    }
}