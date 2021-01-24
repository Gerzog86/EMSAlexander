using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EMSAlexander
{
    public class Person
    {

        private string fio;
        private long barcode;
        private string filepath_in, filepath_out, filepath_info;
        private bool onwork;
        private List<DateTime> gointimes;
        private List<DateTime> goouttimes;


        public Person(long Barcode)
        {
            barcode = Barcode;
            filepath_in = "Personnel" + "\\" + barcode + "\\" + "intimes.txt";
            filepath_out = "Personnel" + "\\" + barcode + "\\" + "outtimes.txt";
            filepath_info = "Personnel" + "\\" + barcode + "\\" + "info.txt";
            gointimes = new List<DateTime>();
            goouttimes = new List<DateTime>();
        }
        public Person(long Barcode, string FIO)
        {
            barcode = Barcode;
            fio = FIO;
            filepath_in = "Personnel" + "\\" + barcode + "\\" + "intimes.txt";
            filepath_out = "Personnel" + "\\" + barcode + "\\" + "outtimes.txt";
            filepath_info = "Personnel" + "\\" + barcode + "\\" + "info.txt";
            gointimes = new List<DateTime>();
            goouttimes = new List<DateTime>();
        }



        public void SetFIO(string FIO)
        {
            fio = FIO;
        }
        public string GetFIO()
        {
            return fio;
        }



        public bool IsOnWork ()
        {
            return onwork;
        }
        public void ChangeWorkStatus()
        {
            onwork = !onwork;
        }





        public void LoadInfo ()
        {
            StreamReader sr = new StreamReader (filepath_info);
            fio = sr.ReadLine();
            onwork = bool.Parse(sr.ReadLine());
            sr.Close();
        }
        public void LoadInDates ()
        {
            StreamReader sr = new StreamReader(filepath_in);
            gointimes.Clear();
            while (!sr.EndOfStream)
            {
                gointimes.Add(DateTime.Parse(sr.ReadLine()));
            }
        }
        public void LoadOutDates()
        {
            StreamReader sr = new StreamReader(filepath_out);
            goouttimes.Clear();
            while (!sr.EndOfStream)
            {
                goouttimes.Add(DateTime.Parse(sr.ReadLine()));
            }
        }
        public void LoadAll ()
        {
            this.LoadInfo();
            this.LoadInDates();
            this.LoadOutDates();
        }


        public void SaveInfo ()
        {
            StreamWriter sw = new StreamWriter(filepath_info);
            sw.WriteLine(fio);
            sw.Write(onwork.ToString());
            sw.Close();
        }
        public void SaveInDates ()
        {
            StreamWriter sw = new StreamWriter(filepath_in);
            foreach (DateTime i in gointimes)
            {
                sw.WriteLine(i);
            }
            sw.Close();
        }
        public void SaveOutDates ()
        {
            StreamWriter sw = new StreamWriter(filepath_out);
            foreach (DateTime i in goouttimes)
            {
                sw.WriteLine(i);
            }
        }
        public void SaveAll ()
        {
            this.SaveInfo();
            this.SaveInDates();
            this.SaveOutDates();
        }
    }
}
