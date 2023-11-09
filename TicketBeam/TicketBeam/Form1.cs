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
using TicketBeam.Properties;

namespace TicketBeam
{
    public partial class Form1 : Form
    {

        int selectedTickets = 0;
        List<String> tickets = new List<String>();
        MyDBConnection db;
        Button[] seats;

        public Form1()
        {
            db = MyDBConnection.GetInstance();
            InitializeComponent();
            seats = new Button[107] { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17,
                                      B1, B2, B3, B4,     B6, B7, B8, B9, B10, B11, B12,      B14, B15, B16, B17,
                                      C1, C2, C3, C4,     C6, C7, C8, C9, C10, C11, C12,      C14, C15, C16, C17,
                                      D1, D2, D3, D4,     D6, D7, D8, D9, D10, D11, D12,      D14, D15, D16, D17,
                                      E1, E2, E3, E4,     E6, E7, E8, E9, E10, E11, E12,      E14, E15, E16, E17,
                                      F1, F2, F3, F4,     F6, F7, F8, F9, F10, F11, F12,      F14, F15, F16, F17,
                                      G1, G2, G3, G4,     G6, G7, G8, G9, G10, G11, G12,      G14, G15, G16, G17};
            UpdateTicketText();
        }

        public void FillTickets(int movieId, string movieTime, string movieDate)
        {
            MySqlCommand cmd = new MySqlCommand("select * from seats where id_movie = @movieId and movie_time = @movieTime and date_marked = @movieDate");
            cmd.Parameters.AddWithValue("@movieId", movieId);
            cmd.Parameters.AddWithValue("@movieTime", movieTime);
            cmd.Parameters.AddWithValue("@movieDate", movieDate);
            DataTable dt = db.QuerryToDataSet(cmd).Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                foreach (Button seat in seats)
                {
                    if (seat.Name.Equals(dr["seat"].ToString())){
                        seat.Image = Resources.OccupiedSeat;
                        seat.BackColor = Color.FromArgb(255, 31, 0);
                    }
                }
            }


        }

        public void ClearTickets()
        {
            foreach (Button seat in seats)
            {
                seat.Image = null;
                seat.BackColor = Color.FromArgb(77, 73, 255);
                seat.Text = String.Empty;

            }
            selectedTickets = 0;
            tickets.Clear();
            UpdateTicketText();
        }

        void btn_click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

            /*            btn.BackColor = Color.FromArgb(255, 138, 0);
            */
            if (btn.BackColor == Color.FromArgb(255, 138, 0)) //Deselecting
            {
                int i = 0;
                tickets.RemoveAt(tickets.IndexOf(btn.Name));
                btn.BackColor = Color.FromArgb(77, 73, 255);
                selectedTickets--;
            }
            else if(btn.BackColor == Color.FromArgb(77, 73, 255))//Selecting
            {
                if (selectedTickets < 10)
                {
                    tickets.Add(btn.Name);
                    selectedTickets++;

                    btn.BackColor = Color.FromArgb(255, 138, 0);
                    btn.Text = btn.Name;
                }
            }
            UpdateTicketText();
        }
        void btn_hover(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.FromArgb(77, 73, 255) || (sender as Button).BackColor == Color.FromArgb(255, 138, 0))
            {
                String btn = (sender as Button).Name;
                (sender as Button).Text = btn;
            }
        }
        void btn_leave(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn.BackColor == Color.FromArgb(77, 73, 255))
            {
                btn.Text = String.Empty;
            }

        }

        public List<string> GetTickets()
        {
            return tickets;
        }

        private void UpdateTicketText()
        {
            TicketLabel.Text = string.Empty;
            int i = 0;
            foreach (string ticket in tickets)
            {
                TicketLabel.Text += ticket;
                if(i < tickets.Count-1) {
                    TicketLabel.Text += ", ";
                }
                i++;
            }
        }


    }
}
