using System;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleEnglish
{
    public partial class Form1 : Form
    {
        Dictonary dictonary;
        int currentCard = 0;

        public Form1()
        {
            InitializeComponent();
            dictonary = new Dictonary();
            ShowCard(currentCard);
        }

        public void ShowCard(int current)
        {
            if(dictonary.Image(current) != "")
                pictureCard.Image = Image.FromFile(dictonary.Image(current));
            labelEnglish.Text = dictonary.English(current);
            labelRussion.Text = dictonary.Russon(current);

            labelVideo.Visible = dictonary.Video(current) != "";
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentCard <= 0) return;
            currentCard--;
            ShowCard(currentCard);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentCard >= dictonary.Total() - 1) return;
            currentCard++;
            ShowCard(currentCard);
        }

        private void PlayMp3(string fileName)
        {
            if (fileName == "") return;
            player.Visible = false;
            player.URL = fileName;
        }

        private void PlayMp4(string fileName)
        {
            if (fileName == "") return;
            //pictureCard.Visible = false;
            player.Visible = true;
            player.uiMode = "none"; // убрать все кнопки
            player.URL = fileName;
        }

        private void labelRussion_Click(object sender, EventArgs e)
        {
            PlayMp3(dictonary.AudioRus(currentCard));
        }

        private void labelEnglish_Click(object sender, EventArgs e)
        {
            PlayMp3(dictonary.AudioEng(currentCard));
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            PlayMp4(dictonary.Video(currentCard));
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                player.Visible = false; //если закончилось воспроизведение
            }
        }
    }
}
