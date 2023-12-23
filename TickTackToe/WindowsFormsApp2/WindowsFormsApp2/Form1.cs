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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string n = "N";
        int step = 0;
        string px = "X";
        string po = "O";
        bool l1 = true;
        bool l2 = true;
        bool l3 = true;
        bool l4 = true;
        bool l5 = true;
        bool l6 = true;
        bool l7 = true; 
        bool l8 = true;
        bool l9 = true;

        int Xv1 = 0;
        int Xv2 = 0;
        int Xv3 = 0;
        int Xv4 = 0;
        int Xv5 = 0;
        int Xv6 = 0;
        int Xv7 = 0;

        int Ov1 = 0;
        int Ov2 = 0;
        int Ov3 = 0;
        int Ov4 = 0;
        int Ov5 = 0;
        int Ov6 = 0;
        int Ov7 = 0;

        
        int XwinTest = 0;

            int numXwin;
            int numOwin;


       int steps = 1;

        string playerX = "X";
        string playerO = "O";
        int NumWinX1Check = 0;
        int NumWinX2Check = 0;
        int NumWinX3Check = 0;
        int NumWinX4Check = 0;
        int NumWinX5Check = 0;
        int NumWinX6Check = 0;
        int NumWinX7Check = 0;
        int NumWinX8Check = 0;

        int NumWinO = 0;
        int NumWinO1Check = 0;
        int NumWinO2Check = 0;
        int NumWinO3Check = 0;
        int NumWinO4Check = 0;
        int NumWinO5Check = 0;
        int NumWinO6Check = 0;
        int NumWinO7Check = 0;
        int NumWinO8Check = 0;

        bool b1 = true;
        bool b2 = true;
        bool b3 = true;
        bool b4 = true;
        bool b5 = true;
        bool b6 = true;
        bool b7 = true;
        bool b8 = true;
        bool b9 = true;
        
        int XNumWin = 0;
        int ONumWin = 0;

      public void x(int XNumWin, int ONumWin, Label NunWinX, Label NumWinO, Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        { }

        public static void nullbtn(int XNumWin, int ONumWin, Label NunWinX, Label NumWinO, Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            XNumWin = 0;                                                             //   N N N
            string XNumWinSTR = Convert.ToString(XNumWin);
            NunWinX.Text = XNumWinSTR;

            ONumWin = 0;                                                            //   N N O
            string ONumWinSTR = Convert.ToString(ONumWin);
            NumWinO.Text = ONumWinSTR;
        }

        public static void whovin(int step, Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9, int XNumWin, int ONumWin, int NumWinO1Check, Label NunWinX, Label NunWinO)
        {
            step = 0;
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")        // X X X
            {                                                                            //  N N N
                XNumWin++;                                                              //   N N N
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")        // N N N
            {                                                                            //  X X X
                XNumWin++;                                                              //   N N N
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")        // N N N
            {                                                                            //  N N N
                XNumWin++;                                                              //   X X X
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
            }

            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")        // N N X
            {                                                                            //  N X N
                XNumWin++;                                                              //   X N N
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")        // X N N
            {                                                                            //  N X N
                XNumWin++;                                                              //   N N X
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")    // N N N
            {                                                                        //  N N N
                ONumWin++;                                                          //   O O O
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")    // N N N
            {                                                                        //  O O O
                ONumWin++;                                                          //   N N N
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")    // O O O
            {                                                                        //  N N N
                ONumWin++;                                                          //   N N N
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
            }

            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")    // N N O
            {                                                                        //  N O N
                ONumWin++;                                                          //   O N N
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")    // O N N
            {                                                                        //  N O N
                ONumWin++;                                                          //   N N O
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
            }
            //   nullbtn();

        //    nullbtn();
          ///'
          ///
          /// Afternullbtn();
        }



        public static void Afternullbtn(int XNumWin, int ONumWin, Label NunWinX, Label NumWinO, Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            XNumWin = 0;                                                             //   N N N
            string XNumWinSTR = Convert.ToString(XNumWin);
            NunWinX.Text = XNumWinSTR;

            ONumWin = 0;                                                            //   N N O
            string ONumWinSTR = Convert.ToString(ONumWin);
            NumWinO.Text = ONumWinSTR;
        }

        int v1X = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button1.Text = "X";
                NumWinX1Check++;
                v1X++;
            }
            else
            {
                button1.Text = "O";
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            button1.Enabled = false;
            // whovin();
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button2.Text = "X";
                NumWinX1Check++;
                v1X++;
            }
            else
            {
                button2.Text = "O";
                NumWinO1Check++;
            }
            button2.Enabled = false;
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }

            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button3.Text = "X";
                NumWinX1Check++;
                v1X++;
            }
            else
            {
                button3.Text = "O";
                NumWinO1Check++;
            }
            button3.Enabled = false;
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }

            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button4.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button4.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            button4.Enabled = false;

            //Check win
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button5.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button5.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            button5.Enabled = false;

            //Check win
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button6.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button6.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            button6.Enabled = false;

            //Check win
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button7.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button7.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            button7.Enabled = false;

            //Check win
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button8.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button8.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            
            button8.Enabled = false;
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (steps == 1 | steps == 3 | steps == 5 | steps == 7 | steps == 9)
            {
                button9.Text = "X";
                NumWinX1Check++;
            }
            else
            {
                button9.Text = "O";
                NumWinO1Check++;
            }
            steps++;
            if (steps >= 10)
            {
                steps = 1;
            }
            
            button9.Enabled = false;
            whovin(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void whovin(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button7.Text == "X" && button5.Text == "X" && button3.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X")       
            {                                                                            
                XNumWin++;                                                              
                string XNumWinSTR = Convert.ToString(XNumWin);
                NumWinO1Check = 0;
                NunWinX.Text = XNumWinSTR;
                MessageBox.Show("Win X!");
                nulalbtn();
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || // 1.2.3
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || // 4.5.6
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || // 7.8.9
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" || // 3.5.7
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || // 1.5.9
                button7.Text == "O" && button5.Text == "O" && button3.Text == "O" || // 7.5.3
                button3.Text == "O" && button5.Text == "O" && button9.Text == "O" || // 3.5.9
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || // 7.8.9
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O")   // 3.6.9
            {
                ONumWin++;
                string ONumWinSTR = Convert.ToString(ONumWin);
                NumWinO1Check = 0;
                NunWinO.Text = ONumWinSTR;
                MessageBox.Show("Win O!");
                nulalbtn();
            }           
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            XNumWin = 0;
            string XNumWinSTR = Convert.ToString(XNumWin);
            NumWinO1Check = 0;
            NunWinX.Text = XNumWinSTR;

            ONumWin = 0;
            string ONumWinSTR = Convert.ToString(ONumWin);
            NumWinO1Check = 0;
            NunWinO.Text = ONumWinSTR;
            nulalbtn();
        }
        private void nxtRaund_Click(object sender, EventArgs e)
        {
            nulalbtn();
        }
        private void nulalbtn()
        {
            button1.Text = " ";
            button1.Enabled = true;

            button2.Text = " ";
            button2.Enabled = true;

            button3.Text = " ";
            button3.Enabled = true;

            button4.Text = " ";
            button4.Enabled = true;

            button5.Text = " ";
            button5.Enabled = true;

            button6.Text = " ";
            button6.Enabled = true;

            button6.Text = " ";
            button6.Enabled = true;

            button7.Text = " ";
            button7.Enabled = true;

            button8.Text = " ";
            button8.Enabled = true;

            button9.Text = " ";
            button9.Enabled = true;

            step = 0;
        }
    }
}