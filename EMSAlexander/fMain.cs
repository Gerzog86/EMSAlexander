using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSAlexander
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void tTimer_Tick(object sender, EventArgs e)
        {
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            lCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbBarcode;
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Length == 8)
            {
                dgvVisitList.Rows.Add();
                dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[0].Value = Personnel.ReturnFIO(Int64.Parse(tbBarcode.Text));
                dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[1].Value = DateTime.Now.ToShortTimeString();
                tbBarcode.Clear();
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                sfdExport.ShowDialog();
            }
        }
    }
}
