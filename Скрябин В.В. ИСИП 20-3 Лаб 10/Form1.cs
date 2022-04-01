using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pn = new Pen(Color.Black, 5);
            Pen pg = new Pen(Color.Green, 5);
            SolidBrush B1 = new SolidBrush(Color.Black);
            SolidBrush B2 = new SolidBrush(Color.White);
            SolidBrush B3 = new SolidBrush(Color.DarkRed);
            SolidBrush B4 = new SolidBrush(Color.Orange);
            SolidBrush B5 = new SolidBrush(Color.Green);

            //Яблоко
            g.FillEllipse(B3, 100, 300, 100, 100);
            //Белок 
            g.FillEllipse(B2, 145, 348, 15, 10);
            g.FillEllipse(B2, 175, 348, 15, 10);
            //Рот
            g.DrawLine(pn, 160, 380, 170, 380);
            //Зрачок
            g.FillEllipse(B1, 150, 350, 5, 5);
            g.FillEllipse(B1, 180, 350, 5, 5);
            //Цветок
            g.DrawLine(pg, 122, 310, 100, 300);
            g.FillEllipse(B5, 100, 292, 10, 12);

            //Апельсин
            g.FillEllipse(B4, 250, 300, 100, 100);
            //Белок 
            g.FillEllipse(B2, 275, 348, 15, 10);
            g.FillEllipse(B2, 305, 348, 15, 10);
            //Рот
            g.FillEllipse(B1, 290, 374, 20, 10);
            //Зрачок
            g.FillEllipse(B1, 275, 350, 5, 5);
            g.FillEllipse(B1, 305, 350, 5, 5);

            //Нож
            g.DrawRectangle(pn, 400, 50, 200, 50);
            g.DrawRectangle(pn, 380, 40, 20, 70);
            //Лезвие
            g.DrawLine(pn, 380, 50, 100, 50);
            g.DrawLine(pn, 100, 50, 130, 100);
            g.DrawLine(pn, 130, 100, 380, 100);

            //Текст
            g.DrawString("Эй яблоко!", this.Font, B1, 400, 350); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
