using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form3 form = new Form3();
        private int x;
        private int y;
        SolidBrush fon;
        Random rand;
        int count = 0;
        public Form2()
        {
            InitializeComponent();
            x = 50;
            y = 50;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            fon = new SolidBrush(Color.LightSteelBlue);
            ovalPictureBox1.BackColor = Color.NavajoWhite;
            rand = new Random();
            x = rand.Next(225, dataGridView1.Width - 125);
            y = rand.Next(98, dataGridView1.Height - 125);
            ovalPictureBox1.Location = new Point(x, y);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = rand.Next(225, dataGridView1.Width - 125);
            y = rand.Next(98, dataGridView1.Height - 125);
            ovalPictureBox1.Location = new Point(x, y);
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = Convert.ToString(count);
            Cursor.Position = new Point(350, 175);
            if (count == 1)
            {
                ovalPictureBox1.BackColor = Color.RosyBrown;
                timer1.Interval = 1000;
            }
            else if (count == 2)
            {
                ovalPictureBox1.BackColor = Color.Khaki;
                timer1.Interval = 950;
            }
            else if (count == 3)
            {
                ovalPictureBox1.BackColor = Color.SteelBlue;
                timer1.Interval = 900;
            }
            else if (count == 4)
            {
                ovalPictureBox1.BackColor = Color.Plum;
                timer1.Interval = 850;
            }
            else if (count == 5)
            {
                ovalPictureBox1.BackColor = Color.Pink;
                timer1.Stop();
                DialogResult dialog = MessageBox.Show("Do you want to play again?",
                "You win!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    textBox1.Text = "0";
                    count = 0;
                    timer1.Start();

                }
                else if (dialog == DialogResult.No)
                {
                    this.Hide();
                    form.ShowDialog();
                }

            }
        }
    }
}
