﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Гонки
{
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost;user=root;password=arisandloki;database=dbRace";

        bool isLoginDublicate;

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
            if (!string.IsNullOrEmpty(guna2TextBox1.Text) && !string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                using (MySqlConnection connection2 = new MySqlConnection(connectionString))
                {
                    connection2.Open();

                    string getLoginUserQuery = "select никнейм from Пользователи where никнейм = @никнейм";
                    MySqlCommand commandLoginUser = new MySqlCommand(getLoginUserQuery, connection2);
                    commandLoginUser.Parameters.AddWithValue("@никнейм", guna2TextBox1.Text);
                    object objUsersLogin = commandLoginUser.ExecuteScalar();

                    if (objUsersLogin != null)
                    {
                        isLoginDublicate = true;
                        MessageBox.Show("Такой логин уже существует, придумайте новый");
                    }
                    else
                    {
                        isLoginDublicate = false;
                    }

                    connection2.Close();
                }
            }

            if (!string.IsNullOrEmpty(guna2TextBox1.Text) && !string.IsNullOrEmpty(guna2TextBox2.Text) && !isLoginDublicate)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    try
                    {
                        string addNewUserQuery = "insert into Пользователи (никнейм, пароль) values (@никнейм, @пароль)";
                        MySqlCommand commandAddUser = new MySqlCommand(addNewUserQuery, connection);
                        commandAddUser.Parameters.AddWithValue("@никнейм", guna2TextBox1.Text);
                        commandAddUser.Parameters.AddWithValue("@пароль", guna2TextBox2.Text);
                        commandAddUser.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
            }
            else if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBox3.Text) && !string.IsNullOrEmpty(guna2TextBox4.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string lookForUserQuery = "select никнейм, пароль from Пользователи where никнейм = @nickname and пароль = @password";
                    MySqlCommand commandLookForUser = new MySqlCommand(lookForUserQuery, connection);
                    commandLookForUser.Parameters.AddWithValue("@nickname", guna2TextBox3.Text);
                    commandLookForUser.Parameters.AddWithValue("@password", guna2TextBox4.Text);
                    object dataFromBDuser = commandLookForUser.ExecuteScalar();

                    string lookForAdminQuery = "select никнейм, пароль from Администратор where никнейм = @nickname and пароль = @password";
                    MySqlCommand commandlookForAdmin = new MySqlCommand(lookForAdminQuery, connection);
                    commandlookForAdmin.Parameters.AddWithValue("@nickname", guna2TextBox3.Text);
                    commandlookForAdmin.Parameters.AddWithValue("@password", guna2TextBox4.Text);
                    object dataFromBDadmin = commandlookForAdmin.ExecuteScalar();

                    if (dataFromBDuser != null)
                    {
                        MessageBox.Show("Вы вошли в аккаунт как пользователь");
                    }
                    else if (dataFromBDadmin != null)
                    {
                        MessageBox.Show("Режим аминистратор");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, данных не существует");
                    }

                    connection.Close();
                }
            }
            else if (string.IsNullOrEmpty(guna2TextBox3.Text) || string.IsNullOrEmpty(guna2TextBox4.Text))
            {
                MessageBox.Show("Заполните поля");
            }               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MessageBox.Show("Подключение работает");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка подключения к бд: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        //ДОДЕЛАТЬ

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string nickname = guna2TextBox1.Text;
            string specialCharacters = @"[!@#$%^&*()_+\-=\[\]{}|\\:;""'<>,.?\/~]";

            for (int i = 0; i < nickname.Length; i++)
            {
                if (nickname.Length < 5)
                { 
                    label3.ForeColor = Color.Red;
                }
            }

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void guna2TextBox1_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void guna2TextBox2_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void guna2TextBox2_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
    }
}
