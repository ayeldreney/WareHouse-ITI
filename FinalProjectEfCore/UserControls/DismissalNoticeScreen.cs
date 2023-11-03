

using FinalProjectEfCore.DataSource;
using FinalProjectEfCore.model;
using System;

using System.Windows.Forms;

namespace FinalProjectEfCore.UserControls
{
    public partial class DismissalNoticeScreen : UserControl
    {
        public DismissalNoticeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DismissalNotice dismissalNotice = new DismissalNotice() { DismissalNotice_Date=textBox1.Text,wareHouse_fk=int.Parse(textBox2.Text),supplier_fk=int.Parse(textBox3.Text)};   

            LoadDb loadDb = new LoadDb();
            loadDb.dismissalNotices.Add(dismissalNotice);
            loadDb.SaveChanges();

            MessageBox.Show("Added");


        }
    }
}
