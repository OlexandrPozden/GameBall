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
        public string Path_toHighScores = @"C:\Users\Anna Fedorova\source\repos\OlexandrPozden\GameBall\score.txt";

        //Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            Score.Text = this.getwinners();
        }
        private string getwinners() {
            string all = "";
            StreamReader sr = new StreamReader(Path_toHighScores);
        
            string line;
            int counter = 1;
            while ((line = sr.ReadLine()) != null)
            {
               
                all += Convert.ToString(counter)+". "+line + "\n";
                counter++;
            }
            sr.Close();
            return all;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BackToGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
