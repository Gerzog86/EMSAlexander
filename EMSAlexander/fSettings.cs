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
    public partial class fSettings : Form
    {
        public fSettings(fMain mainForm)
        {
            InitializeComponent();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            dtpInTime.Format = DateTimePickerFormat.Custom;
            dtpInTime.CustomFormat = "HH:mm";
            dtpOutTime.Format = DateTimePickerFormat.Custom;
            dtpOutTime.CustomFormat = "HH:mm";
            //FileStream fs = new FileStream("Settings.stg", FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            dtpInTime.Value = DateTime.Parse(Personnel.InTimeSetting);
            dtpOutTime.Value = DateTime.Parse(Personnel.OutTimeSetting);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("settings.stg", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Personnel.InTimeSetting);
            sw.WriteLine(Personnel.OutTimeSetting);
            sw.Close();
            fs.Close();
        }
    }
}
