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
    public partial class AddEditProduct : UserControl
    {
        public AddEditProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product product = new Product() { Product_Name = textBox1.Text ,WareHouse_fk=int.Parse(textBox2.Text)};

            LoadDb loadDb = new LoadDb();

            loadDb.Product.Add(product);

            loadDb.SaveChanges();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDb loadDb = new LoadDb();
            var product = loadDb.Product.Find(int.Parse(textBox3.Text));
            if (product == null)
            {
                MessageBox.Show("Cannot Found");
            }
            else
            {
                product.Product_Name = textBox4.Text;   
                product.WareHouse_fk = int.Parse(textBox5.Text);
                loadDb.SaveChanges();
                MessageBox.Show("successfully Edited");
            }

        }

        private void AddEditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
