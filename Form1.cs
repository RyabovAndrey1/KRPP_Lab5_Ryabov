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

namespace Lab5_KRPP_Ryabov
{
    public partial class Form1 : Form

    /* Дана точка на плоскости с координатами (х, у). Составить
программу, которая выдает одно из сообщений «Да», «Нет», «На границе» в
зависимости от того, лежит ли точка внутри области, вне области или на ее
границе.Области задаются радиусами окружностей (r1, r2).*/
    {
        double x, y, r1, r2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x) ||
                !double.TryParse(textBox2.Text, out double y) ||
                !double.TryParse(textBox3.Text, out double r1) ||
                !double.TryParse(textBox4.Text, out double r2))
            {
                MessageBox.Show("Введите корректные числа для x, y, r1 и r2.");
                return;
            }
            double distanceSquared = (x * x) + (y * y);
            if (distanceSquared > r1 * r1 && distanceSquared < r2 * r2)
            {
                Result.Text = "Точка попала в заштрихованную область";
            }
            else if (distanceSquared == r1 * r1 || distanceSquared == r2 * r2)
            {
                Result.Text = "Точка на границе заштрихованной области";
            }
            else
            {
                Result.Text = "Точка не попала в заштрихованную область";
            }
        }
    }
}


