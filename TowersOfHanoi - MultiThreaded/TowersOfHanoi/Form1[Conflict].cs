using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;


namespace TowersOfHanoi
{
    public partial class Form1 : Form
    {
        private Stack<int>[] mPoles;
        private const int POLE1X = 150;
        private const int POLE2X = 400;
        private const int POLE3X = 650;
        private const int POLEWIDTH = 10;
        private const int POLEHEIGHT = 220;
        private const int SPACEINGTOP = 50;
        private const int DISKHEIGHT = 20;

        private const int WAIT = 500; //ms
        private Thread mThreadSolveHanoi;

        public Form1()
        {
            InitializeComponent();
            mPoles = new Stack<int>[3];
            for (int i = 0; i < 3; i++)
            {
                mPoles[i] = new Stack<int>();
            }
            mPoles[0].Push(1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            textBoxSteps.Clear();
            
            mThreadSolveHanoi = new Thread( new ThreadStart( () => SolveHanoi(mPoles[0].Count, 0, 2, 1) ));
            mThreadSolveHanoi.Start();
            timer1.Start();
            
           
        }

        private void trackBarNumDisks_Scroll(object sender, EventArgs e)
        {
            labelNumDisks.Text = "Number of Disks: " + trackBarNumDisks.Value.ToString();

            //clear Poles
            for (int i = 0; i < 3; i++)
            {
                mPoles[i].Clear();
            }

            for(int i=trackBarNumDisks.Value; i>0; i--)
            {
                //add all disks to Pole 0;
                mPoles[0].Push(i);
            }
            
            pictureBox1.Invalidate();
        }

        private void DrawDisk(Graphics g, int value, int xPos, int numDiskOnPole)
        {

            SolidBrush b = new SolidBrush(Color.Black);
            int width = 50 +  value*10;
            g.FillRectangle(b, xPos - width / 2, POLEHEIGHT+ SPACEINGTOP - numDiskOnPole*(DISKHEIGHT+1),width, DISKHEIGHT);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            //draw Poles
            SolidBrush b = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(b, POLE1X - POLEWIDTH/2,SPACEINGTOP, POLEWIDTH, POLEHEIGHT);
            e.Graphics.FillRectangle(b, POLE2X - POLEWIDTH / 2, SPACEINGTOP, POLEWIDTH, POLEHEIGHT);
            e.Graphics.FillRectangle(b, POLE3X - POLEWIDTH / 2, SPACEINGTOP, POLEWIDTH, POLEHEIGHT);

            //draw disks on pole 1
            for (int i = 0; i < mPoles[0].Count; i++)
            {
                DrawDisk(e.Graphics, (int)(mPoles[0]).ElementAt(i), POLE1X, mPoles[0].Count - i);
            }
            //draw disks on pole 2
            for (int i = 0; i < mPoles[1].Count; i++)
            {
                DrawDisk(e.Graphics, (int)(mPoles[1]).ElementAt(i), POLE2X, mPoles[1].Count - i);
            }
            //draw disks on pole 3
            for (int i = 0; i < mPoles[2].Count; i++)
            {
                DrawDisk(e.Graphics, (int)(mPoles[2]).ElementAt(i), POLE3X, mPoles[2].Count - i);
            }
        }

        private void SolveHanoi(int num, int from, int to, int via)
        {
            if (num >= 1)
            {
                SolveHanoi(num - 1, from, via, to);       
                MoveTopDisk(from, to);
                SolveHanoi(num - 1, via, to, from);
                
            }
        }
        private void MoveTopDisk(int from, int to)
        {
            
            //output step to textbox
           // textBoxSteps.AppendText(String.Format(" Move {0} from pole {1} to pole {2}\n", mPoles[from].Peek(), from + 1, to + 1));
            //do the actual move
            mPoles[to].Push(mPoles[from].Pop());
            Thread.Sleep(400);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void AppenTextToTextBoxThreadSafe(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (textBoxSteps.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AppenTextToTextBoxThreadSafe);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBoxSteps.Text = text;
            }
        }
    }
}
