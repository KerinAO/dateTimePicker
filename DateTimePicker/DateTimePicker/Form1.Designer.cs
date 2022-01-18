namespace DateTimePicker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite datum leta:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite vrijeme leta:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(134, 28);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 2;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(134, 59);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijeme.TabIndex = 3;
            this.dtpVrijeme.UseWaitCursor = true;
            this.dtpVrijeme.Value = new System.DateTime(2022, 1, 18, 21, 50, 0, 0);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(34, 107);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(300, 132);
            this.txtIspis.TabIndex = 4;
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(146, 245);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(75, 23);
            this.btnRezervacija.TabIndex = 5;
            this.btnRezervacija.Text = "button1";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnRezervacija;
    }
}

