using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
            {10000052, "Стороженко Ольга"},
            {10000069, "Минина Светлана"},
            {10000076, "Чикоткова Арина"},
            {10000083, "Цемина Юлия"},
            {10000090, "Милютина Светлана"},
            {10000106, "Красноруцкий Дмитрий"},
            {10000113, "Костюков Сергей"},
            {10000120, "Сухарь Ирина"}
        };*/

        static public string InTimeSetting, OutTimeSetting, OrganisationName;
        static public Dictionary<long, Person> barcodes = new Dictionary<long, Person>();

        public static void LoadPersonnel()
        {
            StreamReader sr = new StreamReader("Personnel" + "\\" + "barcodes.txt");
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                barcodes.Add(long.Parse(s), new Person(long.Parse(s)));
            }
            sr.Close();
            foreach (Person i in barcodes.Values)
            {
                i.LoadAll();
            }
        }
        public static void SavePersonnel()
        {
            foreach (Person i in barcodes.Values)
            {
                i.SaveAll();
            }
        }


        private static string CalculatePersonTimes(string month, long barcode, string in_out, out int count)
        {
            count = 0;
            Person temp = null;
            if (in_out.Equals("in"))
            {
                barcodes.TryGetValue(barcode, out temp);
                foreach (DateTime t in temp.gointimes)
                {
                    if ( (t.Month.ToString().Equals(month)) && (DateTime.Parse(t.ToShortTimeString()).CompareTo(DateTime.Parse(InTimeSetting)) <= 0) )
                    {
                        count++;
                    }
                }
            }
            else
            {
                if (in_out.Equals("out"))
                {
                    barcodes.TryGetValue(barcode, out temp);
                    foreach (DateTime t in temp.goouttimes)
                    {
                        if ((t.Month.ToString().Equals(month)) && (DateTime.Parse(t.ToShortTimeString()).CompareTo(DateTime.Parse(InTimeSetting)) >= 0))
                        {
                            count++;
                        }
                    }
                }
            }
            return temp.GetFIO();
        }
        public static Dictionary<string, int> CalculateTimes(string month, string in_out)
        {
            Dictionary<string, int> toReturn = new Dictionary<string, int>();
            foreach (long i in barcodes.Keys)
            {
                string fio = "";
                int count = 0;
                fio = CalculatePersonTimes(month, i, in_out, out count);
                toReturn.Add(fio, count);
            }
            return toReturn;
        }

        public static string ReturnFIO(long barcode)
        {
            Person toReturn = null;
            barcodes.TryGetValue(barcode, out toReturn);
            return toReturn.GetFIO();
        }
        public static void SetFIO(long barcode, string fio)
        {
            Person toSet = null;
            barcodes.TryGetValue(barcode, out toSet);
            toSet.SetFIO(fio);
        }

        public static bool IsOnWork (long barcode)
        {
            Person toReturn = null;
            barcodes.TryGetValue(barcode, out toReturn);
            return toReturn.IsOnWork();
        }
        public static void ChangeWorkStatus (long barcode)
        {
            Person toSet = null;
            barcodes.TryGetValue(barcode, out toSet);
            toSet.ChangeWorkStatus();
        }


        //public static void SetInDates ()
    }
}
