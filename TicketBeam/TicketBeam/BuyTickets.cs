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

namespace TicketBeam
{
    public partial class BuyTickets : Form
    {

        private static BuyTickets instance;
        MoviePage moviePage;
        MyDBConnection db;
        Form1 ticketForm;
        int movieId;
        string movieSession;
        string movieDate;

        public BuyTickets()
        {
            db = MyDBConnection.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            LoadForm();
        }

        public static BuyTickets GetInstance()
        {
            if (instance == null) instance = new BuyTickets();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
            // LoadMovieInfo();
            MovieSession.Text = this.movieSession;
            MovieDate.Text = this.movieDate;
        }

        public void SetMovieId(int _movieId)
        {
            this.movieId = _movieId;
        }

        public void SetDateSession(string _movieDate, string _movieSession)
        {
            movieDate = _movieDate;
            movieSession = _movieSession;
        }

        private void LoadMovieInfo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from movies where cd_movie = @movieCd");
            cmd.Parameters.AddWithValue("@movieCd", movieId);
            DataRow row = db.QuerryToRow(cmd);

            MovieTitle.Text = row["nm_movie"].ToString();


        }

        private void BackArrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoviePage.GetInstance().SwitchToPage();
        }

        private void LoadForm()
        {
            ticketForm = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ticketForm.FormBorderStyle = FormBorderStyle.None;
            TicketPanel.Controls.Add(ticketForm);
            ticketForm.Show();
        }

        private void PurchaseTickets(object sender, EventArgs e)
        {
            List<string> tickets = ticketForm.GetTickets();

            foreach (string ticketsItem in tickets)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO seats VALUES (@movieId, curdate(),@movieTime,@seat,@userId)");
                cmd.Parameters.AddWithValue("@movieId", movieId);
                cmd.Parameters.AddWithValue("@movieTime", MovieSession.Text);
                cmd.Parameters.AddWithValue("@seat", ticketsItem);
                cmd.Parameters.AddWithValue("@userIds", db.GetUser());
                db.Querry(cmd);
                MainPage.GetInstance().SwitchToPage();
                this.Hide();
            }
        }

        private void BuyTickets_Load(object sender, EventArgs e)
        {

        }
    }
}
