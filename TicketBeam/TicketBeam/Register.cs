using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBeam
{
    public partial class Register : Form
    {
        Login login;
        private static Register instance;
        public Register()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void SwitchToPage()
        {
            this.Show();
        }

        public static Register GetInstance()
        {
            if (instance == null) instance = new Register();
            return instance;
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.GetInstance().SwitchToPage();
        }

        private void ClearInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            PasswordConfirmInput.Text = string.Empty;
        }
    }
}
