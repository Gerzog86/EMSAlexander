using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EMSAlexander
{
    public partial class fReport : Form
    {

        private Dictionary<string, int> GoodInTimes= new Dictionary<string, int>();


        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            dtpMonthPicker.Format = DateTimePickerFormat.Custom;
            dtpMonthPicker.CustomFormat = "MM/yyyy";
        }

        private void bExportAndCalcMonth_Click(object sender, EventArgs e)
        {
            GoodInTimes = Personnel.CalculateTimes(dtpMonthPicker.Value.Month.ToString(), "in");
            if (sfdExportMonthInTimes.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfdExportMonthInTimes.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var export in GoodInTimes)
                {
                    sw.WriteLine(export.Key + "\t\t\t" + export.Value);
                }
                sw.Close();
                fs.Close();
            }
        }
    }
}
