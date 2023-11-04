using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBeam
{
    public partial class MainPage : Form
    {

        string cd_user;
        Login login;
        MyTicketsPage myTicketsPage;
        MoviePage moviePage;

        public MainPage(Login _login, string _cd_user)
        {
            AdmCheck(_login, _cd_user);
            InitializeComponent();
        }

        public void AdmCheck(Login _login, string _cd_user)
        {
            this.cd_user = _cd_user;
            this.login = _login;
        }

        private void MyTickets_btn_Click(object sender, EventArgs e)
        {
            if (myTicketsPage == null)
            {
                myTicketsPage = new MyTicketsPage(this);
                myTicketsPage.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Hide();
            myTicketsPage.Show();
        }

        private void MovieCover_Click(object sender, EventArgs e)
        {
            if (moviePage == null)
            {
                moviePage = new MoviePage(this);
                moviePage.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Hide();
            moviePage.Show();
        }
    }
}
