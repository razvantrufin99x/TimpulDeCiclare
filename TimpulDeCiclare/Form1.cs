using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimpulDeCiclare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime starttime = DateTime.Now;
            DateTime endtime;

            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                Text = i.ToString();
                this.Refresh();
            }
            endtime = DateTime.Now;

            int ms = endtime.Millisecond - starttime.Millisecond;
            int s = endtime.Second - starttime.Second;
            int min = endtime.Minute - starttime.Minute;
            int h = endtime.Hour - starttime.Hour;
            int d = endtime.Day - starttime.Day;

            textBox2.Text = d.ToString();
            textBox2.Text += ":";

            textBox2.Text += h.ToString();
            textBox2.Text += ":";

            textBox2.Text += min.ToString();
            textBox2.Text += ":";

            textBox2.Text += s.ToString();
            textBox2.Text += ":";

            textBox2.Text += ms.ToString();
            textBox2.Text += "";

            TimeSpan ts = (endtime - starttime);
            textBox3.Text = ts.ToString();


        }
    }
}
