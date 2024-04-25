using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbName, "Введите данные");
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(tbNumber, "Введите данные");
        }

        private void tbOpis_TextChanged(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(tbOpis, "Введите данные");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            //fr2.tbName1.Text = tbName.Text;
            //fr2.tbNumber1
            fr2.Txt = this.tbName.Text;
            fr2.Txt1 = this.tbNumber.Text;
            fr2.Txt2 = this.tbOpis.Text;
            fr2.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
