using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

        private static MyTicketsPage instance;
        TextBox[] movieTitles;
        Button[] cancelBtns;
        int[] ticketIds = new int[5];
        string[] movieDate = new string[5];
        string[] movieTime = new string[5];
        string[] seat = new string[5];
        MyDBConnection db;
        MainPage mainPage;
        int offset = 0;

        public MyTicketsPage()
        {
            db = MyDBConnection.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            movieTitles = new TextBox[5] { MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5 };
            cancelBtns = new Button[5] { CancelBtn1, CancelBtn2, CancelBtn3, CancelBtn4, CancelBtn5 };
        }

        public static MyTicketsPage GetInstance()
        {
            if (instance == null) instance = new MyTicketsPage();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
            LoadTickets(0);
        }

        private void BackArrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage.GetInstance().SwitchToPage();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Button btn in cancelBtns)
            {
                if ((sender as Button) == btn)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM seats where id_movie = @movieId && date_marked = @movieDate && movie_time = @movieTime && seat = @seat && id_user = @userId");
                    DateTime dt = Convert.ToDateTime(movieDate[i].Substring(0, 10));
                    cmd.Parameters.AddWithValue("@movieId", ticketIds[i]);
                    cmd.Parameters.AddWithValue("@movieDate", dt.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@movieTime", movieTime[i]);
                    cmd.Parameters.AddWithValue("@seat", seat[i]);
                    cmd.Parameters.AddWithValue("@userId", db.GetUser());
                    try
                    {
                        db.Querry(cmd);
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    LoadTickets(0);
                    break;
                }
                i++;
            }
        }

        private void LoadTickets(int _offset)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from seats where id_user = @userId Limit 5 Offset @Offset");
            cmd.Parameters.AddWithValue("@Offset", offset);
            cmd.Parameters.AddWithValue("@userId", db.GetUser());
            DataTable dt = db.QuerryToDataSet(cmd).Tables[0];
            int i = 0;
            while (i < 5)
            {
                movieTitles[i].Text = string.Empty;
                cancelBtns[i].Visible = false;
                ticketIds[i] = -1;
                i++;
            }
            i = 0;
            foreach (DataRow row in dt.Rows)
            {
                int movieId = (int)row["id_movie"];
                MySqlCommand movieCmd = new MySqlCommand("Select nm_movie from movies where cd_movie = @movieId ");
                movieCmd.Parameters.AddWithValue("@movieId", movieId);
                DataRow movieRow = db.QuerryToRow(movieCmd);

                ticketIds[i] = movieId;
                seat[i] = (string)row["seat"];
                movieTime[i] = (string)row["movie_time"];
                movieDate[i] = row["date_marked"].ToString();
                string movieName = (string)movieRow["nm_movie"];


                movieTitles[i].Text = movieName + " | " + movieDate[i].Substring(0, 10) + " | " + movieTime[i] + " | " + seat[i];
                cancelBtns[i].Visible = true;
                i++;
            }
        }

        private string DateConverter(string date)
        {
            string result = "";

            for(int i = date.Length - 1; i >= 0; i--)
            {
                if (date[i].Equals("/")) {
                    result += "-";
                }
                else
                {
                    result += date[i];
                }
            }

            return result;
        }
    }
}
