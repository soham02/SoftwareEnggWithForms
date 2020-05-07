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
    public partial class FormUpdateProvider : Form
    {
        public FormUpdateProvider()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ProviderTBLTableAdapter ada = new DataSet1TableAdapters.ProviderTBLTableAdapter();
            ada.Updateprovider(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text,
                metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text, metroTextBox8.Text);
            Close();

        }
    }
}
