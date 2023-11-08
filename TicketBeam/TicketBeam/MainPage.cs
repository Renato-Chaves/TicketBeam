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

        private static MainPage instance;
        int[] movieIds = new int[4];
        MyTicketsPage myTicketsPage;
        MoviePage moviePage;
        MyDBConnection db;
        Login login;

        PictureBox[] movieCovers;

        int offset = 0;
        int maxOffset;

        public MainPage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            db = MyDBConnection.GetInstance();
            InitializeComponent();

            movieCovers = new PictureBox[4] { MovieCover1, MovieCover2, MovieCover3, MovieCover4 };
            //maxOffset = (int)(db.QuerryToRow(new MySqlCommand("select Count(cd_movie) as maxOffset from movies"))["maxOffset"]);
            maxOffset = (db.QuerryToDataSet(new MySqlCommand("select cd_movie from movies")).Tables[0].Rows.Count);
            LoadCovers(0);
        }

        public static MainPage GetInstance()
        {
            if (instance == null) instance = new MainPage();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
        }

        private void MyTickets_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyTicketsPage.GetInstance().SwitchToPage();
        }

        private void MovieCover_Click(object sender, EventArgs e)
        {
            this.Hide();

            int i = 0;
            foreach (PictureBox cover in movieCovers)
            {
                if ((sender as PictureBox) == cover)
                {
                    MoviePage.GetInstance().SetMovie(movieIds[i]);
                    MoviePage.GetInstance().SwitchToPage();
                }
                i++;
            }
        }

        private void PageBtn_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name.ToString())
            {
                case "LeftArrow_btn":
                    if (offset > 0)
                    {
                        offset -= 5;
                        if (offset < 0) offset = 0;
                    }
                    break;
                case "RightArrow_btn":
                    if (offset < maxOffset - 4)
                    {
                        offset += 5;
                        if (offset > maxOffset - 4) offset = maxOffset - 4;
                    }
                    break;
            }
            LoadCovers(offset);
        }

        private void LoadCovers(int _offset)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from movies Limit 4 Offset @Offset");
            cmd.Parameters.AddWithValue("@Offset", offset);
            DataTable dt = db.QuerryToDataSet(cmd).Tables[0];
            int i = 0;

            while(i < 4)
            {
                movieIds[i] = -1;
                i++;
            }

            i = 0;
            foreach (DataRow row in dt.Rows)
            {
                movieIds[i] = (int)row["cd_movie"];
                movieCovers[i].Load(row["link_movie"].ToString());
                i++;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login.GetInstance().SwitchToPage();
            db.setUser(-1);
            this.Hide();
        }
    }
}
