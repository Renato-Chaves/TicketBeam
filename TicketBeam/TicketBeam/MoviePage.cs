using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

        private static MoviePage instance;
        LinkLabel[] movieTimes;
        LinkLabel[] movieDates;
        BuyTickets buyTickets;
        MyDBConnection db;
        MainPage mainPage;
        int movieId;
        int selectedDay = 0;
        int selectedSession = 0;

        public MoviePage()
        {
            InitializeComponent();
            db = MyDBConnection.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
            movieDates = new LinkLabel[7] { MovieDate1, MovieDate2, MovieDate3, MovieDate4, MovieDate5, MovieDate6, MovieDate7 };
            movieTimes = new LinkLabel[5] { MovieTime1, MovieTime2, MovieTime3, MovieTime4, MovieTime5 };
        }

        public static MoviePage GetInstance()
        {
            if (instance == null) instance = new MoviePage();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
            LoadSessions();
            LoadMovieInfo();
            LoadDates();
        }

        public void SetMovie(int _movieId)
        {
            this.movieId = _movieId;
        }

        private void BackArrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage.GetInstance().SwitchToPage();
        }

        private void BuyTickets_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTickets.GetInstance().SetMovieId(this.movieId);
            BuyTickets.GetInstance().SetDateSession(GetSelectedDate(), GetSelectedSession());
            BuyTickets.GetInstance().SwitchToPage();
        }

        private void LoadMovieInfo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from movies where cd_movie = @movieCd");
            cmd.Parameters.AddWithValue("@movieCd", movieId);
            DataRow row = db.QuerryToRow(cmd);

            MovieCover.Load(row["link_movie"].ToString());
            MovieTitle.Text = row["nm_movie"].ToString();
            MovieDuration.Text = "Duração: " + row["duration"].ToString();


        }

        private void LoadDates()
        {
            //MySqlCommand cmd = new MySqlCommand("SELECT date_start, date_end, DATE(ADDDATE(curdate(), INTERVAL @i:=@i+.5 DAY)) AS date FROM sessions HAVING  @i < DATEDIFF(date_end, date_start) and date >= date_start and date <= date_end Limit 7");
            MySqlCommand cmd = new MySqlCommand("SELECT * from sessions where id_movie = @movieId limit 1");
            cmd.Parameters.AddWithValue("@movieId", movieId);
            DataTable dt = db.QuerryToDataSet(cmd).Tables[0];


            DateTime StartDate = Convert.ToDateTime(dt.Rows[0]["date_start"].ToString());
            DateTime EndDate = Convert.ToDateTime(dt.Rows[0]["date_end"].ToString());
            int DayInterval = 1;

            List<DateTime> dateList = new List<DateTime>();
            int j = 7;
            while (StartDate.AddDays(DayInterval) <= EndDate && j > 0)
            {
                StartDate = StartDate.AddDays(DayInterval);
                dateList.Add(StartDate);
                //MessageBox.Show(StartDate.ToString());
                j--;
            }


            int i = 0;
            while (i < 5)
            {
                movieDates[i].Text = string.Empty;
                movieDates[i].LinkVisited = false;
                movieDates[i].LinkBehavior = LinkBehavior.NeverUnderline;
                i++;
            }
            i = 0;
            foreach (DateTime date in dateList)
            {
                movieDates[i].Text = date.ToString().Substring(0, 5);

                i++;
            }
            selectedDay = 0;
            SelectDate();
        }

        private void LoadSessions()
        {
            MySqlCommand cmd = new MySqlCommand("select * from sessions where id_movie = @movieCd");
            cmd.Parameters.AddWithValue("@movieCd", movieId);
            DataTable dt = db.QuerryToDataSet(cmd).Tables[0];

            int i = 0;

            while (i < 5)
            {
                movieTimes[i].Text = string.Empty;
                movieTimes[i].LinkVisited = false;
                movieTimes[i].LinkBehavior = LinkBehavior.NeverUnderline;
                movieDates[i].LinkVisited = false;
                movieDates[i].LinkBehavior = LinkBehavior.NeverUnderline;
                i++;
            }

            i = 0;
            foreach (DataRow row in dt.Rows)
            {

                movieTimes[i].Text = row["movie_time"].ToString();

                i++;
            }

            selectedSession = 0;
            SelectSession();

        }

        private void Date_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (LinkLabel movieDate in movieDates)
            {
                if ((sender as LinkLabel) == movieDate)
                {
                    selectedDay = i;
                    SelectDate();
                    break;
                }
                i++;
            }
        }

        private void Session_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (LinkLabel movieTime in movieTimes)
            {
                if ((sender as LinkLabel) == movieTime)
                {
                    selectedSession = i;
                    SelectSession();
                    break;
                }
                i++;
            }
        }

        private void SelectDate()
        {
            for (int i = 0; i < 7; i++)
            {
                if (selectedDay != i)
                {
                    movieDates[i].LinkBehavior = LinkBehavior.NeverUnderline;
                    movieDates[i].LinkVisited = false;
                }
                else
                {
                    movieDates[i].LinkBehavior = LinkBehavior.AlwaysUnderline;
                    movieDates[i].LinkVisited = true;
                }
            }
        }

        private void SelectSession()
        {
            for (int i = 0; i < 5; i++)
            {
                if (selectedSession != i)
                {
                    movieTimes[i].LinkBehavior = LinkBehavior.NeverUnderline;
                    movieTimes[i].LinkVisited = false;
                }
                else
                {
                    movieTimes[i].LinkBehavior = LinkBehavior.AlwaysUnderline;
                    movieTimes[i].LinkVisited = true;
                }
            }
        }

        private string GetSelectedDate()
        {
            return movieDates[selectedDay].Text.ToString();
        }

        private string GetSelectedSession()
        {
            return movieTimes[selectedSession].Text.ToString();
        }
    }
}
