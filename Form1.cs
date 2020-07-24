using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows;    

namespace AutoClicker
{   
    
    public partial class MainFormScreenfrm : Form

    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

     
        public MainFormScreenfrm()
        {
            InitializeComponent();
        }
        
        public class Mouse // Source  https://stackoverflow.com/questions/8272681/how-can-i-simulate-a-mouse-click-at-a-certain-position-on-the-screen/8273118
        {
           public static int ClickedAmount = 0;
            public static int TimeElapsed = 0;
            public static int TotalClickTimeElapsed = 0;
            public static DateTime MytimeElapsed = new DateTime();            

            public const int MOUSEEVENTF_LEFTDOWN = 0x02;
            public const int MOUSEEVENTF_LEFTUP = 0x04;

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            static extern bool SetCursorPos(int x, int y);
            
            
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

          public static  System.Windows.Forms.Timer MouseTimer = new System.Windows.Forms.Timer();

            public static Random RandomTimer = new Random();
            public static Random MouseHoldValue = new Random();           

            public static void LeftMouseClick(int xpos, int ypos, int sleep)
            {
                SetCursorPos(xpos, ypos);
                mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
                System.Threading.Thread.Sleep(sleep);
                mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
                ClickedAmount += 1;
            }

          public static bool clicking = false;          

        }

        private void ClickIntervalInputtxtbx_TextChanged(object sender, EventArgs e)
        {
            if (IntervalClickModeRbtn.Checked == true)
            {
                try
                {                    
                MainClicktimer.Interval = Convert.ToInt32(ClickIntervalInputtxtbx.Text);                   

                }
                catch (Exception)
                {
                    ClickIntervalInputtxtbx.Text = "100";
                }              

            }                                     
            
            if (Convert.ToInt32( ClickIntervalInputtxtbx.Text) < 0 )
            {
                ClickIntervalInputtxtbx.Text = "100";
            }
        }            

        private void MainClicktimer_Tick(object sender, EventArgs e)
        {
            if (LeftMouseHoldTrueOrFalsechkbx.Checked == true)
            {
                LeftMouseHoldTimelbl.Text = "Left Button Hold :" + Mouse.MouseHoldValue.Next(Convert.ToInt32(LowerBoundMouseHoldtxtbx.Text), Convert.ToInt32(UpperBoundMouseHoldtxtbx.Text)).ToString() + "miliseconds";
                LeftMouseHoldTime.Text = Mouse.MouseHoldValue.Next(Convert.ToInt32(LowerBoundMouseHoldtxtbx.Text), Convert.ToInt32(UpperBoundMouseHoldtxtbx.Text)).ToString(); //required - the text value is fetech for the acutal click function
            }

            if (LeftMouseHoldTrueOrFalsechkbx.Checked == false)
            {
                LeftMouseHoldTimelbl.Text = LeftMouseHoldTime.Text; 
            }

            if (RandomClickRbtn.Checked == true)
            {
                Mouse.LeftMouseClick(Cursor.Position.X, Cursor.Position.Y, Convert.ToInt32(LeftMouseHoldTime.Text));
                MainClicktimer.Interval = Mouse.RandomTimer.Next(Convert.ToInt32(LowerRandomBoundtxtbx.Text), Convert.ToInt32(UpperRandomBoundtxtbx.Text));
                RandomClickTimeValuelbl.Text = "click Interval: "  + MainClicktimer.Interval.ToString();
                ClickCountlbl.Text = "Times Clicked: " + Convert.ToString(Mouse.ClickedAmount);
            }

            if (IntervalClickModeRbtn.Checked == true)
            {
                Mouse.LeftMouseClick(Cursor.Position.X, Cursor.Position.Y, Convert.ToInt32(LeftMouseHoldTime.Text));
                MainClicktimer.Interval = Convert.ToInt32(ClickIntervalInputtxtbx.Text);
                RandomClickTimeValuelbl.Text = "click Interval: " + MainClicktimer.Interval.ToString();
                ClickCountlbl.Text = "Times Clicked: " + Convert.ToString(Mouse.ClickedAmount);                
            }               
           
        }                

