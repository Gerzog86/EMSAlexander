using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EMSAlexander
{
    class Person
    {

        private string fio;
        private long barcode;
        private string filepath_in, filepath_out;
        private bool onwork;
        private DateTime[] gointimes;
        private DateTime[] goouttimes;

        Person(long Barcode, string FIO)
        {
            barcode = Barcode;
            fio = FIO;
            filepath_in = "Personnel\"" + barcode + "\"" + "intimes.txt";
            filepath_out = "Personnel\"" + barcode + "\"" + "outtimes.txt";
        }


        public void ChangeWorkStatus()
        {
            onwork = !onwork;
        }


        public void SetFIO (string FIO)
        {
            fio = FIO;
        }
        public string ReturnFIO ()
        {
            return fio;
        }

        public void SaveToFile ()
        {
            StreamWriter sw = new StreamWriter(filepath_in);
            foreach (DateTime i in gointimes)
            {
                sw.WriteLine(i);
            }
            sw = new StreamWriter(filepath_out);
            foreach (DateTime i in goouttimes)
            {
                sw.WriteLine(i);
            }
        }
    }
}
