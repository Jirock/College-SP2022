using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Button btn = new Button();
        public Label lbl = new Label();
        public TextBox textBox = new TextBox();

        public Form1()
        {
            InitializeComponent();
        }

        
        public void MethodBtn()
        {
            btn.Text = "POOTIS";
            btn.Size = new Size(60, 20);   
            btn.Location = new Point(100, 40);
            this.Controls.Add(btn);
        }

        public void MethodLbl()
        {
            lbl.Text = "LABEL";
            lbl.Size = new Size(100, 50);
            lbl.Location = new Point(200, 40);
            this.Controls.Add(lbl);
        }

        public void MethodText()
        {
            textBox.Text = "TextBox";
            textBox.Size = new Size(100, 50);
            textBox.Location = new Point(300, 40);
            this.Controls.Add(textBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodBtn();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MethodLbl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MethodText();
        }
    }
}
