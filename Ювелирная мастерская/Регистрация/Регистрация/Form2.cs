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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void регBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.регBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.dataSet1.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Рег". При необходимости она может быть перемещена или удалена.
            this.регTableAdapter.Fill(this.dataSet1.Рег);

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void даниилToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id229481012");
        }

        private void кириллToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id212903700");
        }

        private void ильяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ilya_reych");
        }

        private void алесяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/mr_lays24");
        }
        bool GG;
        private void button5_Click(object sender, EventArgs e)
        {
            if (GG)
            {
                button6.Visible = false;
                button7.Visible = false;
                GG = false;
            }
            else
            {
                button6.Visible = true;
                button7.Visible = true;
                GG = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.Gray;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Nomer = int.Parse(this.textBox1.Text);
                string connectionString = @"Data Source=DESKTOP-17GNO4I\SQLEXPRESS;Initial Catalog=Регисрация;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "DELETE FROM Клиенты WHERE id = @id";
                myCommand.Parameters.Add("@id", SqlDbType.Int);
                myCommand.Parameters["@id"].Value = Nomer;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    }

