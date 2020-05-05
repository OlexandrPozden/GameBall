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
    public partial class Form3 : Form
    {
        public string Path_toHighScores = @"C:\Users\HP\source\repos\NewGameAnna\score.txt";

        //Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            Score.Text = this.getwinners();
        }
        private string getwinners() {
            string all = "";
            StreamReader sr = new StreamReader(Path_toHighScores);
            String[] temp = new string[2];
            string line;
            int counter = 1;
            while ((line = sr.ReadLine()) != null)
            {
                temp = line.Split('$');
                all += Convert.ToString(counter)+". "+temp[0]+Convert.ToString(temp[1]) + "\n";
                counter++;
            }
            sr.Close();
            return all;
        }
        
        private void BackToGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Score.Text=this.getwinners();
        }
    }
}
