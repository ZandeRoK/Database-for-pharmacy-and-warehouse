using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest.FormsForPharmacy
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter1.Fill(this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.Warehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSet1.Warehouse". При необходимости она может быть перемещена или удалена.

        }
        PharmacyDataContext db = new PharmacyDataContext();
        private void button1_Click(object sender, EventArgs e)
        {


            PharmacyDataContext db = new PharmacyDataContext();
            try
            {
                // int columnIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                //var itemDrug = (from x in db.Warehouse where x.Id == columnIndex select x).First();
                // var itemOrder = (from x in db.Order where x.Id == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()) select x).First();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1[4, i].Value != null)// && dataGridView1[4, i].Value>)
                    {
                        int itemId = Convert.ToInt32(dataGridView1[0, i].Value.ToString());
                        var itemDrug = (from x in db.Warehouse where x.Id == itemId select x).First();
                        if (itemDrug.Count > Convert.ToInt32(dataGridView1[4, i].Value.ToString()))
                        {
                            Order order = new Order
                            {
                                Date = DateTime.Now,
                                IdDrug = Convert.ToInt32(dataGridView1[0, i].Value),
                                IdStatus = 2,
                                Count = Convert.ToInt32(dataGridView1[4, i].Value)
                            };
                            db.Order.InsertOnSubmit(order);
                            db.SubmitChanges();
                        }
                        else { MessageBox.Show("Count in order more than count in warehouse"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { Dispose(); }
        }
    }
}


   

