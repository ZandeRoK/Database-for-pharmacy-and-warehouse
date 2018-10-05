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
    public partial class AddNewDrug : Form
    {
        PharmacyDataContext db = new PharmacyDataContext();
        public AddNewDrug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    if (dataGridView1[0, i].Value != null)
                    {
                        Warehouse newItem = new Warehouse
                        {
                            NameDrug = dataGridView1[0, i].Value.ToString(),
                            Description = dataGridView1[1, i].Value.ToString(),
                            Count = Convert.ToInt32(dataGridView1[2, i].Value),
                        };
                        db.Warehouse.InsertOnSubmit(newItem);
                        db.SubmitChanges();
                        WarehouseForm warehouseForm = new WarehouseForm();
                        warehouseForm.LoadDataGridViews();
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
