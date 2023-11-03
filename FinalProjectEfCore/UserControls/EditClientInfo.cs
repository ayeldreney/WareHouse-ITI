using FinalProjectEfCore.DataSource;
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
    public partial class EditClientInfo : UserControl
    {
        public EditClientInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDb loadDb = new LoadDb();
            var client = loadDb.Clients.Find(int.Parse(textBox1.Text));
            if (client == null)
            {
                MessageBox.Show("Enter a Valied Data");
            }
            else if (client.Client_Id != int.Parse(textBox1.Text)) {
                MessageBox.Show("Cannot Found");
            }
            else
            {
                client.Client_Name = textBox2.Text;
                client.Client_EMail = textBox3.Text;
                client.Company_fk = int.Parse(textBox4.Text);
                loadDb.SaveChanges();
                MessageBox.Show("Successfully Edited");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDb loadDb = new LoadDb();
            var supplier = loadDb.Suppliers.Find(int.Parse(textBox5.Text));
            if (supplier == null)
            {
                MessageBox.Show("Cannot Found");
            }
            else
            {
                supplier.Supplier_Name = textBox6.Text;
                supplier.Supplier_EMail = textBox7.Text;
                supplier.Company_fk = int.Parse(textBox8.Text);
                MessageBox.Show("added");
            }
        }

    
    }
}