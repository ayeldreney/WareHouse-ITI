using FinalProjectEfCore.DataSource;
using FinalProjectEfCore.model;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddClient_Suppliers : UserControl
    {
        public AddClient_Suppliers()
        {
            InitializeComponent();
        }

        public delegate void AddCode(LoadDb loadDb);
        public void SaveChange(AddCode addCode) {
            LoadDb loadDb = new LoadDb();
            addCode(loadDb);
            loadDb.SaveChanges();   
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            SaveChange((l) => {

                Client client = new Client() { Client_Name = textBox1.Text, Client_EMail = textBox2.Text, Company_fk = int.Parse(textBox3.Text) };


                l.Clients.Add(client);

          
            });


        

          

            MessageBox.Show("Client added");

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        


            SaveChange((l) => {

                Supplier supp = new Supplier() { Supplier_Name = textBox4.Text, Supplier_EMail = textBox5.Text, Company_fk = int.Parse(textBox6.Text) };

                l.Suppliers.Add(supp);
             


            });


          

         

          

            MessageBox.Show("Supplier added");
        }

     
    }
}
