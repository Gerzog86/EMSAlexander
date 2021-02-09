
namespace EMSAlexander
{
    partial class fPersonnel
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.dgvtbcFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcSthrih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAddPersonnel = new System.Windows.Forms.Button();
            this.bEditPersonnel = new System.Windows.Forms.Button();
            this.bDeletePersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcFIO,
            this.dgvtbcSthrih});
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowTemplate.Height = 25;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(495, 420);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // dgvtbcFIO
            // 
            this.dgvtbcFIO.HeaderText = "ФИО сотрудника";
            this.dgvtbcFIO.Name = "dgvtbcFIO";
            this.dgvtbcFIO.ReadOnly = true;
            this.dgvtbcFIO.Width = 300;
            // 
            // dgvtbcSthrih
            // 
            this.dgvtbcSthrih.HeaderText = "Штрих-код";
            this.dgvtbcSthrih.Name = "dgvtbcSthrih";
            this.dgvtbcSthrih.ReadOnly = true;
            this.dgvtbcSthrih.Width = 150;
            // 
            // bAddPersonnel
            // 
            this.bAddPersonnel.Location = new System.Drawing.Point(513, 12);
            this.bAddPersonnel.Name = "bAddPersonnel";
            this.bAddPersonnel.Size = new System.Drawing.Size(125, 38);
            this.bAddPersonnel.TabIndex = 1;
            this.bAddPersonnel.Text = "Добавить сотрудника";
            this.bAddPersonnel.UseVisualStyleBackColor = true;
            this.bAddPersonnel.Click += new System.EventHandler(this.bAddPersonnel_Click);
            // 
            // bEditPersonnel
            // 
            this.bEditPersonnel.Location = new System.Drawing.Point(513, 56);
            this.bEditPersonnel.Name = "bEditPersonnel";
            this.bEditPersonnel.Size = new System.Drawing.Size(125, 38);
            this.bEditPersonnel.TabIndex = 2;
            this.bEditPersonnel.Text = "Редактировать сотрудника";
            this.bEditPersonnel.UseVisualStyleBackColor = true;
            this.bEditPersonnel.Click += new System.EventHandler(this.bEditPersonnel_Click);
            // 
            // bDeletePersonnel
            // 
            this.bDeletePersonnel.Location = new System.Drawing.Point(513, 100);
            this.bDeletePersonnel.Name = "bDeletePersonnel";
            this.bDeletePersonnel.Size = new System.Drawing.Size(125, 38);
            this.bDeletePersonnel.TabIndex = 3;
            this.bDeletePersonnel.Text = "Удалить сотрудника";
            this.bDeletePersonnel.UseVisualStyleBackColor = true;
            // 
            // fPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.bDeletePersonnel);
            this.Controls.Add(this.bEditPersonnel);
            this.Controls.Add(this.bAddPersonnel);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "fPersonnel";
            this.Text = "fPersonnel";
            this.Load += new System.EventHandler(this.fPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSthrih;
        private System.Windows.Forms.Button bAddPersonnel;
        private System.Windows.Forms.Button bEditPersonnel;
        private System.Windows.Forms.Button bDeletePersonnel;
    }
}