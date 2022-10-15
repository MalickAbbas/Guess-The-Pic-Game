using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessthepic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        int num = rnd.Next(1, 6);
        int set = rnd.Next(1, 6);
        int i = 3;
        int button;
        int win_cont = 0;
        public void reset()
        {
            button1.Image = null;
            button2.Text = "GUESS PICTURE THREE TIMES FROM PUZZLE (Attempts Allowed = 3)";
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image= null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
            button16.Image = null;
            button17.Image = null;
            button18.Image = null;
            i = 3;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button = num;
            this.button1.Image = Image.FromFile(@"D:\vp\LABS\Lab-04\guessthepic\pics\"+num+ ".jfif");
            num = rnd.Next(1, 6);
            
        }
        
        public void game_click(object sender, EventArgs e)
        {
            Button spn = (Button)sender;
            
            spn.Image = Image.FromFile(@"D:\vp\LABS\Lab-04\guessthepic\pics\" + button + ".jfif");
            spn.Click -= new EventHandler(function_click);
            button2.Text = "GUESS PICTURE THREE TIMES FROM PUZZLE (Attempts Allowed = " + i + ")";
            win_cont++;
            
            if (win_cont == 3)
            {
                MessageBox.Show("You Won!");
                reset();
            }

        }
        public void function_click(object sender , EventArgs e)
        {
            Button btn = (Button)sender;
            i--;
           
               btn.Image = Image.FromFile(@"D:\vp\LABS\Lab-04\guessthepic\pics\" + set + ".jfif");
                set = rnd.Next(1, 6);
                btn.Click -= new EventHandler(function_click);
            button2.Text = "GUESS PICTURE THREE TIMES FROM PUZZLE (Attempts Allowed = " + i + ")";
            if (i == 0)
            {
                MessageBox.Show("Game Over");
                reset();

            }

            
        }
    }
}
