﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace MonolithMainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            var login = loginField.Text.Trim();
            var password = passField.Text.Trim();

            //if (login == "admin" && password == "admin")
            //{
                //var mf = new ManagerForm();
               // mf.Show();
                //this.Close();
                //return;
            //}

            //var db = new DataBase();

            //var table = new DataTable();
            //var adapter = new MySqlDataAdapter();
            //var command = new MySqlCommand("SELECT * FROM placements WHERE name = @login AND password = @pass", db.GetConection());

            //command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
                //var pf = new PlacementForm(login);
                //pf.Show();
            //}
            //else
                //MessageBox.Show("Неверная пара значений Логин-пароль");

        }
    }
}
