namespace WeekendFreak
{
    partial class EnteringApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblAttached = new System.Windows.Forms.Label();
            this.cboxAntenna = new System.Windows.Forms.CheckBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Visitor Information:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button6.Location = new System.Drawing.Point(229, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 37);
            this.button6.TabIndex = 87;
            this.button6.Text = "Check In";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 173);
            this.listBox1.TabIndex = 86;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 85;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button7.Location = new System.Drawing.Point(229, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 35);
            this.button7.TabIndex = 84;
            this.button7.Text = "Scan";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(144, 289);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 82;
            this.lblVersion.Text = "Version:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(15, 289);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(36, 13);
            this.lblSerial.TabIndex = 81;
            this.lblSerial.Text = "Serial:";
            // 
            // lblAttached
            // 
            this.lblAttached.AutoSize = true;
            this.lblAttached.Location = new System.Drawing.Point(12, 268);
            this.lblAttached.Name = "lblAttached";
            this.lblAttached.Size = new System.Drawing.Size(70, 13);
            this.lblAttached.TabIndex = 80;
            this.lblAttached.Text = "Not Attached";
            // 
            // cboxAntenna
            // 
            this.cboxAntenna.AutoSize = true;
            this.cboxAntenna.Location = new System.Drawing.Point(12, 239);
            this.cboxAntenna.Name = "cboxAntenna";
            this.cboxAntenna.Size = new System.Drawing.Size(103, 17);
            this.cboxAntenna.TabIndex = 77;
            this.cboxAntenna.Text = "Turn Reader On";
            this.cboxAntenna.UseVisualStyleBackColor = true;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(564, 137);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(130, 20);
            this.txtTag.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 46);
            this.button1.TabIndex = 90;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnteringApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblAttached);
            this.Controls.Add(this.cboxAntenna);
            this.Name = "EnteringApp";
            this.Text = "EnteringApp";
            this.Load += new System.EventHandler(this.EnteringApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblAttached;
        private System.Windows.Forms.CheckBox cboxAntenna;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button button1;
    }
}