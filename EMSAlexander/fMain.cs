using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            /*if (DateTime.Now.ToShortTimeString().Equals("23:58:00"))
            {
                ExportReport(Application.StartupPath, "Midnight" + DateTime.Now.ToShortDateString());
            }*/
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbBarcode;
            Personnel.LoadPersonnel();
            FileStream fs = new FileStream("Settings.stg", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Personnel.InTimeSetting = sr.ReadLine();
            Personnel.OutTimeSetting = sr.ReadLine();
            Personnel.OrganisationName = sr.ReadLine();
            sr.Close();
            fs.Close();
            //sfdExport.Filter = "Файл учёта рабочего времени | *.txt";
        }

        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Length == 8)
            {
                Person DatetimeSet = null;
                dgvVisitList.Rows.Add();
                dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[0].Value = Personnel.ReturnFIO(long.Parse(tbBarcode.Text));
                if (Personnel.IsOnWork(long.Parse(tbBarcode.Text)))
                {
                    dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[2].Value = DateTime.Now.ToShortTimeString();
                    Personnel.barcodes.TryGetValue(long.Parse(tbBarcode.Text), out DatetimeSet);
                    DatetimeSet.AddDate("out", DateTime.Now);
                    Personnel.ChangeWorkStatus(long.Parse(tbBarcode.Text));
                }
                else
                {
                    dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[1].Value = DateTime.Now.ToShortTimeString();
                    Personnel.barcodes.TryGetValue(long.Parse(tbBarcode.Text), out DatetimeSet);
                    DatetimeSet.AddDate("in", DateTime.Now);
                    Personnel.ChangeWorkStatus(long.Parse(tbBarcode.Text));
                }
                dgvVisitList.Rows[dgvVisitList.RowCount - 1].Cells[3].Value = DateTime.Now.ToShortDateString();
                tbBarcode.Clear();
            }
        }


        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.Control && e.KeyCode == Keys.E)
            {
                sfdExport.ShowDialog();
                ExportReport(sfdExport.FileName);
            }*/
            if (e.Control && e.KeyCode == Keys.E)
            {
                fReport ExportForm = new fReport();
                ExportForm.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                fSettings SettingsForm = new fSettings(this);
                SettingsForm.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                fPersonnel PersonnelForm = new fPersonnel(this);
                PersonnelForm.ShowDialog();
            }
        }

        private void ExportReport(string filename)
        {
            StreamWriter swExport = new StreamWriter(filename);
            foreach (DataGridViewRow row in dgvVisitList.Rows)
            {
                swExport.WriteLine(row.Cells[0].Value + "@@" + row.Cells[1].Value + "@@" + row.Cells[2].Value);
            }
            swExport.Close();
        }

        private void ExportReport(string directory, string filename)
        {
            ExportReport(directory + "\"" + filename);
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Personnel.SavePersonnel();
        }
    }
}
