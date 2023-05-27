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
    public partial class AVG5 : Form
    {
        public AVG5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main Main = new main();
            Main.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AVG5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet1.Зарплаты". При необходимости она может быть перемещена или удалена.
            this.зарплатыTableAdapter.Fill(this.отдел_кадровDataSet1.Зарплаты);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
