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
    public partial class MoviePage : Form
    {

        MainPage mainPage;
        BuyTickets buyTickets;

        public MoviePage(MainPage _mainPage)
        {
            mainPage = _mainPage;
            InitializeComponent();
        }

        private void BackArrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }

        private void BuyTickets_btn_Click(object sender, EventArgs e)
        {
            if (buyTickets == null)
            {
                buyTickets = new BuyTickets(this);
                buyTickets.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Hide();
            buyTickets.Show();
        }

    }
}
