
namespace EMSAlexander
{
    partial class fSettings
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
            this.dtpInTime = new System.Windows.Forms.DateTimePicker();
            this.lInTime = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.lOutTime = new System.Windows.Forms.Label();
            this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpInTime
            // 
            this.dtpInTime.Location = new System.Drawing.Point(263, 24);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.Size = new System.Drawing.Size(201, 23);
            this.dtpInTime.TabIndex = 0;
            // 
            // lInTime
            // 
            this.lInTime.AutoSize = true;
            this.lInTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInTime.Location = new System.Drawing.Point(12, 24);
            this.lInTime.Name = "lInTime";
            this.lInTime.Size = new System.Drawing.Size(194, 21);
            this.lInTime.TabIndex = 1;
            this.lInTime.Text = "Время прихода на работу";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(485, 24);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(246, 22);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить настройки";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // lOutTime
            // 
            this.lOutTime.AutoSize = true;
            this.lOutTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOutTime.Location = new System.Drawing.Point(12, 64);
            this.lOutTime.Name = "lOutTime";
            this.lOutTime.Size = new System.Drawing.Size(175, 21);
            this.lOutTime.TabIndex = 4;
            this.lOutTime.Text = "Время ухода на работу";
            // 
            // dtpOutTime
            // 
            this.dtpOutTime.Location = new System.Drawing.Point(263, 64);
            this.dtpOutTime.Name = "dtpOutTime";
            this.dtpOutTime.Size = new System.Drawing.Size(201, 23);
            this.dtpOutTime.TabIndex = 3;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.lOutTime);
            this.Controls.Add(this.dtpOutTime);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lInTime);
            this.Controls.Add(this.dtpInTime);
            this.Name = "fSettings";
            this.Text = "fSettings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInTime;
        private System.Windows.Forms.Label lInTime;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lOutTime;
        private System.Windows.Forms.DateTimePicker dtpOutTime;
    }
}