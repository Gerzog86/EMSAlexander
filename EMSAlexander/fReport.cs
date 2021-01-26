using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EMSAlexander
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            dtpMonthPicker.Format = DateTimePickerFormat.Custom;
            dtpMonthPicker.CustomFormat = "MM/yyyy";
        }
    }
}
