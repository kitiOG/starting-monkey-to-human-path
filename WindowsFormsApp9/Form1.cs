using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AVG aVG = new AVG();
            aVG.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AVG2 aVG2 = new AVG2();
            aVG2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AVG3 aVG3 = new AVG3();
            aVG3.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AVG4 aVG4 = new AVG4();
            aVG4.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AVG5 aVG5 = new AVG5();
            aVG5.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AVG6 aVG6 = new AVG6();
            aVG6.Show();
            Hide();
        }
    }
}
