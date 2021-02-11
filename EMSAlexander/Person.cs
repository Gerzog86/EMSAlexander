using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EMSAlexander
{
    public class Person
    {

        private string fio;
        public long barcode;
        private string filepath_in, filepath_out, filepath_info;
        private bool onwork = false;
        public List<DateTime> gointimes;
        public List<DateTime> goouttimes;


        public Person() : this(0)
        {
        }
        public Person(long Barcode) : this (Barcode, "ФИО не определены")
        {
        }
        public Person(long Barcode, string FIO)
        {
            if (Barcode == 0)
            {
                this.barcode = this.CreateBarcode();
            }
            else
            {
                this.barcode = Barcode;
            }
            this.fio = FIO;
            this.filepath_in = "Personnel" + "\\" + barcode + "\\" + "intimes.txt";
            this.filepath_out = "Personnel" + "\\" + barcode + "\\" + "outtimes.txt";
            this.filepath_info = "Personnel" + "\\" + barcode + "\\" + "info.txt";
            this.gointimes = new List<DateTime>();
            this.goouttimes = new List<DateTime>();
        }



        public void SetFIO(string FIO)
        {
            this.fio = FIO;
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
            this.onwork = !onwork;
        }


        ///<summary>
        ///<paramref name="in_out">True if InDate, False if OutDate</paramref name="in_out">
        ///</summary>
        public void AddDate (string in_out, DateTime dtToSet)
        {
            if (in_out.Equals("in"))
            {
                this.gointimes.Add(dtToSet);
            }
            else
            {
                if (in_out.Equals("out"))
                {
                    this.goouttimes.Add(dtToSet);
                }
            }
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
            FileStream fs = new FileStream(filepath_in, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            gointimes.Clear();
            while (!sr.EndOfStream)
            {
                gointimes.Add(DateTime.Parse(sr.ReadLine()));
            }
            sr.Close();
            fs.Close();
        }
        public void LoadOutDates()
        {
            FileStream fs = new FileStream(filepath_out, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            goouttimes.Clear();
            while (!sr.EndOfStream)
            {
                goouttimes.Add(DateTime.Parse(sr.ReadLine()));
            }
            sr.Close();
            fs.Close();
        }
        public void LoadAll ()
        {
            this.LoadInfo();
            this.LoadInDates();
            this.LoadOutDates();
        }


        public void SaveInfo ()
        {
            Directory.CreateDirectory("Personnel" + "\\" + barcode);
            FileStream fs = new FileStream(filepath_info, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(fio);
            sw.Write(onwork.ToString());
            sw.Close();
            fs.Close();
        }
        public void SaveInDates ()
        {
            FileStream fs = new FileStream(filepath_in, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            if (gointimes.Count > 0)
            {
                foreach (DateTime i in gointimes)
                {
                    sw.WriteLine(i);
                }
            }
            sw.Close();
            fs.Close();
        }
        public void SaveOutDates ()
        {
            FileStream fs = new FileStream(filepath_out, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (DateTime i in goouttimes)
            {
                sw.WriteLine(i);
            }
            sw.Close();
            fs.Close();
        }
        public void SaveAll ()
        {
            this.SaveInfo();
            this.SaveInDates();
            this.SaveOutDates();
        }


        public long CreateBarcode()
        {
            int counter = 0;
            Random rand = new Random();
            long newBar = rand.Next(1000000, 9999999);
            EAN8 nB = new EAN8(newBar.ToString());
            newBar = long.Parse(nB.returnBarcode());
            foreach (long i in Personnel.barcodes.Keys)
            {
                if (newBar != i)
                {
                    counter++;
                }
            }
            if (counter == Personnel.barcodes.Count)
            {
                return newBar;
            }
            else
            {
                return CreateBarcode();
            }
        }
    }
}
