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
                throw new Exception("Часы: 0-23");
            if (minutes > 59)
                throw new Exception("Минуты: 0-59");
            _hours = hours;
            _minutes = minutes;
        }

        // ЗАДАНИЕ 6:
        public Time AddMinutes(uint mins)
        {
            uint total = (uint)(_hours * 60 + _minutes) + mins;
            byte newH = (byte)((total / 60) % 24);
            byte newM = (byte)(total % 60);
            return new Time(newH, newM);
        }

        // ЗАДАНИЕ 7:
        public static Time operator ++(Time t)
        {
            uint total = (uint)(t._hours * 60 + t._minutes);
            total = (total + 1) % 1440;
            t._hours = (byte)(total / 60);
            t._minutes = (byte)(total % 60);
            return t;
        }

        public static Time operator --(Time t)
        {
            uint total = (uint)(t._hours * 60 + t._minutes);
            total = (total + 1440 - 1) % 1440;
            t._hours = (byte)(total / 60);
            t._minutes = (byte)(total % 60);
            return t;
        }

        public static Time operator +(Time t, uint mins)
        {
            return t.AddMinutes(mins);
        }

        public static Time operator +(uint mins, Time t)
        {
            return t.AddMinutes(mins);
        }

        // Бинарный - (Time - uint)
        public static Time operator -(Time t, uint mins)
        {
            uint total = (uint)(t._hours * 60 + t._minutes);
            if (mins > total) total += 1440;
            total -= mins;
            return new Time(
                (byte)((total / 60) % 24),
                (byte)(total % 60));
        }

        public static Time operator -(uint mins, Time t)
        {
            uint total = (uint)(t._hours * 60 + t._minutes);
            uint res = mins >= total ?
                mins - total : mins + 1440 - total;
            res %= 1440;
            return new Time(
                (byte)((res / 60) % 24),
                (byte)(res % 60));
        }

        // Явное приведение к byte (часы)
        public static explicit operator byte(Time t)
        {
            return t._hours;
        }

        // Неявное приведение к bool (не 00:00)
        public static implicit operator bool(Time t)
        {
            return t._hours != 0 || t._minutes != 0;
        }

        public override string ToString()
        {
            return _hours.ToString().PadLeft(2, '0') +
                   ":" +
                   _minutes.ToString().PadLeft(2, '0');
        }
    }
}
