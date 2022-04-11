using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHristova7_1701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            double delivery = 0;
            if (comboBox1.Text == "Тениска")
            {
                if (rb_S.Checked)
                {
                    price += 17;
                }else if (rb_M.Checked)
                {
                    price += 19.90;
                }else if (rb_L.Checked)
                {
                    price += 21;
                }
            } else if (comboBox1.Text == "Пуловер")
            {
                if (rb_S.Checked)
                {
                    price += 12.50;
                }
                else if (rb_M.Checked)
                {
                    price += 13.50;
                }
                else if (rb_L.Checked)
                {
                    price += 14;
                }
            }
            else if (comboBox1.Text == "Дънки")
            {
                if (rb_S.Checked)
                {
                    price += 25;
                }
                else if (rb_M.Checked)
                {
                    price += 27.80;
                }
                else if (rb_L.Checked)
                {
                    price += 30;
                }
            }
            else if (comboBox1.Text == "Шорти")
            {
                if (rb_S.Checked)
                {
                    price += 6.70;
                }
                else if (rb_M.Checked)
                {
                    price += 8;
                }
                else if (rb_L.Checked)
                {
                    price += 9.50;
                }
            }
            else if (comboBox1.Text == "Яке")
            {
                if (rb_S.Checked)
                {
                    price += 85;
                }
                else if (rb_M.Checked)
                {
                    price += 86.90;
                }
                else if (rb_L.Checked)
                {
                    price += 88;
                }
            }
            if (rb_standart.Checked)
            {
                delivery += 4.50;
            }else if (rb_express.Checked)
            {
                delivery += 7.60;
            }

            label3.Text = $"{textBox1}, поръчахте {comboBox1.Text} - {} \n Обща сума: {(price + delivery):f2}";








        }
    }
}
