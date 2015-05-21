using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace WeekendFreak
{
    public partial class EnteringApp : Form
    {


        private DBConnection dbConnect;
        RFID rfid1;
        string lastRFIDTag;
        Int32 TagCtr;
        string RFIDvalue = "";
        int clientID = 0;


        public EnteringApp()
        {
            InitializeComponent();
            lastRFIDTag = "";
            TagCtr = 0;
            dbConnect = new DBConnection();
        }


        private void EnteringApp_Load(object sender, EventArgs e)
        {
            rfid1 = new RFID();
            rfid1.Attach += new AttachEventHandler(rfid_Attach);
            rfid1.Detach += new DetachEventHandler(rfid_Detach);
            rfid1.Tag += new TagEventHandler(rfid_Tag);
            rfid1.TagLost += new TagEventHandler(rfid_TagLost);
            rfid1.open();
            
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {

            MessageBox.Show("tag: " + e.Tag);

            txtTag.Text = e.Tag;

            lastRFIDTag = txtTag.Text;
            
            rfid1.LED = true;       // light on
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            txtTag.Text = "";
            rfid1.LED = false;      // light off
           // write held Tag ID to listview
            listBox1.Items.Insert(0,
                string.Format("                     Tag: {0} - {1}", ++TagCtr, lastRFIDTag));
            textBox1.Text = lastRFIDTag.ToString();
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            lblAttached.Text = "Not Attached";
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            Phidgets.RFID phid = (Phidgets.RFID)sender;
            lblAttached.Text = "Attached: " + phid.Name;
            lblSerial.Text = " Serial: " + phid.SerialNumber;
            lblVersion.Text = " Version: " + phid.Version;
        }

        private void antennaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Test: " + lastRFIDTag);
            List<string>[] list;
            list = dbConnect.SelectClient();
            int m = 2;


            for (int n = 0; n <= m; n++)
            {
                if (list[1][n] == lastRFIDTag)
                {
                    listBox1.Items.Add(list[2][n] + " " + list[3][n]);
                    clientID = Convert.ToInt32(list[0][n]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbConnect.UpdateInEvent(clientID);
            MessageBox.Show("Client is Activated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MenuForm = new Menu();
            MenuForm.Show();
        }

        
    }
}
