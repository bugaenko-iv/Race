using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гонки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
