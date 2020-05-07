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
    public partial class FormAddMembers : Form
    {
        public FormAddMembers()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MembersTBLTableAdapter ada = new DataSet1TableAdapters.MembersTBLTableAdapter();
            ada.Addmember(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text);
            Close();

        }

        private void FormAddMembers_Load(object sender, EventArgs e)
        {
            
        }
    }
}
