namespace Currency_Conventer___ETS_PBKK
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.convertBtn = new System.Windows.Forms.Button();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Currency";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(137, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY CONVENTER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.convertBtn);
            this.panel1.Controls.Add(this.cmbToCurrency);
            this.panel1.Controls.Add(this.cmbFromCurrency);
            this.panel1.Controls.Add(this.txtToCurrency);
            this.panel1.Controls.Add(this.txtFromCurrency);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 270);
            this.panel1.TabIndex = 3;
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.convertBtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.convertBtn.Location = new System.Drawing.Point(191, 205);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(112, 34);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(250, 147);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(249, 33);
            this.cmbToCurrency.TabIndex = 5;
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(250, 62);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(249, 33);
            this.cmbFromCurrency.TabIndex = 4;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.txtToCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToCurrency.Location = new System.Drawing.Point(22, 149);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.PlaceholderText = "Input Number";
            this.txtToCurrency.Size = new System.Drawing.Size(204, 31);
            this.txtToCurrency.TabIndex = 3;
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.txtFromCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromCurrency.Location = new System.Drawing.Point(22, 62);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.PlaceholderText = "Input Number";
            this.txtFromCurrency.Size = new System.Drawing.Size(204, 31);
            this.txtFromCurrency.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "To Currency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(638, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button convertBtn;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtToCurrency;
        private TextBox txtFromCurrency;
        private Label label3;
        private ComboBox cmbToCurrency;
        private ComboBox cmbFromCurrency;
    }
}