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
            dtpInTime.CustomFormat = "HH:MM";
            dtpOutTime.Format = DateTimePickerFormat.Custom;
            dtpOutTime.CustomFormat = "HH:MM";
            //FileStream fs = new FileStream("Settings.stg", FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            dtpInTime.Value = Personnel.InTimeSetting;
            dtpOutTime.Value = Personnel.OutTimeSetting;
        }
    }
}
