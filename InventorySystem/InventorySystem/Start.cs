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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var before = this.guna2ProgressBar1.Value;
            this.guna2ProgressBar1.Increment(1);
            var after = this.guna2ProgressBar1.Value;
            if (after > before && after == this.guna2ProgressBar1.Maximum)
            {
                MessageBox.Show("Welcome to Inventory Management Sytem", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 nextform = new Form2();
                nextform.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
