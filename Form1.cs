using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pyatnyashki
{
    public partial class Form1 : Form
    {
        Button[] B; 
        public Form1()
        {
            InitializeComponent();
            B = new Button[16];
            B[0] = button1;
            B[1] = button2;
            B[2] = button3;
            B[3] = button4;
            B[4] = button5;
            B[5] = button6;
            B[6] = button7;
            B[7] = button8;
            B[8] = button9;
            B[9] = button10;
            B[10] = button11;
            B[11] = button12;
            B[12] = button13;
            B[13] = button14;
            B[14] = button15;
            B[15] = button16;
         shuffle_button();
            panel1_Resize(null,null);
          

        }
        private void shuffle_button()
        {
            Random random = new Random();
            for (int i = 0; i < B.Length -1 ; i++)
             {
                int randomIndex = random.Next(B.Length - 1);
                string temp = B[i].Text;  
                B[i].Text = B[randomIndex].Text;
                B[randomIndex].Text = temp;
            }
        }
       
        private void panel1_Resize(object sender, EventArgs e)
        {
            for(int i = 0; i < B.Length; i++)
            {
                int row, col;
                col = i / 4;
                row = i - col * 4;
                B[i].Top = col * panel1.Height / 4;
                B[i].Left = row*panel1.Width / 4;
                B[i].Width = panel1.Width/4;
                B[i].Height = panel1.Height / 4;
                B[i].Font = new Font ("Arial", panel1.Height/10, FontStyle.Bold);

            }


        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bclick = (Button)sender;
           int numberClick =  (int)Convert.ToInt64(bclick.Tag.ToString());
            numberClick--;
            int col = numberClick / 4;
            int row = numberClick - col * 4;
            int buttonTop, buttonBottom, buttonRight,buttonLeft;
            buttonTop = col - 1;
            buttonBottom = col + 1;
            buttonLeft = row - 1;
            buttonRight = row + 1;
            if(buttonRight < 4)
            {
                int nRigth = col * 4 + buttonRight; 
                {
                    if (!B[nRigth].Visible)
                    {
                        B[nRigth].Visible = true;
                        B[numberClick].Visible = false;
                        B[nRigth].Text = B[numberClick].Text;
                    }
                }
            }
            if (buttonLeft >= 0)
            {
                int nLeft = col * 4 + buttonLeft; 
                if (!B[nLeft].Visible)
                {

                    B[nLeft].Visible = true;
                    B[numberClick].Visible = false;
                    B[nLeft].Text = B[numberClick].Text;
                }
            }
            if (buttonTop >= 0)
            {
                int nTop = buttonTop * 4 + row;
                if (!B[nTop].Visible)
                {

                    B[nTop].Visible = true;
                    B[numberClick].Visible = false;
                    B[nTop].Text = B[numberClick].Text;
                }
            }
            if (buttonBottom < 4)
            {
                int nBottom = buttonBottom * 4 + row;
                if (!B[nBottom].Visible)
                {

                    B[nBottom].Visible = true;
                    B[numberClick].Visible = false;
                    B[nBottom].Text = B[numberClick].Text;
                }
            }
            if (B[0].Text == B[0].Tag.ToString() &&
                B[1].Text == B[1].Tag.ToString() && B[2].Text == B[2].Tag.ToString() && 
                B[3].Text == B[3].Tag.ToString() && B[4].Text == B[4].Tag.ToString() && B[5].Text == B[5].Tag.ToString() && 
                B[6].Text == B[6].Tag.ToString() && B[7].Text == B[7].Tag.ToString() && B[8].Text == B[8].Tag.ToString() && 
                B[9].Text == B[9].Tag.ToString() && B[10].Text == B[10].Tag.ToString() && B[11].Text == B[11].Tag.ToString() && 
                B[12].Text == B[12].Tag.ToString() && B[13].Text == B[13].Tag.ToString() && B[14].Text == B[14].Tag.ToString() && 
                B[15].Text == B[15].Tag.ToString()   )
            {
                MessageBox.Show("You Win");
            }



        }
    }
}
