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
    public partial class data : Form
    {
  
        public data()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            
                //Joining multiple tables from Mysql
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_supplier.Supplier_ID,tbl_date.Prd_ID,tbl_date.Date_Supplied," +
                "tbl_date.StockQty_After_Resupply,tbl_date.Date_Last_Resupply,tbl_product.Item_Name,tbl_product.Bldg_Code," +
                "tbl_building.Room from tbl_supplier inner join tbl_date ON tbl_supplier.Supplier_ID=tbl_date.Supplier_ID " +
                "inner join tbl_product ON tbl_date.Prd_ID=tbl_product.Prd_ID inner join tbl_building ON " +
                "tbl_product.Bldg_Code=tbl_building.Bldg_Code ORDER BY Supplier_ID,Prd_ID,Date_Supplied,Bldg_Code", connection);//Use Order By to Sort each rows
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Naming the header 
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Supplier ID";
            guna2DataGridView1.Columns[1].HeaderText = "Product ID";
            guna2DataGridView1.Columns[2].HeaderText = "Date Supplied";
            guna2DataGridView1.Columns[3].HeaderText = "Qty. After Resupply";
            guna2DataGridView1.Columns[4].HeaderText = "Date Last Resupply";
            guna2DataGridView1.Columns[5].HeaderText = "Item Name";
            guna2DataGridView1.Columns[6].HeaderText = "Building Code";
            guna2DataGridView1.Columns[7].HeaderText = "Room No.";
            //Apply Font format to the header
            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic",12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            //Set the Cell in the Middle Center
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();//Count how many tables are in a datagrid

        }
        public void searchData(string valueToSearch)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 sp = new Form1();
            //sp.Show();
           // MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            //MySqlCommand cmd = new MySqlCommand("SELECT tbl_supplier.Supplier_ID As SupplierID,tbl_date.Prd_ID AS ProductName,COUNT(*) AS ProductCOUNTS " +
               // "FROM tbl_supplier inner join tbl_date ON tbl_supplier.Supplier_ID=tbl_date.Supplier_ID " +
                // "GROUP BY 1,2", connection);//Use Group By to group supplier and products
           // MySqlDataAdapter da = new MySqlDataAdapter();
           // da.SelectCommand = cmd;
           // DataTable dt = new DataTable();
          //  da.Fill(dt);
            //Naming the header 
          //  guna2DataGridView1.DataSource = dt;
           // guna2DataGridView1.Columns[0].HeaderText = "Supplier ID";
           // guna2DataGridView1.Columns[1].HeaderText = "Product ID";
           MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_product.Bldg_Code,tbl_building.Bldg_Name,COUNT(tbl_product.Prd_ID),tbl_date.Date_Last_Resupply" +
                " FROM tbl_product inner join tbl_date ON tbl_product.Prd_ID=tbl_date.Prd_ID inner join tbl_building ON tbl_product.Bldg_Code=tbl_building.Bldg_Code" +
                " WHERE tbl_date.Date_Last_Resupply BETWEEN '2021-04-01' AND '2021-09-30' " +
                "GROUP BY 1", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Building Code";
            guna2DataGridView1.Columns[1].HeaderText = "Building Name";
            guna2DataGridView1.Columns[2].HeaderText = "Product Count";
            guna2DataGridView1.Columns[3].HeaderText = "Date Last Resupply";


            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            button1.Enabled = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            label3.Text = dt.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_product.Bldg_Code,tbl_building.Bldg_Name,COUNT(tbl_product.Prd_ID)" +
                " FROM tbl_product inner join tbl_date ON tbl_product.Prd_ID=tbl_date.Prd_ID inner join tbl_building ON tbl_product.Bldg_Code=tbl_building.Bldg_Code" +
                " WHERE tbl_date.Date_Last_Resupply BETWEEN '2021-04-01' AND '2021-09-30' " +
                "GROUP BY 1,2 Having(COUNT(tbl_product.Prd_ID)>1)", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Building Code";
            guna2DataGridView1.Columns[1].HeaderText = "Building Name";
            guna2DataGridView1.Columns[2].HeaderText = "Product Count";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
           

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           

            button1.Enabled = true;
            button2.Visible = true;
            label3.Text = dt.Rows.Count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_building.Bldg_Name, SUM(tbl_product.Retail_Price) FROM tbl_building inner join tbl_product ON tbl_building.Bldg_Code = tbl_product.Bldg_Code GROUP BY Bldg_Name ORDER BY 2", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Building Name";
            guna2DataGridView1.Columns[1].HeaderText = "Total Retail Price";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_building.Bldg_Name, AVG(tbl_product.Unit_Cost) FROM tbl_building inner join tbl_product ON tbl_building.Bldg_Code = tbl_product.Bldg_Code GROUP BY Bldg_Name ORDER BY 2 DESC", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Building Name";
            guna2DataGridView1.Columns[1].HeaderText = "Average Unit Cost";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_building.Bldg_Code,tbl_building.Bldg_Name,SUM(tbl_product.Quantity) " +
                "FROM tbl_building inner join tbl_product ON tbl_building.Bldg_Code = tbl_product.Bldg_Code GROUP BY 1,2 ORDER BY 3", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Building Code";
            guna2DataGridView1.Columns[1].HeaderText = "Building Name";
            guna2DataGridView1.Columns[2].HeaderText = "Total Quantity Products";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);


            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT tbl_product.Item_Name,tbl_building.Bldg_Name,tbl_building.Bldg_Code, MAX(tbl_date.StockQty_After_Resupply) " +
                "FROM tbl_building inner join tbl_product ON tbl_building.Bldg_Code = tbl_product.Bldg_Code inner join tbl_date ON tbl_product.Prd_ID = tbl_date.Prd_ID " +
                "GROUP BY Bldg_Name ORDER BY 3", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Item Name";
            guna2DataGridView1.Columns[1].HeaderText = "Building Name";
            guna2DataGridView1.Columns[2].HeaderText = "Building Code";
            guna2DataGridView1.Columns[3].HeaderText = "Maximum Quantity";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=;database = inventory_db");
            MySqlCommand cmd = new MySqlCommand("SELECT Prd_ID,Item_Name FROM tbl_product WHERE Last_Order != 'False' ORDER BY 1", connection);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns[0].HeaderText = "Product ID";
            guna2DataGridView1.Columns[1].HeaderText = "Item Name";

            guna2DataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            guna2DataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            label3.Text = dt.Rows.Count.ToString();
        }
    }
}
