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
    public partial class fEmployee : Form
    {

        private string _barcode;
        private Barcode EAN8;
        private Schedule[] _worktimes;
        public fEmployee(string barcode)
        {
            InitializeComponent();
            _barcode = barcode;
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            dgvSchedule.Columns[0].ReadOnly = true;
            if (!(Personnel._personnel.ContainsKey(_barcode)))
            {
                _barcode = Generate();
                tbBarcode.Text = _barcode;
            }
            else
            {
                Employee temp = new Employee();
                tbBarcode.Text = _barcode;
                Personnel._personnel.TryGetValue(_barcode, out temp);
                tbLastName.Text = temp.GetLastName();
                tbFirstName.Text = temp.GetFirstName();
                tbMiddleName.Text = temp.GetMiddleName();
                tbOrganisation.Text = temp.GetOrganisation();
                _worktimes = temp.GetWorkTimes();
                if (_worktimes != null)
                {
                    for (int i = 0; i < _worktimes.Length; i++)
                    {
                        dgvSchedule.Rows.Add(DayOfWeekRus.IntToDay(_worktimes[i]._day), _worktimes[i]._intime, _worktimes[i]._outtime);
                    }
                }
            }
            EAN8 = new Barcode();
            pbBarcode.Image = EAN8.Encode(TYPE.EAN8, _barcode, Color.Black, Color.Transparent, pbBarcode.Width, pbBarcode.Height);
        }

        private string Generate()
        {
            Random rand = new Random();
            string temp = rand.Next(1000000, 9999999).ToString();
            temp += (10 - ((((int)temp[0] + (int)temp[2] + (int)temp[4] + (int)temp[6]) * 3) + ((int)temp[1] + (int)temp[3] + (int)temp[5])) % 10).ToString();
            if (Personnel._personnel.ContainsKey(temp))
            {
                temp = Generate();
            }
            return temp;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAddDayOfWeek_Click(object sender, EventArgs e)
        {
            cmsAddDayOfWeek.Show(new Point(bAddDayOfWeek.Location.X + bAddDayOfWeek.Width, bAddDayOfWeek.Location.Y + bAddDayOfWeek.Height), ToolStripDropDownDirection.BelowLeft);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbBarcode.Text)) && !(String.IsNullOrEmpty(tbBarcode.Text)) && !(String.IsNullOrEmpty(tbBarcode.Text)) && !(String.IsNullOrEmpty(tbBarcode.Text)) && !(String.IsNullOrEmpty(tbBarcode.Text)))
            {
                Personnel.TryAddField(tbBarcode.Text, tbLastName.Text, tbFirstName.Text, tbMiddleName.Text, tbOrganisation.Text, ConvertTable());

                this.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка!");
            }
        }
        private Schedule[] ConvertTable()
        {
            Schedule[] toReturn = new Schedule[dgvSchedule.RowCount];
            for (int i = 0; i < dgvSchedule.RowCount; i++)
            {
                toReturn[i] = new Schedule(DayOfWeekRus.DayToInt(dgvSchedule.Rows[i].Cells[0].Value.ToString()), dgvSchedule.Rows[i].Cells[1].Value.ToString(), dgvSchedule.Rows[i].Cells[2].Value.ToString());
            }
            return toReturn;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sender == tsmiMonday)
            {
                AddDayOfWeek(0);
            }
            if (sender == tsmiTuesday)
            {
                AddDayOfWeek(1);
            }
            if (sender ==tsmiWednesday)
            {
                AddDayOfWeek(2);
            }
            if (sender == tsmiThursday)
            {
                AddDayOfWeek(3);
            }
            if (sender == tsmiFriday)
            {
                AddDayOfWeek(4);
            }
            if (sender == tsmiSaturday)
            {
                AddDayOfWeek(5);
            }
            if (sender == tsmiSunday)
            {
                AddDayOfWeek(6);
            }
        }

        private void AddDayOfWeek (int dayNumber)
        {
            dgvSchedule.Rows.Add(DayOfWeekRus.IntToDay(dayNumber), DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortTimeString()); ;
        }
    }
}
