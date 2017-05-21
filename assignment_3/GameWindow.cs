using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_3
{
    public partial class GameWindow : Form
    {
		/// <summary>
		///		Unsure whether to use methods with parameters or keep the method as they are. 
		///		The way the methods are at the moment take advantage of the varaibles all being contained in the same class.
		///		This means they are accessable when the game runs.
		///		I'm not sure if this is the correct way???
		///		The problem with this way of doing things means less unit test can be performed due to the methods reliablitiy on a game instance.
		/// </summary>
		
        public GameWindow()
        {
            InitializeComponent();
        }

		private static string teamOne, teamTwo;
		private void GameWindow_Load(object sender, EventArgs e)
        {
            //  Creates the StartWindow straigth away, hiding GameWindow.
            //  This allows information to be passed from the child to the parent window while also allowing the 
            //  child window to be closed afterwards.
            StartWindow sw = new StartWindow();
            this.Hide();
            sw.ShowDialog();
			if (sw.State == true)
			{
				teamOne = sw.TeamOne;
				teamTwo = sw.TeamTwo;

				//  Loads selected teams flag image into GameWindow picturebox using Image getter.
				SizeImage(teamOneGmeWinPicBx, sw.TeamOneSrtWinPicBx);
				SizeImage(teamTwoGmeWinPicBx, sw.TeamTwoSrtWinPicBx);

				//  Updates items in each teams player combo box relative to the selected teams.
				UpdatesTeamOneCmboBx();
				UpdatesTeamTwoCmboBx();

				sw.Close();
				this.Show();
			}
			else
			{
				Application.Exit();
			}
        }
        
        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startBtn.Enabled = false;
            pauseBtn.Enabled = true;
            start = true;
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startBtn.Enabled = true;
            pauseBtn.Enabled = false;
            start = false;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            start = false;
            timer1.Stop();
            startBtn.Enabled = false;
            pauseBtn.Enabled = false;
            endBtn.Enabled = false;
            EndGameStatsDisplay(teamOneScore, teamTwoScore, teamOne, teamTwo);
        }
        
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
			PerformReset();

			StartWindow sw = new StartWindow();
			this.Hide();
			sw.ShowDialog();

			if (sw.State == true)
			{
				teamOne = sw.TeamOne;
				teamTwo = sw.TeamTwo;

				SizeImage(teamOneGmeWinPicBx, sw.TeamOneSrtWinPicBx);
				SizeImage(teamTwoGmeWinPicBx, sw.TeamTwoSrtWinPicBx);

				//  Updates items in each teams player combo box relative to the selected teams.
				UpdatesTeamOneCmboBx();
				UpdatesTeamTwoCmboBx();

				sw.Close();
				this.Show();
			}
			else
			{
				Application.Exit();
			}
		}

		private static bool start = false, playerOne = false, playerTwo = false;
		private static int teamOneScore, teamTwoScore;
		private static int teamOneTries = 0;
        private void TeamOneTryBtn_Click(object sender, EventArgs e)
        {
            if (start && playerOne)
            {
                AddTry(ref teamOneScore);
                teamOneScoreLbl.Text = teamOneScore.ToString();
                teamOneTries++;                
                ListBoxAdd(ListBoxStringBuilder(teamOne, "try", teamOnePlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamTwoTries = 0;
        private void TeamTwoTryBtn_Click(object sender, EventArgs e)
        {
            if (start && playerTwo)
            {
                AddTry(ref teamTwoScore);
                teamTwoScoreLbl.Text = teamTwoScore.ToString();
                teamTwoTries++;                
                ListBoxAdd(ListBoxStringBuilder(teamTwo, "try", teamTwoPlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamOneConversions = 0;
        private void TeamOneConvertBtn_Click(object sender, EventArgs e)
        {
            if (start && playerOne)
            {
                AddConversion(ref teamOneScore);
                teamOneScoreLbl.Text = teamOneScore.ToString();
                teamOneConversions++;                
                ListBoxAdd(ListBoxStringBuilder(teamOne, "conversion", teamOnePlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamTwoConversions = 0;
        private void TeamTwoConvertBtn_Click(object sender, EventArgs e)
        {
            if (start && playerTwo)
            {
                AddConversion(ref teamTwoScore);
                teamTwoScoreLbl.Text = teamTwoScore.ToString();
                teamTwoConversions++;
                ListBoxAdd(ListBoxStringBuilder(teamTwo, "conversion", teamTwoPlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamOnePenalties = 0;
        private void TeamOnePenBtn_Click(object sender, EventArgs e)
        {
            if (start && playerOne)
            {
                AddPenalty(ref teamOneScore);
                teamOneScoreLbl.Text = teamOneScore.ToString();
                teamOnePenalties++;
                ListBoxAdd(ListBoxStringBuilder(teamOne, "penalty", teamOnePlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamTwoPenalties = 0;
        private void TeamTwoPenBtn_Click(object sender, EventArgs e)
        {
            if (start && playerTwo)
            {
                AddPenalty(ref teamTwoScore);
                teamTwoScoreLbl.Text = teamTwoScore.ToString();
                teamTwoPenalties++;
                ListBoxAdd(ListBoxStringBuilder(teamTwo, "penalty", teamTwoPlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamOneDropKicks = 0;
        private void TeamOneDropBtn_Click(object sender, EventArgs e)
        {
            if (start && playerOne)
            {
                AddDropKick(ref teamOneScore);
                teamOneScoreLbl.Text = teamOneScore.ToString();
                teamOneDropKicks++;
                ListBoxAdd(ListBoxStringBuilder(teamOne, "drop kick", teamOnePlyrSlt.SelectedItem.ToString()));
            }
        }
        private static int teamTwoDropKicks = 0;
        private void TeamTwoDropBtn_Click(object sender, EventArgs e)
        {
            if (start && playerTwo)
            {
                AddDropKick(ref teamTwoScore);
                teamTwoScoreLbl.Text = teamTwoScore.ToString();
                teamTwoDropKicks++;
                ListBoxAdd(ListBoxStringBuilder(teamTwo, "drop kick", teamTwoPlyrSlt.SelectedItem.ToString()));
            }
        }

        private void TeamOnePlyrSlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerOne = true;
        }
        private void TeamTwoPlyrSlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerTwo = true;
        }

        private int min = 0, sec = 0, ms = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder time = new StringBuilder();            
            TimerEngine();
            if (min < 10)
            {
                time.Append("0");
            }
            time.Append(min);            
            if (sec < 10)
            {
                time.Append(":0");
            }            
            else
            {
                time.Append(":");
            }
            time.Append(sec);

            timerLbl.Text = time.ToString();
        }
        public void TimerEngine()
        {
            ms++;
            if (ms > 9)
            {
                sec++;
                ms = 0;
            }
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
        }

		private void SizeImage(PictureBox pb, Image img)
		{
			pb.Image = img;
			pb.SizeMode = PictureBoxSizeMode.StretchImage;
		}

        private void UpdatesTeamOneCmboBx()
        {
            switch (teamOne)
            {
                case "Argentia":
                    teamOnePlyrSlt.Items.Add("Juan Hernandez");
                    teamOnePlyrSlt.Items.Add("Agustin Creevy");
                    teamOnePlyrSlt.Items.Add("Marcos Ayerza");
                    break;
                case "Australia":
                    teamOnePlyrSlt.Items.Add("Israel Folau");
                    teamOnePlyrSlt.Items.Add("David Pocock");
                    teamOnePlyrSlt.Items.Add("Nick Cummings");
                    break;
                case "England":
                    teamOnePlyrSlt.Items.Add("Dylan Hartley");
                    teamOnePlyrSlt.Items.Add("Owen Farrell");
                    teamOnePlyrSlt.Items.Add("James Haskell");
                    break;
                case "France":
                    teamOnePlyrSlt.Items.Add("Louis Picamoles");
                    teamOnePlyrSlt.Items.Add("Frederic Michalak");
                    teamOnePlyrSlt.Items.Add("Thierry Dusautoir");
                    break;
                case "New Zealand":
                    teamOnePlyrSlt.Items.Add("Beauden Barrett");
                    teamOnePlyrSlt.Items.Add("Damian McKenzie");
                    teamOnePlyrSlt.Items.Add("Nehe Milner-Skudder");
                    break;
                case "South Africa":
                    teamOnePlyrSlt.Items.Add("Victor Matfield");
                    teamOnePlyrSlt.Items.Add("Bryan Habana");
                    teamOnePlyrSlt.Items.Add("Francois Louw");
                    break;
            }
        }
        private void UpdatesTeamTwoCmboBx()
        {
            switch (teamTwo)
            {
                case "Argentia":
                    teamTwoPlyrSlt.Items.Add("Juan Hernandez");
                    teamTwoPlyrSlt.Items.Add("Agustin Creevy");
                    teamTwoPlyrSlt.Items.Add("Marcos Ayerza");
                    break;
                case "Australia":
                    teamTwoPlyrSlt.Items.Add("Israel Folau");
                    teamTwoPlyrSlt.Items.Add("David Pocock");
                    teamTwoPlyrSlt.Items.Add("Nick Cummings");
                    break;
                case "England":
                    teamTwoPlyrSlt.Items.Add("Dylan Hartley");
                    teamTwoPlyrSlt.Items.Add("Owen Farrell");
                    teamTwoPlyrSlt.Items.Add("James Haskell");
                    break;
                case "France":
                    teamTwoPlyrSlt.Items.Add("Louis Picamoles");
                    teamTwoPlyrSlt.Items.Add("Frederic Michalak");
                    teamTwoPlyrSlt.Items.Add("Thierry Dusautoir");
                    break;
                case "New Zealand":
                    teamTwoPlyrSlt.Items.Add("Beauden Barrett");
                    teamTwoPlyrSlt.Items.Add("Damian McKenzie");
                    teamTwoPlyrSlt.Items.Add("Nehe Milner-Skudder");
                    break;
                case "South Africa":
                    teamTwoPlyrSlt.Items.Add("Victor Matfield");
                    teamTwoPlyrSlt.Items.Add("Bryan Habana");
                    teamTwoPlyrSlt.Items.Add("Francois Louw");
                    break;
            }
        }

		//	Points methods
		public void AddTry(ref int value)
		{
			value += 7;
		}
		public void AddConversion(ref int value)
		{
			value += 2;
		}
		public void AddPenalty(ref int value)
		{
			value += 3;
		}
		public void AddDropKick(ref int value)
		{
			value += 3;
		}

		private string ListBoxStringBuilder(string aTeam, string form, string player)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(aTeam + " scored a " + form + " at: " + timerLbl.Text + " by " + player);
			return sb.ToString();
		}

		private void EndGameStatsDisplay(int scoreOne, int scoreTwo, string tOne, string tTwo)
        {
            ListBoxAdd("=== MATCH STATS ===");
            ListBoxAdd(Winner(scoreOne, scoreTwo, tOne, tTwo));
            ListBoxAdd(teamOne + " stats:");
			DetermineStatConcat(teamOneTries, teamOneConversions, teamOnePenalties, teamOneDropKicks);
			ListBoxAdd(teamTwo + " stats:");
			DetermineStatConcat(teamTwoTries, teamTwoConversions, teamTwoPenalties, teamTwoDropKicks);
		}

		public void DetermineStatConcat(int tries, int conversions, int penalties, int dropKicks)
		{
			if (tries != 0)
			{
				ListBoxAdd("Tries: " + tries.ToString());
			}
			if (conversions != 0)
			{
				ListBoxAdd("Conversions: " + conversions.ToString());
			}
			if (penalties != 0)
			{
				ListBoxAdd("Penalties: " + penalties.ToString());
			}
			if (dropKicks != 0)
			{
				ListBoxAdd("Drop Kicks: " + dropKicks.ToString());
			}
		}

		//  Determands the winner
		public string Winner(int scoreOne, int scoreTwo, string tOne, string tTwo)
		{
			if (scoreOne == scoreTwo)
			{
				return "It is a draw";
			}
			else if (scoreOne > scoreTwo)
			{
				return "WINNER is: " + tOne;
			}
			else
			{
				return "WINNER is: " + tTwo;
			}
		}

		private void ListBoxAdd(string value)
        {
            listBox1.Items.Add(value);
        }
	
		//	Resets stats for new game
		private void PerformReset()
		{
			ms = sec = min = 0;
			timerLbl.Text = "00:00";
			teamOneScoreLbl.Text = teamTwoScoreLbl.Text = "0";

			teamOneScore = teamTwoScore = teamOneTries = teamTwoTries = teamOneConversions =
			teamTwoConversions = teamOnePenalties = teamTwoPenalties = teamOneDropKicks = 
			teamTwoDropKicks = 0;

			listBox1.Items.Clear();
			teamOnePlyrSlt.Items.Clear();
			teamOnePlyrSlt.Text = "Team One Players";
			teamTwoPlyrSlt.Items.Clear();
			teamTwoPlyrSlt.Text = "Team Two Players";

			playerOne = playerTwo = false;
			startBtn.Enabled = pauseBtn.Enabled = endBtn.Enabled = true;
		}
	}
}
