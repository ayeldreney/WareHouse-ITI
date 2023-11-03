using FinalProjectEfCore.DataSource;
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
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           LoadDb loadDb = new LoadDb();

            var warehouse=  loadDb.wareHouses.Select(p => new { p.WareHouse_Name, p.WareHouse_Address, p.Company.Company_Name,p.WareHouse_Id }).ToList();
            listView1.Columns.Clear();
            listView1.Columns.Add("");
            foreach (var item in warehouse) {
                listView1.Items.Add(item.WareHouse_Id.ToString());
                listView1.Items.Add(item.WareHouse_Name);
                listView1.Items.Add(item.Company_Name);
                listView1.Items.Add(item.WareHouse_Address);
         

            }
            listView1.Columns[0].Width = -1;

            loadDb.SaveChanges();


        }
    }
}
