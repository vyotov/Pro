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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(313, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 147);
            this.listBox1.TabIndex = 61;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbPrevRFIDTags
            // 
            this.lbPrevRFIDTags.FormattingEnabled = true;
            this.lbPrevRFIDTags.Location = new System.Drawing.Point(43, 73);
            this.lbPrevRFIDTags.Name = "lbPrevRFIDTags";
            this.lbPrevRFIDTags.Size = new System.Drawing.Size(230, 134);
            this.lbPrevRFIDTags.TabIndex = 58;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(172, 235);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 57;
            this.lblVersion.Text = "Version:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(43, 235);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(36, 13);
            this.lblSerial.TabIndex = 56;
            this.lblSerial.Text = "Serial:";
            // 
            // lblAttached
            // 
            this.lblAttached.AutoSize = true;
            this.lblAttached.Location = new System.Drawing.Point(40, 214);
            this.lblAttached.Name = "lblAttached";
            this.lblAttached.Size = new System.Drawing.Size(70, 13);
            this.lblAttached.TabIndex = 55;
            this.lblAttached.Text = "Not Attached";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(78, 44);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(130, 20);
            this.txtTag.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "TAG:";
            // 
            // cboxAntenna
            // 
            this.cboxAntenna.AutoSize = true;
            this.cboxAntenna.Location = new System.Drawing.Point(43, 19);
            this.cboxAntenna.Name = "cboxAntenna";
            this.cboxAntenna.Size = new System.Drawing.Size(103, 17);
            this.cboxAntenna.TabIndex = 52;
            this.cboxAntenna.Text = "Turn Reader On";
            this.cboxAntenna.UseVisualStyleBackColor = true;
            // 
            // EnteringApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 306);
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
    }
}