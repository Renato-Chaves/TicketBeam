using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TicketBeam
{
    public partial class Register : Form
    {
        Login login;
        private static Register instance;
        MyDBConnection db;
        public Register()
        {
            db = MyDBConnection.GetInstance();
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (!StringCheck(UsernameInput.Text) || !StringCheck(PasswordInput.Text) || !StringCheck(PasswordConfirmInput.Text))
            {
                MessageBox.Show(" Por favor complete todos os campos.");
            }
            else if (!PasswordInput.Text.Equals(PasswordConfirmInput.Text))
            {
                MessageBox.Show("Senha não condiz com sua confirmação, por favor verifique.");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO users (nm_user, password) VALUES (@userName, @userPass)");
                cmd.Parameters.AddWithValue("@userName", UsernameInput.Text);
                cmd.Parameters.AddWithValue("@userPass", PasswordInput.Text);
                db.Querry(cmd);

                Login.GetInstance().SwitchToPage();
                this.Hide();
                MessageBox.Show("Conta criada com sucesso!");
            }
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.GetInstance().SwitchToPage();
        }

        private bool StringCheck(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        private void ClearInputs()
        {
            UsernameInput.Text = string.Empty;
            PasswordInput.Text = string.Empty;
            PasswordConfirmInput.Text = string.Empty;
        }
    }
}
