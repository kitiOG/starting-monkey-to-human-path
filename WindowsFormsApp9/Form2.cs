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
    public partial class AVG : Form
    {
        public AVG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main Main = new main();
            Main.Show();
            Hide();
        }

        private void AVG_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet5.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.отдел_кадровDataSet5.Должности);

        }
    }
}
