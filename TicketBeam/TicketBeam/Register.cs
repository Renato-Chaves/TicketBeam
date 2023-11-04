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
        public Register(Login _login)
        {
            this.login = _login;
            InitializeComponent();
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchPages();
        }

        private void SwitchPages()
        {
            login.FillRegister(this);
            login.Show();
            this.Hide();

            ClearInputs();
        }

        private void ClearInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            PasswordConfirmInput.Text = string.Empty;
        }
    }
}
