using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace EMSAlexander
{
    public partial class fPersonnel : Form
    {
        public fPersonnel()
        {
            InitializeComponent();
        }

        private void fPersonnel_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Employee> i in Personnel._personnel)
            {
                BarcodeLib.Barcode tempBarcode = new BarcodeLib.Barcode();
                dgvPersonnel.Rows.Add(i.Key, tempBarcode.Encode(TYPE.EAN8, i.Key, Color.Black, Color.Transparent, 300, 100), i.Value.GetLastName(), i.Value.GetFirstName(), i.Value.GetMiddleName(), i.Value.GetOrganisation());
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fEmployee EmployeeForm = new fEmployee("");
            EmployeeForm.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fEmployee EmployeeForm = new fEmployee(dgvPersonnel.CurrentRow.Cells[0].Value.ToString());
            EmployeeForm.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