        private void StartClickbtn_Click(object sender, EventArgs e)
        {            
                MainClicktimer.Start(); // Start clicking                           
                Mouse.MouseTimer.Start();
                timer1.Start();
                ClickStatuslbl.ForeColor = Color.Green;
           
            StartClickbtn.Enabled = false;
            StopClickingBtn.Enabled = true;
            ClickStatuslbl.Text = "Status: Enabled";

        }

        private void StopClickingBtn_Click(object sender, EventArgs e)
        {
            MainClicktimer.Stop(); // Stop Clicking
            ClickStatuslbl.Text = "Status: Disabled";
            ClickStatuslbl.ForeColor = Color.Red;
            Mouse.MouseTimer.Stop();
            Mouse.TimeElapsed = 0;
            timer1.Stop();
            StartClickbtn.Enabled = true;
            StopClickingBtn.Enabled = false;
            
        }

        private void LeftMouseHoldTime_TextChanged(object sender, EventArgs e)
        {         
           
            if (Convert.ToInt32(LeftMouseHoldTime.Text) < 0)
            {
                LeftMouseHoldTime.Text = "150";
            }
        }              

        protected override void WndProc(ref Message m) // Source https://stackoverflow.com/questions/15413172/capture-a-keyboard-keypress-in-the-background 
        { 
            int MYACTION_HOTKEY_ID = 1;
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.F2);
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                if (Mouse.clicking == false)
                {                    
                    StartClickbtn.PerformClick();
                    Mouse.clicking = true;
                }
                else
                {                                   
                    StopClickingBtn.PerformClick();
                    Mouse.clicking = false;
                }                          
                
            }
            base.WndProc(ref m);
        }
        
        private void LeftMouseHoldTime_KeyPress(object sender, KeyPressEventArgs e)
        { 
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        } 

        private void ClickIntervalInputtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mouse.TimeElapsed += 1;
           Mouse.TotalClickTimeElapsed += 1;
            TimeElsapsedlbl.Text = "Time Elapsed: " + TimeSpan.FromSeconds(Mouse.TimeElapsed).ToString(); ;
            TotalTimeElapsedlbl.Text = "Total Click time: " + TimeSpan.FromSeconds(Mouse.TotalClickTimeElapsed).ToString();            
        }

        private void MainFormScreenfrm_Load(object sender, EventArgs e)
        {
            MainClicktimer.Interval = 150;
            StopClickingBtn.Enabled = false;
            IntervalClickModeRbtn.Checked = true;
          
        }

        private void IntervalClickModeRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IntervalClickModeRbtn.Checked == true)
            {
                RandomClickRbtn.Checked = false;
            }
           
        }

        private void RandomClickRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomClickRbtn.Checked == true)
            {
                IntervalClickModeRbtn.Checked = false;

                MainClicktimer.Interval = Mouse.RandomTimer.Next(Convert.ToInt32(LowerRandomBoundtxtbx.Text), Convert.ToInt32(UpperRandomBoundtxtbx.Text));
            }
            
        }

        private void LowerRandomBoundBtn_TextChanged(object sender, EventArgs e)
        {
            if  (Convert.ToInt32(UpperRandomBoundtxtbx.Text) < Convert.ToInt32(LowerRandomBoundtxtbx.Text))
            {
                UpperRandomBoundtxtbx.Text = Convert.ToInt32( (LowerRandomBoundtxtbx.Text) + 1) .ToString();
            }
            if (RandomClickRbtn.Checked == true)
            {
                try
                {
                    MainClicktimer.Interval = Mouse.RandomTimer.Next(Convert.ToInt32(LowerRandomBoundtxtbx.Text), Convert.ToInt32(UpperRandomBoundtxtbx.Text));
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void UpperRandomBoundbtn_TextChanged(object sender, EventArgs e)
        {
            if (RandomClickRbtn.Checked == true)
            {
                try
                {
                    MainClicktimer.Interval = Mouse.RandomTimer.Next(Convert.ToInt32(LowerRandomboundlbl.Text), Convert.ToInt32(UpperRandomboundlbl.Text));
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void UpperRandomBoundbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        }

        private void LowerRandomBoundBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        }

        private void LowerBoundMouseHoldtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        }

        private void UpperBoundMouseHoldtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char inputchar = e.KeyChar;
            if (!Char.IsDigit(inputchar) && inputchar != 8)
            {
                e.Handled = true;
            }
        }
    }

}

