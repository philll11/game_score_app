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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

		public static bool state;
		private void StartWindow_Load(object sender, EventArgs e)
        {
            teamOneCmboBx.SelectedIndex = 0;
            teamTwoCmboBx.SelectedIndex = 0;
			state = false;
        }

        private void TeamOneCmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamOneCmboBxImgUpdate();            
        }

        private void TeamTwoCmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamTwoCmboBxImgUpdate();            
        }

		public static string teamOne, teamTwo;
		private void NewGameBtn_Click(object sender, EventArgs e)
        {
            if (teamOneCmboBx.SelectedIndex != teamTwoCmboBx.SelectedIndex)
            {
                teamOne = teamOneCmboBx.SelectedItem.ToString();
                teamTwo = teamTwoCmboBx.SelectedItem.ToString();
				state = true;
                this.Hide();
            }
            else
            {
                invalidLbl.Visible = true;
            }
        }
        
        public string TeamOne
        {
            get
            {
                return teamOne;
            }
        }        
        public string TeamTwo
        {
            get
            {
                return teamTwo;
            }
        }
		public bool State
		{
			get { return state; }
		}

        public Image TeamOneSrtWinPicBx
        {
            get { return teamOneSrtWinPicBx.Image; }
        }
        public Image TeamTwoSrtWinPicBx
        {
            get { return teamTwoSrtWinPicBx.Image; }
        }

        //  Updates the image in the picture boxes relative to the combo box item
        private void TeamOneCmboBxImgUpdate()
        {
            switch (teamOneCmboBx.SelectedIndex)
            {
                case 0:
                    teamOneSrtWinPicBx.Image = Properties.Resources.Argentia_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    teamOneSrtWinPicBx.Image = Properties.Resources.Australian_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    teamOneSrtWinPicBx.Image = Properties.Resources.English_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    teamOneSrtWinPicBx.Image = Properties.Resources.French_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    teamOneSrtWinPicBx.Image = Properties.Resources.New_Zealand_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    teamOneSrtWinPicBx.Image = Properties.Resources.South_African_Flag;
                    teamOneSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
        private void TeamTwoCmboBxImgUpdate()
        {
            switch (teamTwoCmboBx.SelectedIndex)
            {                
                case 0:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.Argentia_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.Australian_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.English_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.French_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.New_Zealand_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    teamTwoSrtWinPicBx.Image = Properties.Resources.South_African_Flag;
                    teamTwoSrtWinPicBx.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }
}
