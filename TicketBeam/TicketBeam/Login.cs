using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBeam
{
    public partial class Login : Form
    {

        MainPage mainPage;
        MyDBConnection db;
        private static Login instance;
        private int cd_user;

        public Login()
        {
            db = MyDBConnection.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public static Login GetInstance()
        {
            if (instance == null) instance = new Login();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
        }

        private void CreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register.GetInstance().SwitchToPage();
        }


        private void Login_btn_Click(object sender, EventArgs e)
        {
            if(StringCheck(UsernameInput.Text) && StringCheck(PasswordInput.Text))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select cd_user from users where nm_user=@UserName and password=@UserPass");
                    cmd.Parameters.AddWithValue("@UserName", UsernameInput.Text);
                    cmd.Parameters.AddWithValue("@UserPass", PasswordInput.Text);
                    DataSet dataSet = db.QuerryToDataSet(cmd);

                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        cd_user = (int)dataSet.Tables[0].Rows[0]["cd_user"];
                        db.setUser(cd_user);
                        //Change to MainPage
                        this.Hide();
                        MainPage.GetInstance().SwitchToPage();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha incorreto(s).");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Banco de dados fora de operação.\nTente novamente mais tarde.\n"+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            
        }

        private void ClearInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
        }

        private bool StringCheck(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }
    }
}
