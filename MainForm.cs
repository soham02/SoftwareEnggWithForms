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
using System.Threading;

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

        private void metroButton9_Click_1(object sender, EventArgs e)
        {            
            DataSet1TableAdapters.MembersTBL1TableAdapter ada = new DataSet1TableAdapters.MembersTBL1TableAdapter();
            DataTable dt = ada.GetData();
            
            int number = dt.Rows.Count;
            
            for (int i = 0; i < number; i++)                
            {
                int service = 0;
                
                int currentMember = 100000000 + i;
                DataTable dt1 = ada.GetDataByMemberNumber(currentMember);

                string filestart = @"D:\Test\";
                string nameValue = dt1.Rows[0][1].ToString();
                string under = "_";
                string date = DateTime.Today.ToString("dd-MM-yyyy");
                string txt = ".txt";
                string final = filestart + nameValue + under + date + txt;
                dt1.ToCSV(final);

                DataSet1TableAdapters.ServiceRecordTBL1TableAdapter adap = new DataSet1TableAdapters.ServiceRecordTBL1TableAdapter();
                DataTable dt2 = adap.GetData();
                int number1 = dt2.Rows.Count;

                for (int j = 0; j < number1; j++)
                {
                    int id = 21 + j;
                    DataTable dt3 = adap.GetDataByID(id);
                                        
                    int member = Convert.ToInt32(dt3.Rows[0][1]);

                    if (member == currentMember)
                    {
                        DataTable dt4 = adap.GetDataByMemberNumber(currentMember);                                        
                        dt4.ToCSV(final);
                        service++;
                    }
                    if(service == 0)
                    {
                        //No service recorded
                    }
                }                
            }
                      
            MessageBox.Show("Records Created");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ProviderTBL1TableAdapter ada = new DataSet1TableAdapters.ProviderTBL1TableAdapter();
            DataTable dt = ada.GetData();

            int number = dt.Rows.Count;

            for (int i = 0; i < number; i++)
            {
                int service = 0;

                int currentProvider = 900000000 + i;
                DataTable dt1 = ada.GetDataByProviderNumber(currentProvider);

                string filestart = @"D:\Test\";
                string nameValue = dt1.Rows[0][1].ToString();
                string under = "_";
                string date = DateTime.Today.ToString("dd-MM-yyyy");
                string txt = ".txt";
                string final = filestart + nameValue + under + date + txt;
                dt1.ToCSV(final);

                DataSet1TableAdapters.ServiceRecordTBL2TableAdapter adap = new DataSet1TableAdapters.ServiceRecordTBL2TableAdapter();
                DataTable dt2 = adap.GetData();
                int number1 = dt2.Rows.Count;

                for (int j = 0; j < number1; j++)
                {
                    int id = 21 + j;
                    DataTable dt3 = adap.GetDataByID(id);

                    int provider = Convert.ToInt32(dt3.Rows[0][2]);
                    String services = dt3.Rows[0][3].ToString();


                    //Fees 
                    DataSet1TableAdapters.ServiceDirectoryTBLTableAdapter adapa = new DataSet1TableAdapters.ServiceDirectoryTBLTableAdapter();
                    DataTable dt4 = adapa.GetDataByServiceNumber(services);

                    double fees = Convert.ToInt32(dt4.Rows[0][1].ToString()); 

                    

                    if (provider == currentProvider)
                    {
                        DataTable dt5 = adap.GetDataByProviderNumber(currentProvider);
                        dt5.ToCSV(final);
                        service++;
                    }
                    if (service == 0)
                    {
                        //No service recorded
                    }
                }
            }
            //DataSet1TableAdapters.ProviderReportTableAdapter adap = new DataSet1TableAdapters.ProviderReportTableAdapter();
            //DataTable dt = adap.GetData();

            //string filename = @"D:\Test\ProviderReports.txt";
            //dt.ToCSV(filename);

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

