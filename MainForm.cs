using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChocoAn
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                //Open Login Form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    //Fixed the Close Login Bug
                    newLogin.Close();
                }
                else
                {
                    //Hello 
                    UserID = newLogin.UserID;
                    loggedIn = 1;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormAddMembers addmember = new FormAddMembers();
            addmember.ShowDialog();

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FormUpdateMember updateMember = new FormUpdateMember();
            updateMember.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FormDeleteMember deleteMember = new FormDeleteMember();
            deleteMember.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FormAddProvider addProvider = new FormAddProvider();
            addProvider.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            FormUpdateProvider updateProvider = new FormUpdateProvider();
            updateProvider.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            FormDeleteProvider deleteProvider = new FormDeleteProvider();
            deleteProvider.ShowDialog();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            FormServiceRecord serviceReord = new FormServiceRecord();
            serviceReord.ShowDialog();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

        }

        private void metroButton10_Click_1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ServiceDirectoryTBLTableAdapter adap = new DataSet1TableAdapters.ServiceDirectoryTBLTableAdapter();
            DataTable dt = adap.GetData();

            string filename = @"D:\Test\ServiceDirectory.txt";
            dt.ToCSV(filename);

            MessageBox.Show("Records Created");
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton12_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ServiceRecordTBLTableAdapter adap = new DataSet1TableAdapters.ServiceRecordTBLTableAdapter();
            DataTable dt = adap.GetData();

            string filename = @"D:\Test\MainAccounting.txt";
            dt.ToCSV(filename);

            MessageBox.Show("Records Created");
        }
    }

    public static class CSVUtlity
    {
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
} 

