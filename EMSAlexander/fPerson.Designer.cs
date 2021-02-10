
namespace EMSAlexander
{
    partial class fPerson
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
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFatherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.bPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(224, 12);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(264, 23);
            this.tbLastName.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(224, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 23);
            this.tbName.TabIndex = 1;
            // 
            // tbFatherName
            // 
            this.tbFatherName.Location = new System.Drawing.Point(224, 70);
            this.tbFatherName.Name = "tbFatherName";
            this.tbFatherName.Size = new System.Drawing.Size(264, 23);
            this.tbFatherName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(515, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(150, 23);
            this.bSave.TabIndex = 6;
            this.bSave.TabStop = false;
            this.bSave.Text = "Сохранить изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(224, 99);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(264, 131);
            this.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBarcode.TabIndex = 7;
            this.pbBarcode.TabStop = false;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(515, 41);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(150, 23);
            this.bPrint.TabIndex = 8;
            this.bPrint.TabStop = false;
            this.bPrint.Text = "Печать пропуска";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // fPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFatherName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLastName);
            this.Name = "fPerson";
            this.Text = "fPerson";
            this.Load += new System.EventHandler(this.fPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFatherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Button bPrint;
    }
}