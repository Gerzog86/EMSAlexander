using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EMSAlexander
{
    public partial class fPersonnel : Form
    {
        public fPersonnel()
        {
            InitializeComponent();
        }

        public fPersonnel(fMain fMain)
        {
            InitializeComponent();
        }

        private void fPersonnel_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void bAddPersonnel_Click(object sender, EventArgs e)
        {
            fPerson PersonForm = new fPerson(0, this);
            PersonForm.ShowDialog();
        }

        private void bEditPersonnel_Click(object sender, EventArgs e)
        {
            fPerson PersonForm = new fPerson(long.Parse(dgvPersonnel.SelectedRows[0].Cells[1].Value.ToString()), this);
            PersonForm.ShowDialog();
        }

        public void Refresh()
        {
            dgvPersonnel.Rows.Clear();
            foreach (var i in Personnel.barcodes)
            {
                dgvPersonnel.Rows.Add(i.Value.GetFIO(), i.Key);
            }
        }
    }
}
