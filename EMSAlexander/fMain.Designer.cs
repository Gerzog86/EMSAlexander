
namespace EMSAlexander
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvVisitList = new System.Windows.Forms.DataGridView();
            this.lCurrentTime = new System.Windows.Forms.Label();
            this.lCurrentDate = new System.Windows.Forms.Label();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.dgvtbcFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcComingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitList
            // 
            this.dgvVisitList.AllowUserToAddRows = false;
            this.dgvVisitList.AllowUserToDeleteRows = false;
            this.dgvVisitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcFIO,
            this.dgvtbcComingTime,
            this.dgvtbcDate});
            this.dgvVisitList.Location = new System.Drawing.Point(12, 42);
            this.dgvVisitList.Name = "dgvVisitList";
            this.dgvVisitList.ReadOnly = true;
            this.dgvVisitList.RowTemplate.Height = 25;
            this.dgvVisitList.Size = new System.Drawing.Size(548, 277);
            this.dgvVisitList.TabIndex = 0;
            // 
            // lCurrentTime
            // 
            this.lCurrentTime.AutoSize = true;
            this.lCurrentTime.Location = new System.Drawing.Point(471, 12);
            this.lCurrentTime.Name = "lCurrentTime";
            this.lCurrentTime.Size = new System.Drawing.Size(31, 15);
            this.lCurrentTime.TabIndex = 1;
            this.lCurrentTime.Text = "time";
            this.lCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lCurrentDate
            // 
            this.lCurrentDate.AutoSize = true;
            this.lCurrentDate.Location = new System.Drawing.Point(107, 12);
            this.lCurrentDate.Name = "lCurrentDate";
            this.lCurrentDate.Size = new System.Drawing.Size(30, 15);
            this.lCurrentDate.TabIndex = 2;
            this.lCurrentDate.Text = "date";
            this.lCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tTimer
            // 
            this.tTimer.Enabled = true;
            this.tTimer.Interval = 1000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(226, 9);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(159, 23);
            this.tbBarcode.TabIndex = 3;
            this.tbBarcode.TextChanged += new System.EventHandler(this.tbBarcode_TextChanged);
            // 
            // dgvtbcFIO
            // 
            this.dgvtbcFIO.HeaderText = "ФИО сотрудника";
            this.dgvtbcFIO.Name = "dgvtbcFIO";
            this.dgvtbcFIO.ReadOnly = true;
            this.dgvtbcFIO.Width = 350;
            // 
            // dgvtbcComingTime
            // 
            this.dgvtbcComingTime.HeaderText = "Время прихода";
            this.dgvtbcComingTime.Name = "dgvtbcComingTime";
            this.dgvtbcComingTime.ReadOnly = true;
            this.dgvtbcComingTime.Width = 75;
            // 
            // dgvtbcDate
            // 
            this.dgvtbcDate.HeaderText = "Дата";
            this.dgvtbcDate.Name = "dgvtbcDate";
            this.dgvtbcDate.ReadOnly = true;
            this.dgvtbcDate.Width = 75;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 331);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lCurrentDate);
            this.Controls.Add(this.lCurrentTime);
            this.Controls.Add(this.dgvVisitList);
            this.KeyPreview = true;
            this.Name = "fMain";
            this.Text = "EMS Alexander";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitList;
        private System.Windows.Forms.Label lCurrentTime;
        private System.Windows.Forms.Label lCurrentDate;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcComingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDate;
    }
}

