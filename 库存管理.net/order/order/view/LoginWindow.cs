﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using order.Entity;
using order.controller;
using order.view;
namespace order
{
    public partial class LoginWindow : Form
    {
        private static LoginWindow loginWindow;
        public LoginWindow()
        {
            InitializeComponent();
        }

        public static LoginWindow getInstance()
        {
            if (loginWindow == null)
            {
                loginWindow = new LoginWindow();
            }
            return loginWindow;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminInfo.userPassword = this.passWord.Text;
            AdminInfo.userName = this.adminName.Text;
            new LoginController(this).login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
