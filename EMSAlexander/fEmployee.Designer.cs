
namespace EMSAlexander
{
    partial class fEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrganisation = new System.Windows.Forms.TextBox();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAddDayOfWeek = new System.Windows.Forms.Button();
            this.cmsAddDayOfWeek = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMonday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuesday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWednesday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThursday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFriday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaturday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSunday = new System.Windows.Forms.ToolStripMenuItem();
            this.bDeleteDayOfWeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.cmsAddDayOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.bSave.Location = new System.Drawing.Point(305, 307);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(268, 31);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Значение штрих-кода";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.tbBarcode.Location = new System.Drawing.Point(6, 34);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.ReadOnly = true;
            this.tbBarcode.Size = new System.Drawing.Size(268, 31);
            this.tbBarcode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фамилия";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.tbLastName.Location = new System.Drawing.Point(6, 93);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(268, 31);
            this.tbLastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Имя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.tbFirstName.Location = new System.Drawing.Point(6, 152);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(268, 31);
            this.tbFirstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Отчество";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.tbMiddleName.Location = new System.Drawing.Point(6, 211);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(268, 31);
            this.tbMiddleName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Организация";
            // 
            // tbOrganisation
            // 
            this.tbOrganisation.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.tbOrganisation.Location = new System.Drawing.Point(6, 270);
            this.tbOrganisation.Name = "tbOrganisation";
            this.tbOrganisation.Size = new System.Drawing.Size(268, 31);
            this.tbOrganisation.TabIndex = 4;
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(6, 307);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(268, 131);
            this.pbBarcode.TabIndex = 25;
            this.pbBarcode.TabStop = false;
            // 
            // bPrint
            // 
            this.bPrint.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.bPrint.Location = new System.Drawing.Point(305, 344);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(268, 31);
            this.bPrint.TabIndex = 32;
            this.bPrint.Text = "Печать пропуска";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.bCancel.Location = new System.Drawing.Point(305, 381);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(268, 31);
            this.bCancel.TabIndex = 33;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeColumns = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSchedule.Location = new System.Drawing.Point(305, 34);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(354, 267);
            this.dgvSchedule.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "День недели";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Начало рабочего дня";
            this.Column2.Name = "Column2";
            this.Column2.Width = 111;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Конец рабочего дня";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // bAddDayOfWeek
            // 
            this.bAddDayOfWeek.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.bAddDayOfWeek.Location = new System.Drawing.Point(665, 34);
            this.bAddDayOfWeek.Name = "bAddDayOfWeek";
            this.bAddDayOfWeek.Size = new System.Drawing.Size(132, 31);
            this.bAddDayOfWeek.TabIndex = 35;
            this.bAddDayOfWeek.Text = "Добавить ↓";
            this.bAddDayOfWeek.UseVisualStyleBackColor = true;
            this.bAddDayOfWeek.Click += new System.EventHandler(this.bAddDayOfWeek_Click);
            // 
            // cmsAddDayOfWeek
            // 
            this.cmsAddDayOfWeek.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMonday,
            this.tsmiTuesday,
            this.tsmiWednesday,
            this.tsmiThursday,
            this.tsmiFriday,
            this.tsmiSaturday,
            this.tsmiSunday});
            this.cmsAddDayOfWeek.Name = "cmsAddDayOfWeek";
            this.cmsAddDayOfWeek.Size = new System.Drawing.Size(149, 158);
            // 
            // tsmiMonday
            // 
            this.tsmiMonday.Name = "tsmiMonday";
            this.tsmiMonday.Size = new System.Drawing.Size(148, 22);
            this.tsmiMonday.Tag = "1";
            this.tsmiMonday.Text = "Понедельник";
            this.tsmiMonday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiTuesday
            // 
            this.tsmiTuesday.Name = "tsmiTuesday";
            this.tsmiTuesday.Size = new System.Drawing.Size(148, 22);
            this.tsmiTuesday.Tag = "2";
            this.tsmiTuesday.Text = "Вторник";
            this.tsmiTuesday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiWednesday
            // 
            this.tsmiWednesday.Name = "tsmiWednesday";
            this.tsmiWednesday.Size = new System.Drawing.Size(148, 22);
            this.tsmiWednesday.Tag = "3";
            this.tsmiWednesday.Text = "Среда";
            this.tsmiWednesday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiThursday
            // 
            this.tsmiThursday.Name = "tsmiThursday";
            this.tsmiThursday.Size = new System.Drawing.Size(148, 22);
            this.tsmiThursday.Tag = "4";
            this.tsmiThursday.Text = "Четверг";
            this.tsmiThursday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiFriday
            // 
            this.tsmiFriday.Name = "tsmiFriday";
            this.tsmiFriday.Size = new System.Drawing.Size(148, 22);
            this.tsmiFriday.Tag = "5";
            this.tsmiFriday.Text = "Пятница";
            this.tsmiFriday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiSaturday
            // 
            this.tsmiSaturday.Name = "tsmiSaturday";
            this.tsmiSaturday.Size = new System.Drawing.Size(148, 22);
            this.tsmiSaturday.Tag = "6";
            this.tsmiSaturday.Text = "Суббота";
            this.tsmiSaturday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiSunday
            // 
            this.tsmiSunday.Name = "tsmiSunday";
            this.tsmiSunday.Size = new System.Drawing.Size(148, 22);
            this.tsmiSunday.Tag = "7";
            this.tsmiSunday.Text = "Воскресенье";
            this.tsmiSunday.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bDeleteDayOfWeek
            // 
            this.bDeleteDayOfWeek.Font = new System.Drawing.Font("a_FuturaRound", 14.25F);
            this.bDeleteDayOfWeek.Location = new System.Drawing.Point(665, 71);
            this.bDeleteDayOfWeek.Name = "bDeleteDayOfWeek";
            this.bDeleteDayOfWeek.Size = new System.Drawing.Size(132, 31);
            this.bDeleteDayOfWeek.TabIndex = 36;
            this.bDeleteDayOfWeek.Text = "Удалить";
            this.bDeleteDayOfWeek.UseVisualStyleBackColor = true;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.bDeleteDayOfWeek);
            this.Controls.Add(this.bAddDayOfWeek);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOrganisation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.Load += new System.EventHandler(this.fEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.cmsAddDayOfWeek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrganisation;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bAddDayOfWeek;
        private System.Windows.Forms.ContextMenuStrip cmsAddDayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonday;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuesday;
        private System.Windows.Forms.ToolStripMenuItem tsmiWednesday;
        private System.Windows.Forms.ToolStripMenuItem tsmiThursday;
        private System.Windows.Forms.ToolStripMenuItem tsmiFriday;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaturday;
        private System.Windows.Forms.ToolStripMenuItem tsmiSunday;
        private System.Windows.Forms.Button bDeleteDayOfWeek;
    }
}