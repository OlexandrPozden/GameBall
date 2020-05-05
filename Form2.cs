using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public string Path_toHighScores = @"C:\Users\Anna Fedorova\source\repos\OlexandrPozden\GameBall\score.txt";
        private int highsc; //lower high score to get there
        Form3 form = new Form3();
        private int x;
        private int y;
        SolidBrush fon;
        Random rand;
        int count = 0;
        int time = 0;
        int gametime = 0;
        public Form2()
        {
            InitializeComponent();
            x = 50;
            y = 50;
        }

        private void StartGameTime()
        {
            timer2.Tick += delegate
            {
                time++;
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00:" + time.ToString();
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fon = new SolidBrush(Color.LightSteelBlue);
            ovalPictureBox1.BackColor = Color.NavajoWhite;
            rand = new Random();
            x = rand.Next(225, dataGridView1.Width - 125);
            y = rand.Next(98, dataGridView1.Height - 125);
            ovalPictureBox1.Location = new Point(x, y);
            timer1.Enabled = false;
            timer2.Enabled = false;
            ovalPictureBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int x, y;
            x = rand.Next(225, dataGridView1.Width - 125);
            y = rand.Next(98, dataGridView1.Height - 125);
            ovalPictureBox1.Location = new Point(x, y);
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = Convert.ToString(count);

            //Cursor.Position = new Point(x+x1,y+y1);
            if (count == 1)
            {
                ovalPictureBox1.BackColor = Color.RosyBrown;
                timer1.Interval = 500;
            }
            else if (count == 2)
            {
                ovalPictureBox1.BackColor = Color.Khaki;
                timer1.Interval = 475;
            }
            else if (count == 3)
            {
                ovalPictureBox1.BackColor = Color.SteelBlue;
                timer1.Interval = 450;
            }
            else if (count == 4)
            {
                ovalPictureBox1.BackColor = Color.Plum;
                timer1.Interval = 400;
            }
            else if (count == 5)
            {
                ovalPictureBox1.BackColor = Color.Pink;
                timer1.Stop();
                timer2.Stop();
                gametime = time;
                this.sort_winners();
                highsc = this.getLowerScoreForHighScores();
                if (gametime < highsc)
                {
                    string name = Prompt.ShowDialog("Enter please your name", "New Record!");
                    this.SetWinnerName(name, gametime);
                    
                }
                DialogResult dialog = MessageBox.Show("Do you want to play again?",
                "You win!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    textBox1.Text = "0";
                    count = 0;
                    time = 0;
                    label1.Text = "00:00";
                    timer1.Start();
                    timer2.Start();

                }
                else if (dialog == DialogResult.No)
                {
                    textBox1.Text = "0";
                    label1.Text = "00:00";
                    ovalPictureBox1.Enabled = false;
                    Start.Enabled = true;
                    HighScores.Enabled = true;
                    Pause_Resume.Enabled = false;
                    HighScores.BackColor = Color.White;
                    HighScores.ForeColor = Color.LightSlateGray;
                    splitter1.BackColor = Color.LightSlateGray;
                    Start.BackColor = Color.LightSlateGray;
                    //this.Hide();
                    //form.ShowDialog();
                }

            }
        }

        private void HighScores_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                DialogResult dialog = MessageBox.Show("Do you really want to leave this",
                "All will be discard!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    form.ShowDialog();

                }

            }
            else
            {
                this.Hide();
                form.ShowDialog();
            }
        }

        private void Pause_Resume_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                Pause_Resume.Text = "Resume";
                ovalPictureBox1.Enabled = false;
                splitter1.BackColor = Color.LightSlateGray;
                Pause_Resume.BackColor = Color.White;
                HighScores.Enabled = true;
                HighScores.BackColor = Color.LightSlateGray;
                HighScores.ForeColor = Color.White;
                Start.Enabled = true;
                Start.BackColor = Color.LightSlateGray;
                Start.ForeColor = Color.White;
            }
            else {
                timer1.Enabled = true;
                timer2.Enabled = true;
                ovalPictureBox1.Enabled = true;
                Pause_Resume.Text = "Pause";
                splitter1.BackColor = Color.Gray;
                Pause_Resume.BackColor = Color.Wheat;
                HighScores.Enabled = false;
                HighScores.BackColor = Color.Silver;
                HighScores.ForeColor = Color.Maroon;
                Start.Enabled = false;
                Start.BackColor = Color.Silver;
                Start.ForeColor = Color.Maroon;

            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                DialogResult dialog = MessageBox.Show("Do you really want to start from 0 score?",
                "All will be discard!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    count = 0;
                    textBox1.Text = "0";
                    this.Start_Click(sender, e);
                    time = 0;
                    StartGameTime();
                }

            }
            else
            {
                Pause_Resume.Enabled = true;
                Pause_Resume.BackColor = Color.Wheat;
                Pause_Resume.ForeColor = Color.Black;
                HighScores.Enabled = false;
                HighScores.BackColor = Color.Silver;
                HighScores.ForeColor = Color.White;
                splitter1.BackColor = Color.Gray;
                Start.Enabled = false;
                Start.BackColor = Color.Silver;
                Start.ForeColor = Color.Maroon;
                timer1.Enabled = true;
                timer2.Enabled = true;
                ovalPictureBox1.Enabled = true;
                StartGameTime();
                timer1.Tick += timer1_Tick;
            }
            
            
        }
        private void SetWinnerName(String name, int score) {
            String str = name + "$" + Convert.ToString(score);
            StreamReader sr = new StreamReader(Path_toHighScores);
            string[] temp = new string[2];
            string[,] winners = new string[5, 2];
            string line;

            int counter = 0;
            while ((line = sr.ReadLine()) != null)
            {

                temp = line.Split('$');
                for (int i = 0; i < temp.Length; i++)
                {
                    winners[counter, i] = temp[i];
                }
                counter++;
            }
            sr.Close();
            using (StreamWriter sw = new StreamWriter(Path_toHighScores, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 4; i++)
                {
                    sw.WriteLine(winners[i, 0] + "$" + winners[i, 1]);
                }
            }
            using (StreamWriter sw = new StreamWriter(Path_toHighScores, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(str);
            }
            this.sort_winners();
        }
        private  int getLowerScoreForHighScores()
        {
            StreamReader sr = new StreamReader(Path_toHighScores);
            string[] temp = new string[2];
            string line;
            int min_number = -1;
            while ((line = sr.ReadLine()) != null)
            {
               
                temp = line.Split('$');
                min_number = Convert.ToInt32(temp[1]);
            }
            sr.Close();
            return min_number;
        }
        private void sort_winners() {
            StreamReader sr = new StreamReader(Path_toHighScores);
            string[] temp = new string[2];
            string[,] winners = new string[5,2];
            string line;
       
            int counter = 0;
            while ((line = sr.ReadLine()) != null)
            {

                temp = line.Split('$');
                for (int i = 0; i < temp.Length; i++) {
                    winners[counter, i] = temp[i];
                }
                counter++;
            }
            sr.Close();
            for (int i = 0; i <5 ; i++) {
                for (int j = 0; j < 4; j++) {
                    if (Convert.ToInt32(winners[j, 1]) > Convert.ToInt32(winners[j + 1, 1])) {
                        for (int k = 0; k < 2; k++) {
                            temp[k] = winners[j, k];
                            winners[j, k] = winners[j + 1, k];
                            winners[j + 1, k] = temp[k];
                        }
                    }
                }
            }
           
            using (StreamWriter sw = new StreamWriter(Path_toHighScores, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine(winners[i,0]+"$"+winners[i,1]);
                }
            }
           

        }
    }
}
public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 500,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 50, Top = 20, Width = 300, Text = text };
        TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
        Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
    }
}
