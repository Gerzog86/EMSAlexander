
namespace EMSAlexander
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSecondTick = new System.Windows.Forms.Timer(this.components);
            this.pDGV = new System.Windows.Forms.Panel();
            this.dgvActivityList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTop = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lDateTime = new System.Windows.Forms.Label();
            this.emsAlexanderDataSet1 = new EMSAlexander.EMSAlexanderDataSet();
            this.pDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityList)).BeginInit();
            this.pTop.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emsAlexanderDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tSecondTick
            // 
            this.tSecondTick.Enabled = true;
            this.tSecondTick.Interval = 1000;
            this.tSecondTick.Tick += new System.EventHandler(this.tSecondTick_Tick);
            // 
            // pDGV
            // 
            this.pDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDGV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDGV.Controls.Add(this.dgvActivityList);
            this.pDGV.Location = new System.Drawing.Point(0, 80);
            this.pDGV.Name = "pDGV";
            this.pDGV.Size = new System.Drawing.Size(800, 370);
            this.pDGV.TabIndex = 2;
            // 
            // dgvActivityList
            // 
            this.dgvActivityList.AllowUserToAddRows = false;
            this.dgvActivityList.AllowUserToDeleteRows = false;
            this.dgvActivityList.AllowUserToResizeColumns = false;
            this.dgvActivityList.AllowUserToResizeRows = false;
            this.dgvActivityList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActivityList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("a_FuturaRound", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("a_FuturaRound", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActivityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivityList.Location = new System.Drawing.Point(0, 0);
            this.dgvActivityList.Name = "dgvActivityList";
            this.dgvActivityList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("a_FuturaRound", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvActivityList.Size = new System.Drawing.Size(800, 370);
            this.dgvActivityList.TabIndex = 3;
            this.dgvActivityList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMain_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 62;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 97;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Организация";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 127;
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.msMain);
            this.pTop.Controls.Add(this.lDateTime);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(800, 74);
            this.pTop.TabIndex = 3;
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("a_FuturaRound", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMain});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            this.msMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMain_KeyPress);
            // 
            // tsmiMain
            // 
            this.tsmiMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonnel,
            this.tsmiSettings,
            this.toolStripMenuItem3,
            this.tsmiExit});
            this.tsmiMain.Name = "tsmiMain";
            this.tsmiMain.Size = new System.Drawing.Size(50, 20);
            this.tsmiMain.Text = "Файл";
            // 
            // tsmiPersonnel
            // 
            this.tsmiPersonnel.Name = "tsmiPersonnel";
            this.tsmiPersonnel.Size = new System.Drawing.Size(131, 22);
            this.tsmiPersonnel.Text = "Персонал";
            this.tsmiPersonnel.Click += new System.EventHandler(this.tsmiPersonnel_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(131, 22);
            this.tsmiSettings.Text = "Настройки";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(131, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lDateTime
            // 
            this.lDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDateTime.AutoSize = true;
            this.lDateTime.Font = new System.Drawing.Font("a_FuturaRound", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateTime.ForeColor = System.Drawing.Color.Red;
            this.lDateTime.Location = new System.Drawing.Point(582, 36);
            this.lDateTime.Name = "lDateTime";
            this.lDateTime.Size = new System.Drawing.Size(206, 22);
            this.lDateTime.TabIndex = 1;
            this.lDateTime.Text = "DateTime.Now.ToString()";
            // 
            // emsAlexanderDataSet1
            // 
            this.emsAlexanderDataSet1.DataSetName = "EMSAlexanderDataSet";
            this.emsAlexanderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pDGV);
            this.Name = "fMain";
            this.Text = "EMSAlexander";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMain_KeyPress);
            this.pDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityList)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emsAlexanderDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tSecondTick;
        private System.Windows.Forms.Panel pDGV;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lDateTime;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dgvActivityList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private EMSAlexanderDataSet emsAlexanderDataSet1;
    }
}

