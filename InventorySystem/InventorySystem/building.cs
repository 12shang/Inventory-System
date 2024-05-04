using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace InventorySystem
{
    public partial class building : Form
    {
        public building()
        {
            InitializeComponent();
        }


        private void building_Load(object sender, EventArgs e)
        {
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "SELECT * FROM tbl_building";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "UPDATE tbl_building SET Bldg_Name ='" + this.textBox5.Text + "', Room =" +
                    " '" + this.textBox6.Text + "' WHERE Bldg_Code='" + this.textBox4.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated successfully!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "SELECT * FROM tbl_building";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "DELETE FROM tbl_building WHERE Bldg_Code ='" + this.textBox4.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been deleted!!!","DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text !="") {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "INSERT INTO tbl_building(Bldg_Code, Bldg_Name, Room) VALUES('" + this.textBox4.Text + "', '" +
                    this.textBox5.Text + "', '" + this.textBox6.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully Add!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
           
            textBox4.Text = row.Cells["Bldg_Code"].Value.ToString();
            textBox5.Text = row.Cells["Bldg_Name"].Value.ToString();
            textBox6.Text = row.Cells["Room"].Value.ToString();
            
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
