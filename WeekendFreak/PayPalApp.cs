using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekendFreak
{
    public partial class PayPalApp : Form
    {
        public PayPalApp()
        {
            InitializeComponent();
        }

        int count = 0;

        private void FillList(int n, string line)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                    //listBox2.Items.Add(line);
                    if (list.Count == 1)
                    {
                        listBox2.Items.Add("<<bank-account number of the organization>>         " + line);
                        count++;
                    }
                    if (list.Count == 2)
                    {
                        listBox2.Items.Add("<<date and time of the start of this period>>        " + line);
                        count++;
                    }
                    if (list.Count == 3)
                    {
                        listBox2.Items.Add("<<date and time of the end of this period>>       " + line);
                        count++;
                    }
                    if (list.Count == 4)
                    {
                        listBox2.Items.Add("<<the number of deposits>>    " + line);
                        count++;
                    }
                    if (list.Count >= 5)
                    {
                        listBox2.Items.Add("<<information of a deposit: its unique identity number, a space an amount of money>>      " + line);
                        count++;
                    }
                    {

                    }
                }
            }
        }

        private void PayPalApp_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu MenuForm = new Menu();
            MenuForm.Show();
        }
    }
}

