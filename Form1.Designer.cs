namespace AutoClicker
{
    partial class MainFormScreenfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormScreenfrm));
            this.StartClickbtn = new System.Windows.Forms.Button();
            this.StopClickingBtn = new System.Windows.Forms.Button();
            this.MainClicktimer = new System.Windows.Forms.Timer(this.components);
            this.ClickIntervalInputtxtbx = new System.Windows.Forms.TextBox();
            this.ClickIntervallbl = new System.Windows.Forms.Label();
            this.LeftMouseHoldTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartStopKeyButtonlbl = new System.Windows.Forms.Label();
            this.ClickStatuslbl = new System.Windows.Forms.Label();
            this.ClickCountlbl = new System.Windows.Forms.Label();
            this.TimeElsapsedlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TotalTimeElapsedlbl = new System.Windows.Forms.Label();
            this.IntervalClickModeRbtn = new System.Windows.Forms.RadioButton();
            this.RandomClickTimeValuelbl = new System.Windows.Forms.Label();
            this.LowerRandomboundlbl = new System.Windows.Forms.Label();
            this.UpperRandomboundlbl = new System.Windows.Forms.Label();
            this.LowerRandomBoundtxtbx = new System.Windows.Forms.TextBox();
            this.UpperRandomBoundtxtbx = new System.Windows.Forms.TextBox();
            this.RandomClickRbtn = new System.Windows.Forms.RadioButton();
            this.LowerBoundMouseHoldtxtbx = new System.Windows.Forms.TextBox();
            this.UpperBoundMouseHoldtxtbx = new System.Windows.Forms.TextBox();
            this.LowerBoundMouseHoldlbl = new System.Windows.Forms.Label();
            this.UpperBoundMouseHoldlbl = new System.Windows.Forms.Label();
            this.LeftMouseHoldTrueOrFalsechkbx = new System.Windows.Forms.CheckBox();
            this.LeftMouseHoldTimelbl = new System.Windows.Forms.Label();
            this.SingleClickChkbx = new System.Windows.Forms.CheckBox();
            this.DoubleClickchxbx = new System.Windows.Forms.CheckBox();
            this.DoubleClickLowerBoundwaittxtbx = new System.Windows.Forms.TextBox();
            this.DoubleClickupperBoundwaittxtbx = new System.Windows.Forms.TextBox();
            this.LowerDoubleClicikWaitlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoubleClickWaitlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartClickbtn
            // 
            this.StartClickbtn.Location = new System.Drawing.Point(193, 457);
            this.StartClickbtn.Name = "StartClickbtn";
            this.StartClickbtn.Size = new System.Drawing.Size(141, 23);
            this.StartClickbtn.TabIndex = 0;
            this.StartClickbtn.Text = "Start Clicking";
            this.StartClickbtn.UseVisualStyleBackColor = true;
            this.StartClickbtn.Click += new System.EventHandler(this.StartClickbtn_Click);
            // 
            // StopClickingBtn
            // 
            this.StopClickingBtn.Location = new System.Drawing.Point(356, 457);
            this.StopClickingBtn.Name = "StopClickingBtn";
            this.StopClickingBtn.Size = new System.Drawing.Size(141, 23);
            this.StopClickingBtn.TabIndex = 1;
            this.StopClickingBtn.Text = "Stop Clicking";
            this.StopClickingBtn.UseVisualStyleBackColor = true;
            this.StopClickingBtn.Click += new System.EventHandler(this.StopClickingBtn_Click);
            // 
            // MainClicktimer
            // 
            this.MainClicktimer.Interval = 1000;
            this.MainClicktimer.Tick += new System.EventHandler(this.MainClicktimer_Tick);
            // 
            // ClickIntervalInputtxtbx
            // 
            this.ClickIntervalInputtxtbx.Location = new System.Drawing.Point(234, 35);
            this.ClickIntervalInputtxtbx.MaxLength = 8;
            this.ClickIntervalInputtxtbx.Name = "ClickIntervalInputtxtbx";
            this.ClickIntervalInputtxtbx.Size = new System.Drawing.Size(100, 20);
            this.ClickIntervalInputtxtbx.TabIndex = 2;
            this.ClickIntervalInputtxtbx.Text = "150";
            this.ClickIntervalInputtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClickIntervalInputtxtbx.TextChanged += new System.EventHandler(this.ClickIntervalInputtxtbx_TextChanged);
            this.ClickIntervalInputtxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClickIntervalInputtxtbx_KeyPress);
            // 
            // ClickIntervallbl
            // 
            this.ClickIntervallbl.AutoSize = true;
            this.ClickIntervallbl.Location = new System.Drawing.Point(24, 42);
            this.ClickIntervallbl.Name = "ClickIntervallbl";
            this.ClickIntervallbl.Size = new System.Drawing.Size(142, 13);
            this.ClickIntervallbl.TabIndex = 3;
            this.ClickIntervallbl.Text = "Click Interval (MilliSeconds) :";
            // 
            // LeftMouseHoldTime
            // 
            this.LeftMouseHoldTime.Location = new System.Drawing.Point(234, 67);
            this.LeftMouseHoldTime.MaxLength = 3;
            this.LeftMouseHoldTime.Name = "LeftMouseHoldTime";
            this.LeftMouseHoldTime.Size = new System.Drawing.Size(100, 20);
            this.LeftMouseHoldTime.TabIndex = 4;
            this.LeftMouseHoldTime.Text = "150";
            this.LeftMouseHoldTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LeftMouseHoldTime.TextChanged += new System.EventHandler(this.LeftMouseHoldTime_TextChanged);
            this.LeftMouseHoldTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftMouseHoldTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left Mouse Held Click Time (Mili seconds)";
            // 
            // StartStopKeyButtonlbl
            // 
            this.StartStopKeyButtonlbl.AutoSize = true;
            this.StartStopKeyButtonlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopKeyButtonlbl.Location = new System.Drawing.Point(274, 424);
            this.StartStopKeyButtonlbl.Name = "StartStopKeyButtonlbl";
            this.StartStopKeyButtonlbl.Size = new System.Drawing.Size(146, 15);
            this.StartStopKeyButtonlbl.TabIndex = 6;
            this.StartStopKeyButtonlbl.Text = "Press F2 to Start/Stop";
            // 
            // ClickStatuslbl
            // 
            this.ClickStatuslbl.AutoSize = true;
            this.ClickStatuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickStatuslbl.ForeColor = System.Drawing.Color.Red;
            this.ClickStatuslbl.Location = new System.Drawing.Point(25, 457);
            this.ClickStatuslbl.Name = "ClickStatuslbl";
            this.ClickStatuslbl.Size = new System.Drawing.Size(115, 18);
            this.ClickStatuslbl.TabIndex = 7;
            this.ClickStatuslbl.Text = "Status: Disabled";
            // 
            // ClickCountlbl
            // 
            this.ClickCountlbl.AutoSize = true;
            this.ClickCountlbl.Location = new System.Drawing.Point(570, 457);
            this.ClickCountlbl.Name = "ClickCountlbl";
            this.ClickCountlbl.Size = new System.Drawing.Size(61, 13);
            this.ClickCountlbl.TabIndex = 8;
            this.ClickCountlbl.Text = "Click Count";
            // 
            // TimeElsapsedlbl
            // 
            this.TimeElsapsedlbl.AutoSize = true;
            this.TimeElsapsedlbl.Location = new System.Drawing.Point(25, 364);
            this.TimeElsapsedlbl.Name = "TimeElsapsedlbl";
            this.TimeElsapsedlbl.Size = new System.Drawing.Size(72, 13);
            this.TimeElsapsedlbl.TabIndex = 9;
            this.TimeElsapsedlbl.Text = "TimeElapselbl";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TotalTimeElapsedlbl
            // 
            this.TotalTimeElapsedlbl.AutoSize = true;
            this.TotalTimeElapsedlbl.Location = new System.Drawing.Point(24, 394);
            this.TotalTimeElapsedlbl.Name = "TotalTimeElapsedlbl";
            this.TotalTimeElapsedlbl.Size = new System.Drawing.Size(97, 13);
            this.TotalTimeElapsedlbl.TabIndex = 10;
            this.TotalTimeElapsedlbl.Text = "Total Time Clicking";
            // 
            // IntervalClickModeRbtn
            // 
            this.IntervalClickModeRbtn.AutoSize = true;
            this.IntervalClickModeRbtn.Location = new System.Drawing.Point(27, 12);
            this.IntervalClickModeRbtn.Name = "IntervalClickModeRbtn";
            this.IntervalClickModeRbtn.Size = new System.Drawing.Size(124, 17);
            this.IntervalClickModeRbtn.TabIndex = 11;
            this.IntervalClickModeRbtn.TabStop = true;
            this.IntervalClickModeRbtn.Text = "Custom Interval Click";
            this.IntervalClickModeRbtn.UseVisualStyleBackColor = true;
            this.IntervalClickModeRbtn.CheckedChanged += new System.EventHandler(this.IntervalClickModeRbtn_CheckedChanged);
            // 
            // RandomClickTimeValuelbl
            // 
            this.RandomClickTimeValuelbl.AutoSize = true;
            this.RandomClickTimeValuelbl.Location = new System.Drawing.Point(464, 364);
            this.RandomClickTimeValuelbl.Name = "RandomClickTimeValuelbl";
            this.RandomClickTimeValuelbl.Size = new System.Drawing.Size(68, 13);
            this.RandomClickTimeValuelbl.TabIndex = 17;
            this.RandomClickTimeValuelbl.Text = "Click Interval";
            // 
            // LowerRandomboundlbl
            // 
            this.LowerRandomboundlbl.AutoSize = true;
            this.LowerRandomboundlbl.Location = new System.Drawing.Point(464, 42);
            this.LowerRandomboundlbl.Name = "LowerRandomboundlbl";
            this.LowerRandomboundlbl.Size = new System.Drawing.Size(112, 13);
            this.LowerRandomboundlbl.TabIndex = 12;
            this.LowerRandomboundlbl.Text = "Lower Random bound";
            // 
            // UpperRandomboundlbl
            // 
            this.UpperRandomboundlbl.AutoSize = true;
            this.UpperRandomboundlbl.Location = new System.Drawing.Point(464, 74);
            this.UpperRandomboundlbl.Name = "UpperRandomboundlbl";
            this.UpperRandomboundlbl.Size = new System.Drawing.Size(112, 13);
            this.UpperRandomboundlbl.TabIndex = 13;
            this.UpperRandomboundlbl.Text = "Upper Random bound";
            // 
            // LowerRandomBoundtxtbx
            // 
            this.LowerRandomBoundtxtbx.Location = new System.Drawing.Point(605, 35);
            this.LowerRandomBoundtxtbx.MaxLength = 6;
            this.LowerRandomBoundtxtbx.Name = "LowerRandomBoundtxtbx";
            this.LowerRandomBoundtxtbx.Size = new System.Drawing.Size(100, 20);
            this.LowerRandomBoundtxtbx.TabIndex = 14;
            this.LowerRandomBoundtxtbx.Text = "1000";
            this.LowerRandomBoundtxtbx.TextChanged += new System.EventHandler(this.LowerRandomBoundBtn_TextChanged);
            this.LowerRandomBoundtxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowerRandomBoundBtn_KeyPress);
            // 
            // UpperRandomBoundtxtbx
            // 
            this.UpperRandomBoundtxtbx.Location = new System.Drawing.Point(605, 71);
            this.UpperRandomBoundtxtbx.MaxLength = 6;
            this.UpperRandomBoundtxtbx.Name = "UpperRandomBoundtxtbx";
            this.UpperRandomBoundtxtbx.Size = new System.Drawing.Size(100, 20);
            this.UpperRandomBoundtxtbx.TabIndex = 15;
            this.UpperRandomBoundtxtbx.Text = "3000";
            this.UpperRandomBoundtxtbx.TextChanged += new System.EventHandler(this.UpperRandomBoundbtn_TextChanged);
            this.UpperRandomBoundtxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpperRandomBoundbtn_KeyPress);
            // 
            // RandomClickRbtn
            // 
            this.RandomClickRbtn.AutoSize = true;
            this.RandomClickRbtn.Location = new System.Drawing.Point(467, 12);
            this.RandomClickRbtn.Name = "RandomClickRbtn";
            this.RandomClickRbtn.Size = new System.Drawing.Size(170, 17);
            this.RandomClickRbtn.TabIndex = 16;
            this.RandomClickRbtn.TabStop = true;
            this.RandomClickRbtn.Text = "Custom Random Interval  Click";
            this.RandomClickRbtn.UseVisualStyleBackColor = true;
            this.RandomClickRbtn.CheckedChanged += new System.EventHandler(this.RandomClickRbtn_CheckedChanged);
            // 
            // LowerBoundMouseHoldtxtbx
            // 
            this.LowerBoundMouseHoldtxtbx.Location = new System.Drawing.Point(605, 126);
            this.LowerBoundMouseHoldtxtbx.MaxLength = 5;
            this.LowerBoundMouseHoldtxtbx.Name = "LowerBoundMouseHoldtxtbx";
            this.LowerBoundMouseHoldtxtbx.Size = new System.Drawing.Size(100, 20);
            this.LowerBoundMouseHoldtxtbx.TabIndex = 18;
            this.LowerBoundMouseHoldtxtbx.Text = "150";
            this.LowerBoundMouseHoldtxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LowerBoundMouseHoldtxtbx_KeyPress);
            // 
            // UpperBoundMouseHoldtxtbx
            // 
            this.UpperBoundMouseHoldtxtbx.Location = new System.Drawing.Point(605, 163);
            this.UpperBoundMouseHoldtxtbx.MaxLength = 5;
            this.UpperBoundMouseHoldtxtbx.Name = "UpperBoundMouseHoldtxtbx";
            this.UpperBoundMouseHoldtxtbx.Size = new System.Drawing.Size(100, 20);
            this.UpperBoundMouseHoldtxtbx.TabIndex = 19;
            this.UpperBoundMouseHoldtxtbx.Text = "310";
            this.UpperBoundMouseHoldtxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpperBoundMouseHoldtxtbx_KeyPress);
            // 
            // LowerBoundMouseHoldlbl
            // 
            this.LowerBoundMouseHoldlbl.AutoSize = true;
            this.LowerBoundMouseHoldlbl.Location = new System.Drawing.Point(464, 133);
            this.LowerBoundMouseHoldlbl.Name = "LowerBoundMouseHoldlbl";
            this.LowerBoundMouseHoldlbl.Size = new System.Drawing.Size(121, 13);
            this.LowerBoundMouseHoldlbl.TabIndex = 20;
            this.LowerBoundMouseHoldlbl.Text = "LowerBoundMouseHold";
            // 
            // UpperBoundMouseHoldlbl
            // 
            this.UpperBoundMouseHoldlbl.AutoSize = true;
            this.UpperBoundMouseHoldlbl.Location = new System.Drawing.Point(464, 166);
            this.UpperBoundMouseHoldlbl.Name = "UpperBoundMouseHoldlbl";
            this.UpperBoundMouseHoldlbl.Size = new System.Drawing.Size(121, 13);
            this.UpperBoundMouseHoldlbl.TabIndex = 21;
            this.UpperBoundMouseHoldlbl.Text = "UpperBoundMouseHold";
            // 
            // LeftMouseHoldTrueOrFalsechkbx
            // 
            this.LeftMouseHoldTrueOrFalsechkbx.AutoSize = true;
            this.LeftMouseHoldTrueOrFalsechkbx.Location = new System.Drawing.Point(467, 103);
            this.LeftMouseHoldTrueOrFalsechkbx.Name = "LeftMouseHoldTrueOrFalsechkbx";
            this.LeftMouseHoldTrueOrFalsechkbx.Size = new System.Drawing.Size(147, 17);
            this.LeftMouseHoldTrueOrFalsechkbx.TabIndex = 23;
            this.LeftMouseHoldTrueOrFalsechkbx.Text = "Random Left Mouse Hold";
            this.LeftMouseHoldTrueOrFalsechkbx.UseVisualStyleBackColor = true;
            // 
            // LeftMouseHoldTimelbl
            // 
            this.LeftMouseHoldTimelbl.AutoSize = true;
            this.LeftMouseHoldTimelbl.Location = new System.Drawing.Point(464, 394);
            this.LeftMouseHoldTimelbl.Name = "LeftMouseHoldTimelbl";
            this.LeftMouseHoldTimelbl.Size = new System.Drawing.Size(79, 13);
            this.LeftMouseHoldTimelbl.TabIndex = 24;
            this.LeftMouseHoldTimelbl.Text = "LeftMouseHold";
            // 
            // SingleClickChkbx
            // 
            this.SingleClickChkbx.AutoSize = true;
            this.SingleClickChkbx.Location = new System.Drawing.Point(22, 181);
            this.SingleClickChkbx.Name = "SingleClickChkbx";
            this.SingleClickChkbx.Size = new System.Drawing.Size(81, 17);
            this.SingleClickChkbx.TabIndex = 25;
            this.SingleClickChkbx.Text = "Single Click";
            this.SingleClickChkbx.UseVisualStyleBackColor = true;
            this.SingleClickChkbx.CheckedChanged += new System.EventHandler(this.SingleClickChkbx_CheckedChanged);
            // 
            // DoubleClickchxbx
            // 
            this.DoubleClickchxbx.AutoSize = true;
            this.DoubleClickchxbx.Location = new System.Drawing.Point(22, 204);
            this.DoubleClickchxbx.Name = "DoubleClickchxbx";
            this.DoubleClickchxbx.Size = new System.Drawing.Size(86, 17);
            this.DoubleClickchxbx.TabIndex = 26;
            this.DoubleClickchxbx.Text = "Double Click";
            this.DoubleClickchxbx.UseVisualStyleBackColor = true;
            this.DoubleClickchxbx.CheckedChanged += new System.EventHandler(this.DoubleClickchxbx_CheckedChanged);
            // 
            // DoubleClickLowerBoundwaittxtbx
            // 
            this.DoubleClickLowerBoundwaittxtbx.Location = new System.Drawing.Point(211, 231);
            this.DoubleClickLowerBoundwaittxtbx.MaxLength = 3;
            this.DoubleClickLowerBoundwaittxtbx.Name = "DoubleClickLowerBoundwaittxtbx";
            this.DoubleClickLowerBoundwaittxtbx.Size = new System.Drawing.Size(100, 20);
            this.DoubleClickLowerBoundwaittxtbx.TabIndex = 27;
            this.DoubleClickLowerBoundwaittxtbx.Text = "150";
            this.DoubleClickLowerBoundwaittxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleClickLowerBoundwaittxtbx_KeyPress);
            // 
            // DoubleClickupperBoundwaittxtbx
            // 
            this.DoubleClickupperBoundwaittxtbx.Location = new System.Drawing.Point(211, 257);
            this.DoubleClickupperBoundwaittxtbx.MaxLength = 3;
            this.DoubleClickupperBoundwaittxtbx.Name = "DoubleClickupperBoundwaittxtbx";
            this.DoubleClickupperBoundwaittxtbx.Size = new System.Drawing.Size(100, 20);
            this.DoubleClickupperBoundwaittxtbx.TabIndex = 28;
            this.DoubleClickupperBoundwaittxtbx.Text = "280";
            this.DoubleClickupperBoundwaittxtbx.TextChanged += new System.EventHandler(this.DoubleClickupperBoundwaittxtbx_TextChanged);
            this.DoubleClickupperBoundwaittxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleClickupperBoundwaittxtbx_KeyPress);
            // 
            // LowerDoubleClicikWaitlbl
            // 
            this.LowerDoubleClicikWaitlbl.AutoSize = true;
            this.LowerDoubleClicikWaitlbl.Location = new System.Drawing.Point(24, 234);
            this.LowerDoubleClicikWaitlbl.Name = "LowerDoubleClicikWaitlbl";
            this.LowerDoubleClicikWaitlbl.Size = new System.Drawing.Size(170, 13);
            this.LowerDoubleClicikWaitlbl.TabIndex = 29;
            this.LowerDoubleClicikWaitlbl.Text = "Time Between Double Click Lower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Time Between Double Click Upper";
            // 
            // DoubleClickWaitlbl
            // 
            this.DoubleClickWaitlbl.AutoSize = true;
            this.DoubleClickWaitlbl.Location = new System.Drawing.Point(22, 296);
            this.DoubleClickWaitlbl.Name = "DoubleClickWaitlbl";
            this.DoubleClickWaitlbl.Size = new System.Drawing.Size(92, 13);
            this.DoubleClickWaitlbl.TabIndex = 31;
            this.DoubleClickWaitlbl.Text = "Double Click Wait";
            // 
            // MainFormScreenfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(717, 492);
            this.Controls.Add(this.DoubleClickWaitlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LowerDoubleClicikWaitlbl);
            this.Controls.Add(this.DoubleClickupperBoundwaittxtbx);
            this.Controls.Add(this.DoubleClickLowerBoundwaittxtbx);
            this.Controls.Add(this.DoubleClickchxbx);
            this.Controls.Add(this.SingleClickChkbx);
            this.Controls.Add(this.LeftMouseHoldTimelbl);
            this.Controls.Add(this.LeftMouseHoldTrueOrFalsechkbx);
            this.Controls.Add(this.UpperBoundMouseHoldlbl);
            this.Controls.Add(this.LowerBoundMouseHoldlbl);
            this.Controls.Add(this.UpperBoundMouseHoldtxtbx);
            this.Controls.Add(this.LowerBoundMouseHoldtxtbx);
            this.Controls.Add(this.RandomClickTimeValuelbl);
            this.Controls.Add(this.RandomClickRbtn);
            this.Controls.Add(this.UpperRandomBoundtxtbx);
            this.Controls.Add(this.LowerRandomBoundtxtbx);
            this.Controls.Add(this.UpperRandomboundlbl);
            this.Controls.Add(this.LowerRandomboundlbl);
            this.Controls.Add(this.IntervalClickModeRbtn);
            this.Controls.Add(this.TotalTimeElapsedlbl);
            this.Controls.Add(this.TimeElsapsedlbl);
            this.Controls.Add(this.ClickCountlbl);
            this.Controls.Add(this.ClickStatuslbl);
            this.Controls.Add(this.StartStopKeyButtonlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftMouseHoldTime);
            this.Controls.Add(this.ClickIntervallbl);
            this.Controls.Add(this.ClickIntervalInputtxtbx);
            this.Controls.Add(this.StopClickingBtn);
            this.Controls.Add(this.StartClickbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainFormScreenfrm";
            this.Text = "Click";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFormScreenfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartClickbtn;
        private System.Windows.Forms.Button StopClickingBtn;
        private System.Windows.Forms.Timer MainClicktimer;
        private System.Windows.Forms.TextBox ClickIntervalInputtxtbx;
        private System.Windows.Forms.Label ClickIntervallbl;
        private System.Windows.Forms.TextBox LeftMouseHoldTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartStopKeyButtonlbl;
        private System.Windows.Forms.Label ClickStatuslbl;
        private System.Windows.Forms.Label ClickCountlbl;
        private System.Windows.Forms.Label TimeElsapsedlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TotalTimeElapsedlbl;
        private System.Windows.Forms.RadioButton IntervalClickModeRbtn;
        private System.Windows.Forms.Label RandomClickTimeValuelbl;
        private System.Windows.Forms.Label LowerRandomboundlbl;
        private System.Windows.Forms.Label UpperRandomboundlbl;
        private System.Windows.Forms.TextBox LowerRandomBoundtxtbx;
        private System.Windows.Forms.TextBox UpperRandomBoundtxtbx;
        private System.Windows.Forms.RadioButton RandomClickRbtn;
        private System.Windows.Forms.TextBox LowerBoundMouseHoldtxtbx;
        private System.Windows.Forms.TextBox UpperBoundMouseHoldtxtbx;
        private System.Windows.Forms.Label LowerBoundMouseHoldlbl;
        private System.Windows.Forms.Label UpperBoundMouseHoldlbl;
        private System.Windows.Forms.CheckBox LeftMouseHoldTrueOrFalsechkbx;
        private System.Windows.Forms.Label LeftMouseHoldTimelbl;
        private System.Windows.Forms.CheckBox SingleClickChkbx;
        private System.Windows.Forms.CheckBox DoubleClickchxbx;
        private System.Windows.Forms.TextBox DoubleClickLowerBoundwaittxtbx;
        private System.Windows.Forms.TextBox DoubleClickupperBoundwaittxtbx;
        private System.Windows.Forms.Label LowerDoubleClicikWaitlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DoubleClickWaitlbl;
    }
}

