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
    public partial class FormAddProvider : Form
    {
        public FormAddProvider()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ProviderTBLTableAdapter ada = new DataSet1TableAdapters.ProviderTBLTableAdapter();
            ada.Addprovider(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text);
            Close();

        }
    }
}
