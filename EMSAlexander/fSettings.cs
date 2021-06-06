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
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbServerName.Text)) && !(String.IsNullOrEmpty(tbPort.Text)) && !(String.IsNullOrEmpty(tbDatabaseName.Text)) && !(String.IsNullOrEmpty(tbUserName.Text)))
            {
                FileStream fs = new FileStream("Settings.stg", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"{tbServerName.Text}\r{tbPort.Text}\r{tbDatabaseName.Text}\r{tbUserName.Text}\r{tbPassword.Text}\r");
                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Введены не все данные", "Ошибка!", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            if (Settings.Initialize())
            {
                tbServerName.Text = Settings._serverAdress;
                tbPort.Text = Settings._port;
                tbDatabaseName.Text = Settings._databaseName;
                tbUserName.Text = Settings._username;
                tbPassword.Text = Settings._password;
            }
        }
    }
}
