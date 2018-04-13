using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAppProject
{
    public partial class Movie2Hall : Form
    {
        
            
        public int LeftPosition;
        public int TopPosition;
        public int SeatCount = 10;
        public int RowCount = 5;

        List<string> Seats = new List<string>();
        List<Button> ClickedButtons = new List<Button>();

        public void OnClick(object obj, EventArgs eve)
        {
            var ClickedSeat = obj as Button;

            if (ClickedSeat.BackColor == Color.DarkGray)
            {
                ClickedSeat.BackColor = Color.Black;
                ClickedSeat.ForeColor = Color.DarkGray;
            }
            else
            {
                ClickedSeat.BackColor = Color.DarkGray;
                ClickedSeat.ForeColor = Color.Black;
            }
            if (ClickedSeat.BackColor == Color.Black)
            {
                Seats.Add(ClickedSeat.Text);
            }
            if (ClickedSeat.BackColor == Color.Black)
            {
                ClickedButtons.Add(ClickedSeat);
            }
            if (ClickedSeat.BackColor == Color.DarkGray)
            {
                ClickedButtons.Remove(ClickedSeat);
            }
        }

        public Movie2Hall()
        {
            InitializeComponent();
            for (int i = 1; i <= RowCount; i++)
            {
                for (int j = 1; j <= SeatCount; j++)
                {
                    Button Seat = new Button();
                    Seat.Text = j.ToString();
                    Seat.Width = 40;
                    Seat.Height = 40;
                    Seat.Left = LeftPosition;
                    Seat.Top = TopPosition;
                    LeftPosition += Seat.Width;
                    Seat.BackColor = Color.DarkGray;
                    Seat.ForeColor = Color.Black;
                    Seat.FlatStyle = FlatStyle.Flat;
                    Seat.FlatAppearance.BorderSize = 0;
                    Controls.Add(Seat);
                    Seat.Click += new EventHandler(OnClick);
                }
                SeatCount -= 2;
                LeftPosition = 40;
                TopPosition += 40;

                switch (SeatCount)
                {
                    case 6:
                        LeftPosition = 80;
                        break;
                    case 4:
                        LeftPosition = 120;
                        break;
                    case 2:
                        LeftPosition = 160;
                        break;
                    default:
                        LeftPosition = 40;
                        break;
                }
            }
        }

        private void MoviShower_Click(object sender, EventArgs e)
        {
            Form TicketGenerator = new TicketGenerator();
            for (int i = 0; i < Seats.Count; i++)
            {
                SeatsTextBox.Text += Seats[i] + ", ";
            }

            foreach (var button in ClickedButtons)
            {
                button.Enabled = false;
                button.ForeColor = Color.DarkGray;
            }

            TicketGenerator.Show();
        }
    }
}
