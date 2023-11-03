using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FinalProjectEfCore.DataSource;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.Remoting.Contexts;

namespace FinalProjectEfCore
{
    public partial class Form1 : Form
    {

       
      
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
      

        }

        private void login_Click(object sender, EventArgs e)
        {
            
            using (var context = new LoadDb()) {

                if (String.IsNullOrEmpty(userNameTextBox1.Text) || String.IsNullOrEmpty(passwordTextBox2.Text))
                {
                    MessageBox.Show("Enter valied data");
                }
                else
                { 
                    var user = context.login.FirstOrDefault(u => u.UserName == userNameTextBox1.Text.Trim() && u.Password == passwordTextBox2.Text.Trim());

                    if (user != null)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Cannot login");
                    }
                }



            }



           

        }

        private void clear_Click(object sender, EventArgs e)
        { 
            userNameTextBox1.Clear();  
            passwordTextBox2.Clear();   

            userNameTextBox1.Focus();   

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res is DialogResult.Yes) {
            Application.Exit();
            }
            else {
            this.Show();    
            }



        }

        private void passwordTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
