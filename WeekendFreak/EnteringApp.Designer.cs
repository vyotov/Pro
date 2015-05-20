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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPrevRFIDTags = new System.Windows.Forms.ListBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblAttached = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxAntenna = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 173);
            this.listBox1.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPrevRFIDTags
            // 
            this.lbPrevRFIDTags.FormattingEnabled = true;
            this.lbPrevRFIDTags.Location = new System.Drawing.Point(849, 71);
            this.lbPrevRFIDTags.Name = "lbPrevRFIDTags";
            this.lbPrevRFIDTags.Size = new System.Drawing.Size(230, 134);
            this.lbPrevRFIDTags.TabIndex = 58;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(978, 233);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 57;
            this.lblVersion.Text = "Version:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(849, 233);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(36, 13);
            this.lblSerial.TabIndex = 56;
            this.lblSerial.Text = "Serial:";
            // 
            // lblAttached
            // 
            this.lblAttached.AutoSize = true;
            this.lblAttached.Location = new System.Drawing.Point(846, 212);
            this.lblAttached.Name = "lblAttached";
            this.lblAttached.Size = new System.Drawing.Size(70, 13);
            this.lblAttached.TabIndex = 55;
            this.lblAttached.Text = "Not Attached";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(884, 42);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(130, 20);
            this.txtTag.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "TAG:";
            // 
            // cboxAntenna
            // 
            this.cboxAntenna.AutoSize = true;
            this.cboxAntenna.Location = new System.Drawing.Point(849, 17);
            this.cboxAntenna.Name = "cboxAntenna";
            this.cboxAntenna.Size = new System.Drawing.Size(103, 17);
            this.cboxAntenna.TabIndex = 52;
            this.cboxAntenna.Text = "Turn Reader On";
            this.cboxAntenna.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Activate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Visitor Information:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EnteringApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPrevRFIDTags);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblAttached);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxAntenna);
            this.Name = "EnteringApp";
            this.Text = "EnteringApp";
            this.Load += new System.EventHandler(this.EnteringApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbPrevRFIDTags;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblAttached;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboxAntenna;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}