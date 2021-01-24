using System;
using System.Collections.Generic;
using System.Text;

namespace EMSAlexander
{
    static class Personnel
    {

        /*static private Dictionary<long, string> barcodes = new Dictionary<long, string>
        {

            {10000014, "Остроушко Иван"},
            {10000021, "Жовнер Эльвира"},
            {10000038, "Белогорцева Лидия"},
            {10000045, "Остроушко Елена"},
            {10000052, "Осадченко Ольга"},
            {10000069, "Минина Светлана"},
            {10000076, "Чикоткова Арина"},
            {10000083, "Цемина Юлия"},
            {10000090, "Милютина Светлана"},
            {10000106, "Красноруцкий Дмитрий"},
            {10000113, "Костюков Сергей"},
            {10000120, "Сухарь Ирина"}
        };*/

        static private Dictionary<long, Person> barcodes = new Dictionary<long, Person>
        {

        }

        public static string ReturnFIO(long barcode)
        {
            string toReturn = null;
            barcodes.TryGetValue(barcode, out toReturn);
            return toReturn;
        }
    }
}
