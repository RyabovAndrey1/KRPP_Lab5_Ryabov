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

        /* Задание 1. Дана точка на плоскости с координатами (х, у). Составить
    программу, которая выдает одно из сообщений «Да», «Нет», «На границе» в
    зависимости от того, лежит ли точка внутри области, вне области или на ее
    границе.Области задаются радиусами окружностей (r1, r2).*/
       /*Задание 2. Написать приложения для расчета значения уравнений.
        Предусмотреть решение уравнений одновременно на одних и тех же входных
    данных.*/
    {
        double x, y, r1, r2, x1, x2, x3, y1,y2, y3, eqx;

        private void button3_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox11.Text, out double eqx))
                {
                MessageBox.Show("Введите корректные числа для eqx");
                return;
            }
            x1 = eqx;
            x2 = eqx;
            x3 = eqx;
            textBox5.Text = Convert.ToString(x1);
            textBox6.Text = Convert.ToString(x2);
            textBox7.Text = Convert.ToString(x3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox5.Text, out double x1) ||
                !double.TryParse(textBox6.Text, out double x2) ||
                !double.TryParse(textBox7.Text, out double x3)) 
            {
                MessageBox.Show("Введите корректные числа для x1, x2, x3.");
                return; 
            }
            try
            {
                y1 = ((2.0 * x1 - 7.0) / (Math.Sqrt(3.0 * x1 + 21.0)));
                if (x2 != 1)  
                {
                    y2 = Math.Sqrt(x2 / (x2 - 1));
                }
                else
                {
                    throw new Exception("Деление на 0 невозможно! Измените значение x2.");
                }

                
                if (x3 != 1) 
                {
                    y3 = (((x3 + 1) / (x3 - 1)) + Math.Sqrt(Math.Pow(x3, 2.0)));
                }
                else
                {
                    throw new Exception("Деление на 0 невозможно! Измените значение x3.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            textBox8.Text = Convert.ToString(y1);
            textBox9.Text = Convert.ToString(y2);
            textBox10.Text = Convert.ToString(y3);

        }

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


