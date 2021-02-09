
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrganisationName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpInTime
            // 
            this.dtpInTime.CustomFormat = "HH:mm";
            this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInTime.Location = new System.Drawing.Point(263, 24);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.ShowUpDown = true;
            this.dtpInTime.Size = new System.Drawing.Size(201, 23);
            this.dtpInTime.TabIndex = 0;
            // 
            // lInTime
            // 
            this.lInTime.AutoSize = true;
            this.lInTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInTime.Location = new System.Drawing.Point(12, 24);
            this.lInTime.Name = "lInTime";
            this.lInTime.Size = new System.Drawing.Size(210, 21);
            this.lInTime.TabIndex = 1;
            this.lInTime.Text = "Время начала рабочего дня";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(485, 24);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(246, 22);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить настройки";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lOutTime
            // 
            this.lOutTime.AutoSize = true;
            this.lOutTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOutTime.Location = new System.Drawing.Point(12, 64);
            this.lOutTime.Name = "lOutTime";
            this.lOutTime.Size = new System.Drawing.Size(238, 21);
            this.lOutTime.TabIndex = 4;
            this.lOutTime.Text = "Время окончания рабочего дня";
            // 
            // dtpOutTime
            // 
            this.dtpOutTime.CustomFormat = "HH:mm";
            this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutTime.Location = new System.Drawing.Point(263, 64);
            this.dtpOutTime.Name = "dtpOutTime";
            this.dtpOutTime.ShowUpDown = true;
            this.dtpOutTime.Size = new System.Drawing.Size(201, 23);
            this.dtpOutTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название организации";
            // 
            // tbOrganisationName
            // 
            this.tbOrganisationName.Location = new System.Drawing.Point(263, 107);
            this.tbOrganisationName.Name = "tbOrganisationName";
            this.tbOrganisationName.Size = new System.Drawing.Size(201, 23);
            this.tbOrganisationName.TabIndex = 7;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.tbOrganisationName);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrganisationName;
    }
}