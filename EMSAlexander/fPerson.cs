using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EMSAlexander
{
    public partial class fPerson : Form
    {
        long barcode;

        public fPerson()
        {
            InitializeComponent();
        }

        public fPerson(long BarCode)
        {
            InitializeComponent();
            barcode = BarCode;
        }

        private void fPerson_Load(object sender, EventArgs e)
        {
            EAN8 toDraw = new EAN8(barcode.ToString());
            pbBarcode.Image = toDraw.CreateBarcodeBitmap(pbBarcode.Width, pbBarcode.Height);
        }
    }
}
