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
    public partial class FormDeleteMember : Form
    {
        public FormDeleteMember()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MembersTBLTableAdapter ada = new DataSet1TableAdapters.MembersTBLTableAdapter();
            ada.Deletemember("False",metroTextBox8.Text);
            Close();
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
