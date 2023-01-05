using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Karaoke : Form
    {
        string pathText;
        int[] time;
        string textSong;
        string pathSong;
        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        public Karaoke()
        {
            InitializeComponent();
            textMusic.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            WMP.URL = pathSong;
            WMP.controls.play();
            songTime.Enabled = true;
            Play();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            WMP.controls.pause();
            songTime.Enabled = false;
        }

        private void bPathText_Click(object sender, EventArgs e)
        {
            textMusic.Clear();
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pathText = open.FileName;
                textMusic.AppendText(ReadText()+"\n");
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex == 0)
            {
                textMusic.Clear();
                pathText = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\text\Dzisiaj w Betleem.txt";
                WMP.URL = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\misic\koleda-dzisiaj-w-betlejem-karaoke.mp3";
                Play();
               
            }
            if(comboBox.SelectedIndex == 1)
            {
                textMusic.Clear();
                pathText = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\text\Cicha noc.txt";
                WMP.URL = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\misic\koleda-cicha-noc-karaoke.mp3";
                Play();
             
            }
            if(comboBox.SelectedIndex == 2)
            {
                textMusic.Clear();
                pathText = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\text\Przybieżeli do Betlejem.txt";
                WMP.URL = @"D:\StudiesProject\C#\Lab10Karaoke\WindowsFormsApp1\misic\koleda-przybiezeli-do-betlejem-karaoke.mp3";
                Play();
               
            }
        }

        private void bPathMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pathSong = open.FileName;
            }

        }

        public string ReadTextAndTime()
        {
            using (StreamReader read = new StreamReader(pathText, true))
            {
                return read.ReadToEnd();
            }
        }

        public string ReadText()
        {
            string text = File.ReadAllText(pathText);
            string pattern = @"\[[0-9]+\]";
            text = Regex.Replace(text, pattern, "");

            return text;
        }

        public int[] TimeLine()
        {
            textSong = ReadTextAndTime();
            string[] lines = textSong.Split('\n');
            time = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("["))
                {
                    string timeString = lines[i].Substring(1, 2);
                    time[i] = int.Parse(timeString);
                }    
            }
            return time;
        }

        public void TextLine(int currentLine)
        {
            textSong = ReadText();
            string[] lines = textSong.Split('\n');
            textMusic.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == currentLine)
                {
                    textMusic.SelectionBackColor = Color.Red;
                }
                textMusic.AppendText(lines[i] + "\n");    
            }
            textMusic.SelectionStart = textMusic.GetFirstCharIndexFromLine(currentLine);
            textMusic.ScrollToCaret();
            textMusic.SelectionLength = 0;      
        }
        public void Play()
        {
            int currentLine = 0;
            time = TimeLine();
            TextLine(currentLine);
            songTime.Interval = time[currentLine] * 1000;
            songTime.Start();    
        }

        private void songTime_Tick(object sender, EventArgs e)
        {
            songTime.Stop();
            int currentLine = textMusic.GetLineFromCharIndex(textMusic.SelectionStart);
            if (currentLine < textMusic.Lines.Length - 1)
            {       
                currentLine++;
                TextLine(currentLine);
                songTime.Interval = time[currentLine] * 1000;
                songTime.Start();               
            }
            else
            {
                WMP.controls.stop();
            }
        }
    }
}
