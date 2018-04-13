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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i <= Hall.Halls.Count-1; i++)
            {
                HallCombo1.Items.Add(Hall.Halls[i]);
            }
            for (int i = 0; i <= Seans.Seanslar.Count - 1; i++)
            {
                SeansCombo1.Items.Add(Seans.Seanslar[i] + " : 00");
            }
        }

        private void MovieSelectionButton_Click(object sender, EventArgs e)
        {
            if (HallCombo1.Text != null && SeansCombo1.Text != null)
            {
                if (MovieRadio1.Checked == true)
                {
                    Movie TheMovie = new Movie("The Prestige", HallCombo1.Text, SeansCombo1.Text, 7);
                    Form HallScreen = new HallScreen();
                    HallScreen.Show();
                }
                else if (MovieRadio2.Checked == true)
                {
                    Movie TheMovie = new Movie("The Matrix", HallCombo1.Text, SeansCombo1.Text, 7);
                    Form HallScreen = new HallScreen();
                    HallScreen.Show();
                }
                else if (MovieRadio3.Checked == true)
                {
                    Movie TheMovie = new Movie("Saving Private Ryan", HallCombo1.Text, SeansCombo1.Text, 6);
                    Form HallScreen = new HallScreen();
                    HallScreen.Show();
                }
                else if (MovieRadio4.Checked == true)
                {
                    Movie TheMovie = new Movie("The Lord Of The Rings: The Fellowship Of The Ring", HallCombo1.Text, SeansCombo1.Text, 5);
                    Form HallScreen = new HallScreen();
                    HallScreen.Show();
                }
                else if (MovieRadio1.Checked == false && MovieRadio2.Checked == false && MovieRadio3.Checked == false && MovieRadio4.Checked == false)
                {
                    MessageBox.Show("Choose a Movie");
                }
            }
        }

        private void MoviePic1_Click(object sender, EventArgs e)
        {
            Form ThePrestigeInfo = new ThePrestigeInfo();
            ThePrestigeInfo.Show();
        }

        private void MoviePic2_Click(object sender, EventArgs e)
        {
            Form TheMatrixInfo = new TheMatrixInfo();
            TheMatrixInfo.Show();
        }

        private void MoviePic3_Click(object sender, EventArgs e)
        {
            Form SavingPrivateRyanInfo = new SavingPrivateRyanInfo();
            SavingPrivateRyanInfo.Show();
        }

        private void MoviePic4_Click(object sender, EventArgs e)
        {
            Form TheLordOfTheRingsInfo = new TheLordOfTheRingsInfo();
            TheLordOfTheRingsInfo.Show();
        }
    }
}
