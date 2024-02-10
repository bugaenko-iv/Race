using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гонки
{
    public partial class Form1 : Form
    {
        int mlseconds = 0;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {       
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_MouseEnter(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Font = new Font(guna2HtmlLabel1.Font.FontFamily, guna2HtmlLabel1.Font.Size + 2, guna2HtmlLabel1.Font.Style);
        }

        private void guna2HtmlLabel1_MouseLeave(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Font = new Font(guna2HtmlLabel1.Font.FontFamily, guna2HtmlLabel1.Font.Size - 2, guna2HtmlLabel1.Font.Style);
        }

        private void guna2HtmlLabel2_MouseEnter(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Font = new Font(guna2HtmlLabel2.Font.FontFamily, guna2HtmlLabel2.Font.Size + 2, guna2HtmlLabel2.Font.Style);
        }

        private void guna2HtmlLabel2_MouseLeave(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Font = new Font(guna2HtmlLabel2.Font.FontFamily, guna2HtmlLabel2.Font.Size - 2, guna2HtmlLabel2.Font.Style);
        }

        private void guna2HtmlLabel3_MouseEnter(object sender, EventArgs e)
        {
            guna2HtmlLabel3.Font = new Font(guna2HtmlLabel3.Font.FontFamily, guna2HtmlLabel3.Font.Size + 2, guna2HtmlLabel3.Font.Style);
        }

        private void guna2HtmlLabel3_MouseLeave(object sender, EventArgs e)
        {
            guna2HtmlLabel3.Font = new Font(guna2HtmlLabel3.Font.FontFamily, guna2HtmlLabel3.Font.Size - 2, guna2HtmlLabel3.Font.Style);
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        int numY = 331;

        private void timer1_Tick(object sender, EventArgs e)
        {
            mlseconds++;

            if (mlseconds == 40)
            {
                pictureBox2.Visible = true;
            }

            if (pictureBox2.Visible == true && numY != 12)
            {
                pictureBox2.Location = new Point(x: 45, y: numY);
                numY-=7;
                pictureBox2.Refresh();
                System.Threading.Thread.Sleep(10);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
