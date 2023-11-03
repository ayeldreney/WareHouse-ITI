using FinalProjectEfCore.DataSource;
using FinalProjectEfCore.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectEfCore.UserControls
{
    public partial class SupplyPermissionScreen : UserControl
    {
        public SupplyPermissionScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplyPermission supplyPermission = new SupplyPermission() {
                SupplyPermission_Date = textBox1.Text,
               quantity=int.Parse(textBox2.Text),
                 SupplyPermission_expiry=textBox3.Text,
              wareHouse_fk=int.Parse(textBox4.Text),  
             supplier_fk=int.Parse(textBox5.Text),   

            
            }; 

            LoadDb loaddb =new LoadDb();

            loaddb.supplyPermissions.Add(supplyPermission); 

            loaddb.SaveChanges();
            MessageBox.Show("Added");



        }
    }
}
