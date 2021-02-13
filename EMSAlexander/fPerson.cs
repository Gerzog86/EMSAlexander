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
        Person t;
        fPersonnel f;

        public fPerson()
        {
            InitializeComponent();
        }

        public fPerson(long BarCode, fPersonnel thisForm)
        {
            InitializeComponent();
            if (BarCode == 0)
            {
                t = new Person();
                barcode = t.barcode;
                Personnel.barcodes.Add(t.barcode, t);
            }
            else
            {
                barcode = BarCode;
                Personnel.barcodes.TryGetValue(BarCode, out t);
            }
            EAN8 toDraw = new EAN8(barcode.ToString());
            pbBarcode.Image = toDraw.CreateBarcodeBitmap(pbBarcode.Width, pbBarcode.Height);
            if (t.GetFIO().Split(' ').Length == 3)
            {
                tbLastName.Text = t.GetFIO().Split(' ')[0];
                tbName.Text = t.GetFIO().Split(' ')[1];
                tbFatherName.Text = t.GetFIO().Split(' ')[2];
            }
            else
                if (t.GetFIO().Split(' ').Length == 2)
            {
                tbLastName.Text = t.GetFIO().Split(' ')[0];
                tbName.Text = t.GetFIO().Split(' ')[1];
            }
            else
                if (t.GetFIO().Split(' ').Length == 1)
            {
                tbLastName.Text = t.GetFIO().Split(' ')[0];
            }

            f = thisForm;
        }

        private void fPerson_Load(object sender, EventArgs e)
        {
            EAN8 toDraw = new EAN8(barcode.ToString());
            pbBarcode.Image = toDraw.CreateBarcodeBitmap(pbBarcode.Width, pbBarcode.Height);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Personnel.barcodes.TryGetValue(barcode, out t))
            {
                t.SetFIO(tbLastName.Text + " " + tbName.Text + " " + tbFatherName.Text);
                Personnel.SavePersonnel();
            }
            
            this.Close();
            f.Refresh();
        }

        private void bPrintPass_Click(object sender, EventArgs e)
        {

            pdPrintPass.Document = pdPass;
            if (pdPrintPass.ShowDialog() == DialogResult.OK)
            {

                pdPass.PrinterSettings = pdPrintPass.PrinterSettings;
                pdPass.Print();
            }
            bSave_Click(sender, e);
        }

        private void pdPass_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 18, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawRectangle(Pens.Black, 40, 40, 250, 200);
            e.Graphics.DrawString(tbLastName.Text, myFont, Brushes.Black, new PointF(50, 50));
            myFont = new Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString(tbName.Text + tbFatherName.Text, myFont, Brushes.Black, new PointF(50, 70));
            e.Graphics.DrawImage(pbBarcode.Image, new Point(50, 90));
        }
    }
}
