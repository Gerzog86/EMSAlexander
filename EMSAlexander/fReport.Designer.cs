
namespace EMSAlexander
{
    partial class fReport
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
            this.dtpMonthPicker = new System.Windows.Forms.DateTimePicker();
            this.bExportAndCalcMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpMonthPicker
            // 
            this.dtpMonthPicker.Location = new System.Drawing.Point(12, 12);
            this.dtpMonthPicker.Name = "dtpMonthPicker";
            this.dtpMonthPicker.Size = new System.Drawing.Size(161, 23);
            this.dtpMonthPicker.TabIndex = 0;
            // 
            // bExportAndCalcMonth
            // 
            this.bExportAndCalcMonth.Location = new System.Drawing.Point(179, 12);
            this.bExportAndCalcMonth.Name = "bExportAndCalcMonth";
            this.bExportAndCalcMonth.Size = new System.Drawing.Size(134, 23);
            this.bExportAndCalcMonth.TabIndex = 1;
            this.bExportAndCalcMonth.Text = "Экспорт и расчёт";
            this.bExportAndCalcMonth.UseVisualStyleBackColor = true;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 240);
            this.Controls.Add(this.bExportAndCalcMonth);
            this.Controls.Add(this.dtpMonthPicker);
            this.Name = "fReport";
            this.Text = "fReport";
            this.Load += new System.EventHandler(this.fReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMonthPicker;
        private System.Windows.Forms.Button bExportAndCalcMonth;
    }
}