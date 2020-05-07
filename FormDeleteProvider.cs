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
    public partial class FormDeleteProvider : Form
    {
        public FormDeleteProvider()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ProviderTBLTableAdapter ada = new DataSet1TableAdapters.ProviderTBLTableAdapter();
            ada.Deleteprovider("False", metroTextBox8.Text);
            Close();

        }
    }
}
