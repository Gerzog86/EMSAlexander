﻿using System;
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
    }
}
