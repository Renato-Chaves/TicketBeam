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
        String movieDate;
        String movieDateTxt;

        public BuyTickets()
        {
            InitializeComponent();
            db = MyDBConnection.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public static BuyTickets GetInstance()
        {
            if (instance == null) instance = new BuyTickets();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
            LoadMovieInfo();
            MovieSession.Text = this.movieSession;
            MovieDate.Text = this.movieDate;
            LoadForm();
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
            if(ticketForm == null) ticketForm = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ticketForm.ClearTickets();
            ticketForm.FormBorderStyle = FormBorderStyle.None;
            TicketPanel.Controls.Add(ticketForm);
            ticketForm.Show();
            ticketForm.FillTickets(GetMovieId(), GetMovieTime(), GetMovieDate());
        }

        public String GetMovieDate()
        {
            movieDateTxt = DateTime.Now.Year.ToString() + "-" + movieDate[3] + movieDate[4] + "-" + movieDate[0] + movieDate[1];
            return movieDateTxt;
        }

        public String GetMovieTime()
        {
            return MovieSession.Text;
        }

        public int GetMovieId()
        {
            return movieId;
        }

        private void PurchaseTickets(object sender, EventArgs e)
        {
            String movieDate = GetMovieDate();

            List<string> tickets = ticketForm.GetTickets();

            foreach (string ticketsItem in tickets)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO seats VALUES (@movieId, @movieDate,@movieTime,@seat,@userId)");
                cmd.Parameters.AddWithValue("@movieId", movieId);
                cmd.Parameters.AddWithValue("@movieDate", movieDate);
                cmd.Parameters.AddWithValue("@movieTime", MovieSession.Text);
                cmd.Parameters.AddWithValue("@seat", ticketsItem);
                cmd.Parameters.AddWithValue("@userId", db.GetUser());
                db.Querry(cmd);
                MainPage.GetInstance().SwitchToPage();
                this.Hide();
            }
        }
    }
}
