using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataBaseTest.FormsForWarehouse;

namespace DataBaseTest.FormsForLogging
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        PharmacyDataContext db = new PharmacyDataContext();
        //4-admin, 5-UserPharmacy, 6-UserWarehouse   
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = (from x in db.User where x.e_mail == textBox1.Text && x.Password == textBox2.Text select x.IdRole).FirstOrDefault();
                if (newUser != 0)
                {
                    if (newUser == 5)
                    {
                        this.Hide();
                        MainFormPharmacy formPharmacy = new MainFormPharmacy();
                        formPharmacy.ShowDialog();
                        this.Close();
                    }
                    if (newUser == 6)
                    {
                        this.Hide();
                        WarehouseForm formWarehouse = new WarehouseForm();
                        formWarehouse.ShowDialog();
                        this.Close();
                    }
                }
                else { MessageBox.Show("Incorrect data. Please try again"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }
    }
}
