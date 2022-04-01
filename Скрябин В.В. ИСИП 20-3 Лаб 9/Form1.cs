using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBoxX0.Text);
            double xk = Convert.ToDouble(textBoxXk.Text);
            double dx = Convert.ToDouble(textBoxDx.Text);
            double y = 0;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double b = 2.5;
                y = 9 * (x + 15 * Math.Sqrt(Math.Pow(x, 3) + Math.Pow(b, 3)));
                x = x + dx;
            }


            int y1 = Convert.ToInt32(y);
            double[] yX = new double[y1];
            double[] Aard = new double[y1];

            for (int i = 0; i < y1; i++)
            {
                yX[i] = xk + dx * i;
                Aard[i] = Math.Sin(yX[i]);
            }

            // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = dx;
            // Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = xk;
            // Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(yX,Aard);
        }
    }
}
