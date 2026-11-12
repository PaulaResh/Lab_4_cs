using System;

namespace TimeClass
{
    public class Time
    {
        private byte _hours;
        private byte _minutes;

        public byte Hours
        {
            get { return _hours; }
        }

        public byte Minutes
        {
            get { return _minutes; }
        }

        public Time()
        {
            _hours = 0;
            _minutes = 0;
        }

        public Time(byte hours, byte minutes)
        {
            if (hours > 23)
            {
                throw new Exception(
                    "Часы: 0-23");
            }
            if (minutes > 59)
            {
                throw new Exception(
                    "Минуты: 0-59");
            }
            _hours = hours;
            _minutes = minutes;
        }

        // ЗАДАНИЕ 6: Метод добавления минут
        public Time AddMinutes(uint mins)
        {
            uint totalMinutes =
                (uint)(_hours * 60 + _minutes)
                + mins;
            byte newHours =
                (byte)((totalMinutes / 60) % 24);
            byte newMins =
                (byte)(totalMinutes % 60);
            return new Time(newHours, newMins);
        }

        // ЗАДАНИЕ 7:
        // ++
        public static Time operator ++(Time t)
        {
            return t.AddMinutes(1);
        }

        // --
        public static Time operator --(Time t)
        {
            uint totalMinutes =
                (uint)(t._hours * 60 + t._minutes);
            if (totalMinutes == 0)
            {
                totalMinutes = 24 * 60;
            }
            totalMinutes--;
            byte newHours =
                (byte)((totalMinutes / 60) % 24);
            byte newMins =
                (byte)(totalMinutes % 60);
            return new Time(newHours, newMins);
        }

        // Перегрузка + (Time + uint)
        public static Time operator +(
            Time t, uint mins)
        {
            return t.AddMinutes(mins);
        }

        // Перегрузка + (uint + Time)
        public static Time operator +(
            uint mins, Time t)
        {
            return t.AddMinutes(mins);
        }

        // Перегрузка - (Time - uint)
        public static Time operator -(
            Time t, uint mins)
        {
            uint totalMinutes =
                (uint)(t._hours * 60 + t._minutes);
            if (mins > totalMinutes)
            {
                totalMinutes += 24 * 60;
            }
            totalMinutes -= mins;
            byte newHours =
                (byte)((totalMinutes / 60) % 24);
            byte newMins =
                (byte)(totalMinutes % 60);
            return new Time(newHours, newMins);
        }

        // Перегрузка - (uint - Time)
        public static Time operator -(
            uint mins, Time t)
        {
            uint totalMinutes =
                (uint)(t._hours * 60 + t._minutes);
            if (totalMinutes > mins)
            {
                totalMinutes += 24 * 60;
            }
            uint result = mins - totalMinutes;
            if (result >= 24 * 60)
            {
                result %= 24 * 60;
            }
            byte newHours =
                (byte)((result / 60) % 24);
            byte newMins =
                (byte)(result % 60);
            return new Time(newHours, newMins);
        }

        // Явное приведение к byte (часы)
        public static explicit operator byte(
            Time t)
        {
            return t._hours;
        }

        // Неявное приведение к bool
        public static implicit operator bool(
            Time t)
        {
            return t._hours != 0 ||
                   t._minutes != 0;
        }

        public override string ToString()
        {
            return _hours.ToString().PadLeft(2, '0')
                + ":" +
                _minutes.ToString().PadLeft(2, '0');
        }
    }
}