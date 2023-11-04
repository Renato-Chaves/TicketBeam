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
    public partial class MyTicketsPage : Form
    {

        MainPage mainPage;

        public MyTicketsPage(MainPage _mainPage)
        {
            this.mainPage = _mainPage;
            InitializeComponent();
        }

        private void BackArrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage.Show();
        }
    }
}
