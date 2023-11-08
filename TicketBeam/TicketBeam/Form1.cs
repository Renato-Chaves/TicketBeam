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
    public partial class Form1 : Form
    {

        int selectedTickets = 0;
        List<String> tickets = new List<String>();

        public Form1()
        {
            InitializeComponent();
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
            else //Selecting
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
            String btn = (sender as Button).Name;
            (sender as Button).Text = btn;
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
