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
    public partial class AVG6 : Form
    {
        public AVG6()
        {
            InitializeComponent();
        }

        private void AVG6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet.Доплаты". При необходимости она может быть перемещена или удалена.
            this.доплатыTableAdapter.Fill(this.отдел_кадровDataSet.Доплаты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main Main = new main();
            Main.Show();
            Hide();
        }
    }
}
