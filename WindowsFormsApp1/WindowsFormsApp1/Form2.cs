using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public string Txt
        {
            get { return tbName1.Text; }
            set { tbName1.Text = value; }
        }
        public string Txt1
        {
            get { return tbNomber1.Text; }
            set { tbNomber1.Text = value; }
        }
        public string Txt2
        {
            get { return tbOpis1.Text; }
            set { tbOpis1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        public async void CalculateSum()
        {
            ErrorProvider errorProvider = new ErrorProvider();

            //int Sum = class1.Calculate();
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider.SetError(textBox4, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox4, "");
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider.SetError(textBox5, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox5, "");
            }
            else if (Int32.TryParse(textBox4.Text, out int Num1))
            {
                if (Num1 < 0 || Num1 == 0)
                {
                    errorProvider.SetError(textBox4, "Введите положительное число больше нуля");
                    await Task.Delay(1500); // Задержка в 3 секунды
                    errorProvider.SetError(textBox4, "");
                }

                if (Int32.TryParse(textBox5.Text, out int Num2))
                {
                    if (Num2 < 0 || Num2 == 0)
                    {
                        errorProvider.SetError(textBox5, "Введите положительное число больше нуля");
                        await Task.Delay(1500); // Задержка в 3 секунды
                        errorProvider.SetError(textBox5, "");
                    }
                    else
                    {
                        Class1 class1 = new Class1(Num1, Num2);
                        class1.Num1Num2(Num1, Num2);
                        int Sum = class1.Calculate();
                        textBox6.Text = $"{Sum}";
                    }
                }
                else
                {
                    errorProvider.SetError(textBox5, "Введите целое число");
                    await Task.Delay(1500); // Задержка в 3 секунды
                    errorProvider.SetError(textBox5, "");
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void tbName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        public void tbNomber1_TextChanged(object sender, EventArgs e)
        {

        }

        public void tbOpis1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateSum();
        }
    }
}
