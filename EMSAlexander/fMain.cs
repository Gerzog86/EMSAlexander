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

        public string _barcode;
        public fMain()
        {
            InitializeComponent();
            while (!(Settings.Initialize()))
            {
                MessageBox.Show("Произошла ошибка доступа к SQL-серверу. Обновите настройки программы или перезапустите её.", "Ошибка!");
                fSettings SettingsForm = new fSettings();
                SettingsForm.ShowDialog();
            }
            Personnel.Initialize(Settings._connectionstring);
        }

        private void tSecondTick_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {

            // record keystroke
            _barcode += e.KeyChar;
            // process barcode
            if (_barcode.Length == 8)
            {
                MessageBox.Show(_barcode);
                _barcode = "";
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
            /*foreach (KeyValuePair<string, Employee> i in Personnel._personnel)
            {
                dgvActivityList.Rows.Insert(0, i.Value.GetLastName(), i.Value.GetFirstName(), i.Value.GetMiddleName(), i.Value.GetOrganisation());
            }*/
        }

        private void tsmiPersonnel_Click(object sender, EventArgs e)
        {
            fPersonnel PersonnelForm = new fPersonnel();
            PersonnelForm.ShowDialog();
            PersonnelForm.Dispose();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            fSettings SettingsForm = new fSettings();
            SettingsForm.ShowDialog();
            SettingsForm.Dispose();
        }
    }
}
