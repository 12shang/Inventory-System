using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                if(textBox2.Text == "admin")
                {
                    new Inventory().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Please Enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Please Enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    new Inventory().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Please Enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Please Enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

