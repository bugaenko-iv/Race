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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            groupBox2.Visible = true;
            label2.Visible = true;

            guna2TextBox1.Text = null;
            guna2TextBox2.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            label2.Visible = false;

            label1.Visible = true;

            guna2TextBox3.Text = null;
            guna2TextBox4.Text = null;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox3.Text) || string.IsNullOrEmpty(guna2TextBox4.Text))
            {
                MessageBox.Show("Заполните поля");
            }               
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
