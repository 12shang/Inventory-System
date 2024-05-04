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
    public partial class product : Form
    {//Connects Mysql to the system
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'inventory_db'; username = root; password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public product()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//To add all input in the database
            if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                textBox5.Text != "" && textBox6.Text != "" && comboBox2.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "INSERT INTO tbl_product(Prd_ID, Item_Name, Quantity, Reorder_Level," +
                    " Unit_Cost, Retail_Price, Bldg_Code, Last_Order) VALUES('" + this.textBox1.Text + "', '" +
                    this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "','" + this.comboBox2.Text + "','" + this.comboBox1.Text + "')";
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
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {//get the building code in the table building and add it to the combo box
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");

                string selectQuery = "SELECT Bldg_Code FROM tbl_building where Bldg_Code = '" + comboBox2.SelectedItem.ToString() + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void product_Load(object sender, EventArgs e)
        { //Connect the form to mysql
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
                //get the records in table building
                string selectQuery = "SELECT * FROM tbl_building";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString("Bldg_Code"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            searchData("");//Use to search inside the database
        }
        public void searchData(string valueToSearch)
        { //Output the records you search in a search box
            string query = "SELECT * FROM tbl_product WHERE CONCAT(`Prd_ID`, `Item_Name`, `Quantity`, `Reorder_Level`, `Unit_Cost`, `Retail_Price`, `Bldg_Code`, `Last_Order`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Display all the records from table product
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "SELECT * FROM tbl_product";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {//use to update the select records
            if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
               textBox5.Text != "" && textBox6.Text != "" && comboBox2.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "UPDATE tbl_product SET Item_Name ='" + this.textBox2.Text + "', Quantity =" +
                    " '" + this.textBox3.Text + "', Reorder_Level = '" + this.textBox4.Text + "',Retail_Price ='" +
                    this.textBox5.Text + "',Unit_Cost ='" + this.textBox6.Text + "',Bldg_Code ='" + this.comboBox2.Text + "',Last_Order ='"
                    + this.comboBox1.Text + "' WHERE Prd_ID='" + this.textBox1.Text + "'";
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
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//The textbox accept only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {//The textbox accept only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {//The textbox accept only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {//Use to delete the select records
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "DELETE FROM tbl_product WHERE Prd_ID ='" + this.textBox1.Text + "'";
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
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = guna2TextBox1.Text.ToString();
            searchData(valueToSearch);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Prd_ID"].Value.ToString();
            textBox2.Text = row.Cells["Item_Name"].Value.ToString();
            textBox3.Text = row.Cells["Quantity"].Value.ToString();
            textBox4.Text = row.Cells["Reorder_Level"].Value.ToString();
            textBox5.Text = row.Cells["Retail_Price"].Value.ToString();
            textBox6.Text = row.Cells["Unit_Cost"].Value.ToString();
            comboBox1.Text = row.Cells["Last_Order"].Value.ToString();
            comboBox2.Text = row.Cells["Bldg_Code"].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT Prd_ID,Item_Name,Last_Order FROM tbl_product WHERE Last_Order != 'False' ORDER BY 1", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Product ID";
            dataGridView1.Columns[1].HeaderText = "Item Name";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_product LIMIT 10", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT Prd_ID,Item_Name,Reorder_Level,Quantity,Bldg_Code,Last_Order FROM tbl_product WHERE Reorder_Level < Quantity AND Bldg_Code IN(1, 2, 3, 4, 5) AND Last_Order = 'False' ORDER BY Prd_ID ", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
