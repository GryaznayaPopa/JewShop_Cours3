using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Регистрация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sss = new SqlConnection(@"Data Source=DESKTOP-17GNO4I\SQLEXPRESS;Initial Catalog=Регисрация;Integrated Security=True");
            SqlDataAdapter ss = new SqlDataAdapter("Select Count (*) From Рег where Логин = '" + Log.Text + "'and Пароль = '" + Par.Text + "'", sss);
            DataTable dt = new DataTable();
            ss.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 s = new Form3();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void Log_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Par.Focus();
            }
        }

        private void Par_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Par_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                button2.Focus();
            }
        }
        bool admin;

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (admin)
            {

                Par.UseSystemPasswordChar = true;

                admin = false;

            }
            else
            {

                Par.UseSystemPasswordChar = false;

                admin = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
