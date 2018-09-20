using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest.FormsForWarehouse
{
    public partial class WarehouseForm : Form
    {

        PharmacyDataContext db = new PharmacyDataContext();
        public WarehouseForm()
        {
            InitializeComponent();

        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.Warehouse". При необходимости она может быть перемещена или удалена.
           // this.warehouseTableAdapter1.Fill(this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.Warehouse);
            LoadDataGridViews();

        }

        internal void LoadDataGridViews()
        {
            //this.warehouseTableAdapter.Fill(this.dB_MainDataSet1.Warehouse);
            try
            {
                var countOrder = from x in db.Order where x.IdStatus == 2 select new { x.Id, x.IdDrug, x.Warehouse.NameDrug, x.IdStatus, x.Count, x.Date };
                label1.Text = Convert.ToString(countOrder.Count());
                dataGridView2.DataSource = countOrder;
                this.warehouseTableAdapter1.Fill(_C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.Warehouse);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
                var itemDrug = (from x in db.Warehouse where x.Id == columnIndex select x).First();
                // var x1 = warehouse.Find(x=>x.Id == columnIndex).Count;
                //warehouse.Count;
                if (Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value.ToString()) < itemDrug.Count)
                {
                    DialogResult dialogResult = MessageBox.Show("Sure?", "Confirm transaction", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var itemOrder = (from x in db.Order where x.Id == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()) select x).First();
                        itemOrder.IdStatus = 1;
                        itemDrug.Count -= itemOrder.Count;
                        if (db.Store.Any(x => x.IdDrug == itemDrug.Id))
                        {
                            var itemPharmacy = (from x in db.Store where x.IdDrug == itemDrug.Id select x).First();
                            itemPharmacy.Count += itemOrder.Count;
                            db.SubmitChanges();
                            LoadDataGridViews();
                        }
                        else
                        {
                            Store newItemStore = new Store
                            {
                                Count = itemOrder.Count,
                                IdDrug = itemOrder.IdDrug
                            };
                            db.Store.InsertOnSubmit(newItemStore);
                            db.SubmitChanges();
                            LoadDataGridViews();
                        }
                    }
                    
                }
                else { MessageBox.Show("Count in order more than count in warehouse"); }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Please select a cell in the order");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private BindingSource bindingSource1 = new BindingSource();
        
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            warehouseTableAdapter1.Update(_C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataGridViews();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        
    }
}
