using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy_1._0
{
    public partial class Form9 : Form
    {
        public Form1 forms1;
        public Form2 forms2;
        public Form3 forms3;
        public Form4 forms4;
        public Form5 forms5;
        public Form6 forms6;
        public Form7 forms7;
        public Form8 forms8;
        public Form9 forms9;

        int minutes = 30;
        int seconds = 0;
        Timer timer = new Timer();


        public Form9()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    timer.Stop();
                    MessageBox.Show("Time's up!");
                    forms1.Close();
                    forms2.Close();
                    forms3.Close();
                    forms4.Close();
                    forms5.Close();
                    forms6.Close();
                    forms7.Close();
                    forms8.Close();
                    forms9.Close();

                }
                else
                {
                    minutes--;
                    seconds = 59;
                }
            }
            else
            {
                seconds--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
