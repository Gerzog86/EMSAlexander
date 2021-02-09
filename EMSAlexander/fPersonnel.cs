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
            foreach (var i in Personnel.barcodes)
            {
                dgvPersonnel.Rows.Add(i.Value.GetFIO(), i.Key);
            }
        }

        private void bAddPersonnel_Click(object sender, EventArgs e)
        {
            //Тестовый код для проверки генерации штрих-кодов EAN8
            fPerson PersonForm = new fPerson(1000001);
            PersonForm.ShowDialog();
        }

        private void bEditPersonnel_Click(object sender, EventArgs e)
        {
            fPerson PersonForm = new fPerson(long.Parse(dgvPersonnel.SelectedRows[0].Cells[1].Value.ToString()));
            PersonForm.ShowDialog();
        }
    }
}
