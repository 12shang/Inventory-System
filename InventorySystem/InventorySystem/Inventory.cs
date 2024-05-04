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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form q = Form as Form;
            q.TopLevel = false;
            q.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(q);
            q.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new data());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadForm(new supplier());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            loadForm(new building());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < 0 && (Math.Abs(label1.Left) > label1.Width))
                label1.Left = this.Width;

            if (label2.Left < 0 && (Math.Abs(label2.Left) > label2.Width))
                label2.Left = this.Width;

            label1.Left -= 1;
            label2.Left -= 1;
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadForm(new product());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new stocks());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
