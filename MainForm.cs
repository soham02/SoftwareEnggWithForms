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
    }
} 

