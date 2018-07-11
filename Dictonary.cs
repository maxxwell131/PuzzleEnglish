using System;
using System.IO;

namespace PuzzleEnglish
{
    class Dictonary
    {
        int total = 0;

        string[] english;
        string[] russion;
        string[] audioEng;
        string[] audioRus;
        string[] image;
        string[] video;

        public Dictonary()
        {
            Init();
        }

        private void Init()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("data\\text\\");
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            total = fileInfo.Length;

            english = new String[total];
            russion = new String[total];
            audioEng = new String[total];
            audioRus = new String[total];
            image = new String[total];
            video = new String[total];

            int j = 0;

            foreach(FileInfo file in fileInfo)
            {
                string fileName = file.FullName;
                string name = file.Name.Replace( ".txt", "");
                string[] lines = File.ReadAllLines(fileName);

                english[j] = lines[0];
                russion[j] = lines[1];
                audioEng[j] = "data\\english\\" + name + ".mp3";
                audioRus[j] = "data\\russian\\" + name + ".mp3";
                if (!File.Exists(image[j])) image[j] = "";
                if (!File.Exists(video[j])) video[j] = "";

                image[j] = "data\\images\\" + name + ".jpg";
                video[j] = "data\\video\\" + name + ".mp4";
                if (!File.Exists(image[j])) image[j] = "";
                if (!File.Exists(video[j])) video[j] = "";

                j++;
            }
        }

        public int Total()
        {
            return total;
        }

        public String English(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return english[nr];
        }

        public String Russon(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return russion[nr];
        }

        public String AudioEng(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return audioEng[nr];
        }

        public String AudioRus(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return audioRus[nr];
        }

        public String Video(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return video[nr];
        }

        public String Image(int nr)
        {
            if (nr < 0 || nr >= total) return "";
            return image[nr];
        }
    }
}
