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
    public partial class TicketGenerator : Form
    {
        public static string UserName;
        public static string UserSurname;

        public TicketGenerator()
        {
            InitializeComponent();
            
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserSurname = SurnameTextBox.Text;
            MessageBox.Show(UserName+" "+UserSurname+"\r\n"+Movie.MovieName+"\r\n"+Movie.MovieHall+"\r\n"+Movie.MovieTime+"\r\n"+(HallScreen.ClickedButtons.Count*Movie.MoviePrice).ToString()+" AZN", "Your Ticket");
        }
    }
}
