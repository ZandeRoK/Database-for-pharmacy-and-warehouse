using DataBaseTest.FormsForPharmacy;
using DataBaseTest.FormsForWarehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest
{
    public partial class Form1 : Form
    {
        PharmacyDataContext db = new PharmacyDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSet.Store". При необходимости она может быть перемещена или удалена.
            LoadDataLINQ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataLINQ();

        }
        //private void LoadData()
        //{

        //    dataGridView1.Rows.Clear();
        //    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\вадим\documents\visual studio 2015\Projects\DataBaseTest\DataBaseTest\DataBase\DB_Main.mdf;Integrated Security=True";
        //    SqlConnection myConnection = new SqlConnection(connectionString);
        //    myConnection.Open();
        //    string query = "SELECT * FROM Store ORDER BY Id";
        //    SqlCommand command = new SqlCommand(query, myConnection);
        //    SqlDataReader reader = command.ExecuteReader();
        //    List<string[]> data = new List<string[]>();

        //    while (reader.Read())
        //    {
        //        data.Add(new string[3]);

        //        data[data.Count - 1][0] = reader[0].ToString();
        //        data[data.Count - 1][1] = reader[1].ToString();
        //        data[data.Count - 1][2] = reader[2].ToString();
        //    }

        //    reader.Close();

        //    myConnection.Close();
            
        //    foreach (string[] s in data)
        //    dataGridView1.Rows.Add(s);
        //}
        private void LoadDataLINQ()
        {
            
            var b = from x in db.Store select new {x.Id, x.Warehouse.NameDrug, x.Warehouse.Description, x.Count};
            dataGridView1.DataSource = b;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateOrder formCreateOrder = new CreateOrder();
            formCreateOrder.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.Show();
        }
    }
}
