using FinalProjectEfCore.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectEfCore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl) { 
            userControl.Dock = DockStyle.Fill;  
            panel1.Controls.Clear();    
            panel1.Controls.Add(userControl);  
            userControl.BringToFront();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddClient_Suppliers addClient_Suppliers = new AddClient_Suppliers();    
            addUserControl(addClient_Suppliers);    



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            EditClientInfo addClient_ClientInfo = new EditClientInfo(); 
            addUserControl(addClient_ClientInfo);   

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct();       
            addUserControl(addEditProduct); 
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddEditWareHouse addEditWareHouse = new AddEditWareHouse(); 
            addUserControl(addEditWareHouse);   
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SupplyPermissionScreen supplyPermissionScreen = new SupplyPermissionScreen();
            addUserControl(supplyPermissionScreen);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DismissalNoticeScreen dis  = new DismissalNoticeScreen();   
            addUserControl(dis);    

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            addUserControl(display);
        }
    }
}
