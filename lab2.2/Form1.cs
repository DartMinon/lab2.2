using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            if (!int.TryParse(textBox1.Text, out j))
            {
                MessageBox.Show("Введено не числовое значение");
                return;
            }
            if (j < 0)
            {
                MessageBox.Show("Введите значение >= 0");
                return;
            }

            int qq;
            StringBuilder binary = new StringBuilder();
            do
            {
                qq = j % 2;
                j = j / 2;
                binary.Insert(0,qq);
            } while (j > 0);
            label2.Text = binary.ToString();
        }

    }
}
