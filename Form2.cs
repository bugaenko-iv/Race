using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Гонки
{
    public partial class Form2 : Form
    {
        int speed = 4;

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += speed;
            pictureBox2.Top += speed;

            if(pictureBox2.Top >= 449)
            {
                pictureBox2.Top = -449;
            }
            if(pictureBox1.Top >= 449) 
            {
                pictureBox1.Top = -449;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int speedCar = 8;

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (pictureBox3.Location.X > 272)
                {

                    pictureBox3.Left -= speedCar;
                }
            }

            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (pictureBox3.Location.X < 390)
                {
                    pictureBox3.Left += speedCar;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
