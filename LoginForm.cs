using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocoAn
{
    public partial class LoginForm : Form
    {
        public bool loginFlag { get; set; }

        public int UserID { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ProviderTBL1TableAdapter IDAda = new DataSet1TableAdapters.ProviderTBL1TableAdapter();
            DataTable dt = IDAda.GetDataByProviderNumber (Convert.ToInt32(metroTextBoxIdNumber.Text));

            if(dt.Rows.Count > 0)
            {
                //valid
                MessageBox.Show("Login Successful");
                loginFlag = true;


            }
            else
            {
                //not valid
                MessageBox.Show("Login Failed");
                loginFlag = false;
                
            }

            Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
