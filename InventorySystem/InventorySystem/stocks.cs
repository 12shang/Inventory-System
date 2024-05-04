using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace InventorySystem
{
    public partial class stocks : Form
    {//Connect mysql to the system
        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3306; Initial Catalog = 'inventory_db'; username = root; password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public stocks()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void stocks_Load(object sender, EventArgs e)
        {//Select all records from table product
            Loadstocks();
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");

                string selectQuery = "SELECT * FROM tbl_product";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetString("Prd_ID"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try //Select all records from table supplier
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");

                string selectQuery = "SELECT * FROM tbl_supplier";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("Supplier_ID"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Loadstocks()
        {
            string connection = "server = localhost; user id = root; password =; database = inventory_db; convert zero datetime=True";
            string query1 = "SELECT * FROM tbl_date";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
        }
        public void searchData(string valueToSearch)
        {//Select the records from table date
            string query = "SELECT * FROM tbl_date WHERE CONCAT(`Supplier_ID`, `Prd_ID`, `Date_Supplied`, `StockQty_Before_Resupply`, `StockQty_After_Resupply`, `Date_Last_Resupply`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {//Allow to insert new records from table date
            if (comboBox1.Text != "" && comboBox3.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "INSERT INTO tbl_date(Supplier_ID,Prd_ID, Date_Supplied, StockQty_Before_Resupply, StockQty_After_Resupply,Date_Last_Resupply) VALUES('" + this.comboBox1.Text + "','" + this.comboBox3.Text + "', " +
                    "'" + this.dateTimePicker1.Text + "','" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.dateTimePicker2.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully Add!", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";
                textBox3.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {//Select the Quantity from table product to table date
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");

                string selectQuery = "SELECT * FROM tbl_product where Prd_ID = '" + comboBox3.SelectedItem.ToString() + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label6.Text = reader["Quantity"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//Display all records to the datagrid
            string connection = "server = localhost; user id = root; password =; database = inventory_db; convert zero datetime=True";
            string query = "SELECT * FROM tbl_date";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy/MM/dd";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy/MM/dd";
        }

        private void button3_Click(object sender, EventArgs e)
        {//Update the select records in database
            if (comboBox1.Text != "" && comboBox3.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string connection = "server = localhost; user id = root; password =; database = inventory_db";
                string query = "UPDATE tbl_date SET StockQty_Before_Resupply ='" + this.textBox2.Text + "', StockQty_After_Resupply =" +
                    " '" + this.textBox3.Text + "', Date_Last_Resupply = '" + this.dateTimePicker2.Text + "', Date_Supplied = '"
                    + this.dateTimePicker1.Text + "', Supplier_ID = '" + this.comboBox1.Text + "' WHERE Prd_ID='" + this.comboBox3.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated successfully!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";
                textBox3.Text = "";
                conn.Close();
            }
            else
            {
                MessageBox.Show("Empty Text Field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//Allow to delete the select records from datagrid
            string connection = "server = localhost; user id = root; password =; database = inventory_db";
            string query = "DELETE FROM tbl_date WHERE Prd_ID ='" + this.comboBox3.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been deleted!!!", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Text = "";
            textBox3.Text = "";
            conn.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//Automatic display the sum of quantity of the product and the input of before resupply to the after resupply
            try
            {
                textBox3.Text = (int.Parse(textBox2.Text) + int.Parse(label6.Text)).ToString();
            }
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//Get the list of Supplier ID to the table supplier and list it to the combo box1 in this form
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");

                string selectQuery = "SELECT Supplier_ID FROM tbl_supplier where Supplier_ID = '" + comboBox1.SelectedItem.ToString() + "'";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {//to find what you are searching for
            string valueToSearch = guna2TextBox1.Text.ToString();
            searchData(valueToSearch);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT Supplier_ID,Prd_ID,StockQty_Before_Resupply, StockQty_After_Resupply, Date_Supplied FROM tbl_date WHERE Date_Supplied >= '2022-05-10' AND(StockQty_Before_Resupply < StockQty_After_Resupply) ORDER BY Supplier_ID", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            comboBox1.Text = row.Cells["Supplier_ID"].Value.ToString();
            comboBox3.Text = row.Cells["Prd_ID"].Value.ToString();
            dateTimePicker1.Text = row.Cells["Date_Supplied"].Value.ToString();
            textBox2.Text = row.Cells["StockQty_Before_Resupply"].Value.ToString();
            textBox3.Text = row.Cells["StockQty_After_Resupply"].Value.ToString();
            dateTimePicker2.Text = row.Cells["Date_Last_Resupply"].Value.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}


