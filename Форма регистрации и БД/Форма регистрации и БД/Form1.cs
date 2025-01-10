using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Форма_регистрации_и_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (login,password) VALUES (@login,@password)", db.GetConnection());

            command.Parameters.AddWithValue("@login", loginUser1.Text.Trim());
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passUser1.Text;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Данные добавлены");
            else
                MessageBox.Show("Error");

            db.CloseConnection();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginUser2.Text.Trim();
            string passUser = passUser2.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @login AND password = @pass", db.GetConnection());

            command.Parameters.AddWithValue("@login", loginUser);
            command.Parameters.AddWithValue("@pass", passUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            //MessageBox.Show("Пользователь авторизован");
            else
                MessageBox.Show("Error");
            
            
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
             if (guna2CheckBox1.Checked)
             {
                 passUser1.UseSystemPasswordChar = false;
                 passUser1.PasswordChar = (char)0;
                 passUser1Double.UseSystemPasswordChar = false;
                 passUser1Double.PasswordChar = (char)0;
            }
             else
            {
                passUser1.UseSystemPasswordChar = true;
                passUser1Double.UseSystemPasswordChar = true;
            }
           // passUser1.PasswordChar = guna2CheckBox1.Checked ? '*' : '\0';
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                passUser2.UseSystemPasswordChar = false;
                passUser2.PasswordChar = (char)0;
            }
            else passUser2.UseSystemPasswordChar = true;
        }
    }
}
