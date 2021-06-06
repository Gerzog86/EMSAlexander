using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSAlexander
{
    public static class DayOfWeekRus
    {
        private static string[,] _values = new string[3, 7]
        {
            {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"},
            {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"},
            {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"}
        };
        private static int _language = 0;
        public static void SetLanguage(string language)
        {
            switch (language)
            {
                case "RU":
                    _language = 0;
                    break;
                default:
                    _language = 0;
                    break;
            }
        }
        public static int DayToInt(string s)
        {
            for (int i = 0; i < 7; i++)
            {
                if (_values[_language, i].Equals(s))
                {
                    return i;
                }
            }
            return -1;
        }
        public static string IntToDay(int i)
        {
            return _values[_language, i];
        }
    }
}
