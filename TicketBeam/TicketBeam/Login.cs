using Microsoft.Win32;
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

        Register register;
        MainPage mainPage;
        private string cd_user;

        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void CreateAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (register == null) register = new Register(this);
            this.Hide();
            register.StartPosition = FormStartPosition.CenterScreen;
            register.Show();
            ClearInputs();
        }

        public void FillRegister(Register _register)
        {
            this.register = _register;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (mainPage == null) mainPage = new MainPage(this, cd_user);
            else mainPage.AdmCheck(this, cd_user);
            this.Hide();
            mainPage.StartPosition = FormStartPosition.CenterScreen;
            ClearInputs();
            mainPage.Show();
        }

        private void ClearInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
        }
    }
}
