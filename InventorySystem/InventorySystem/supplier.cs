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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//To add all input in the database
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "INSERT INTO tbl_supplier(Supplier_ID, Supplier_Name, PhoneNo, Location) VALUES('" + this.textBox1.Text + "', '" +
                    this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully Add!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//To update the select record in the database
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "UPDATE tbl_supplier SET Supplier_Name ='" + this.textBox2.Text + "', PhoneNo =" +
                    " '" + this.textBox3.Text + "', Location = '" + this.textBox4.Text + "' WHERE Supplier_ID='" + this.textBox1.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated successfully!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//To display all records from the table supplier to the datagrid
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "SELECT * FROM tbl_supplier";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {//to delete the select records from database
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "DELETE FROM tbl_supplier WHERE Supplier_ID ='"+this.textBox1.Text+"'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been deleted!!!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplier_Load(object sender, EventArgs e)
        {
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "SELECT * FROM tbl_supplier";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT *, COUNT(Supplier_ID) FROM tbl_supplier WHERE Supplier_ID LIKE '%0%' AND(Location LIKE'%Taguig%' OR Location LIKE '%Pasig%') GROUP By Supplier_ID ORDER By Supplier_ID", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Supplier ID";
            dataGridView1.Columns[1].HeaderText = "Supplier Name";
            dataGridView1.Columns[2].HeaderText = "Phone Number";
            dataGridView1.Columns[3].HeaderText = "Location";
            dataGridView1.Columns[4].HeaderText = "Count";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Supplier_ID"].Value.ToString();
            textBox2.Text = row.Cells["Supplier_Name"].Value.ToString();
            textBox3.Text = row.Cells["PhoneNo"].Value.ToString();
            textBox4.Text = row.Cells["Location"].Value.ToString();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
