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

        }

        private void bAddPersonnel_Click(object sender, EventArgs e)
        {
            //Тестовый код для проверки генерации штрих-кодов EAN8
            fPerson PersonForm = new fPerson(1000001);
            PersonForm.ShowDialog();
        }
    }
}
