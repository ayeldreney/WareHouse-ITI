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
    public partial class AddEditWareHouse : UserControl
    {
        public AddEditWareHouse()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WareHouse wareHouse = new WareHouse() { WareHouse_Name = textBox1.Text, WareHouse_Address = textBox2.Text, Company_fk = int.Parse(textBox3.Text) };
            
            LoadDb loadDb = new LoadDb();   
            
            loadDb.wareHouses.Add(wareHouse);   
            loadDb.SaveChanges();

  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDb loadDb = new LoadDb();
            var warehouse = loadDb.wareHouses.Find(int.Parse(textBox7.Text));
            if (warehouse == null)
            {
                MessageBox.Show("Enter a Valied Data");
            }
            else if (warehouse.WareHouse_Id != int.Parse(textBox7.Text))
            {
                MessageBox.Show("Cannot Found");
            }
            else
            {
                warehouse.WareHouse_Name = textBox4.Text;
                warehouse.WareHouse_Address = textBox5.Text;
                warehouse.Company_fk = int.Parse(textBox6.Text);
                loadDb.SaveChanges();
                MessageBox.Show("Successfully Edited");
            }


        }


    }
}
