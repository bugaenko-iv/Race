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
        int speedCar = 60;
        int mlseconds = 0;
        int numX = 0;
        int numY = -86;
        int HeroNumX = 0;
        int HeroNumY = 0;
        int randomValue = 0;
        private bool numXCheck = false;
        Random random = new Random();


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
            mlseconds += timer1.Interval;

            int seconds = mlseconds / 1000;
            label2.Text = seconds.ToString();
            
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

            if(mlseconds == 3000)
            {
                randomValue = random.Next(1, 3);
                numX = (randomValue == 1) ? 272 : 392;

                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(numX, numY);
            }

            if (pictureBox6.Visible)
            {
                numY += 5;
            }

            pictureBox6.Location = new Point(numX, numY);

            HeroNumX = pictureBox3.Location.X;

            if (HeroNumX == numX)
            {
                numXCheck = true;
            }
            else
            {
                numXCheck = false;
            }

            if(numXCheck && numY >= 160 && numY <= 419)
            {
                timer1.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
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
            MessageBox.Show(pictureBox3.Location.X.ToString());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            speedCar = 0;
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            speedCar = 60;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
