using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Регистрация
{
    public partial class Form3 : Form
    { 
        public Form3()
        {
            InitializeComponent();
        }

        private void регBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.регBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.регTableAdapter.Fill(this.dataSet1.Рег);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            регBindingSource.EndEdit();
            регTableAdapter.Update(dataSet1);
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            регBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
        bool admin;
        private void button3_Click(object sender, EventArgs e)
        {
            if (admin)
            {

                парольTextBox.UseSystemPasswordChar = true;

                admin = false;

            }
            else
            {

                парольTextBox.UseSystemPasswordChar = false;

                admin = true;
            }
        }
    }
}
