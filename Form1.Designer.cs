namespace _2D_LastDay
{
    partial class Form1
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
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPlayer = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLVL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CorLavel = new System.Windows.Forms.Label();
            this.TreeBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HPTreeBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPlayer
            // 
            this.MainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MainPlayer.Image = global::_2D_LastDay.Properties.Resources.cowboy_idble;
            this.MainPlayer.Location = new System.Drawing.Point(348, 543);
            this.MainPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPlayer.Name = "MainPlayer";
            this.MainPlayer.Size = new System.Drawing.Size(100, 100);
            this.MainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MainPlayer.TabIndex = 0;
            this.MainPlayer.TabStop = false;
            this.MainPlayer.Click += new System.EventHandler(this.MainPlayer_Click);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 10;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 10;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 10;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 10;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // MoveBulletsTimer
            // 
            this.MoveBulletsTimer.Enabled = true;
            this.MoveBulletsTimer.Interval = 10;
            this.MoveBulletsTimer.Tick += new System.EventHandler(this.MoveBulletsTimer_Tick);
            // 
            // MoveEnemiesTime
            // 
            this.MoveEnemiesTime.Enabled = true;
            this.MoveEnemiesTime.Interval = 10;
            this.MoveEnemiesTime.Tick += new System.EventHandler(this.MoveEnemiesTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(365, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "LVL:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(197, 118);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(56, 42);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "00";
            // 
            // labelLVL
            // 
            this.labelLVL.AutoSize = true;
            this.labelLVL.BackColor = System.Drawing.Color.Transparent;
            this.labelLVL.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLVL.ForeColor = System.Drawing.Color.White;
            this.labelLVL.Location = new System.Drawing.Point(197, 65);
            this.labelLVL.Name = "labelLVL";
            this.labelLVL.Size = new System.Drawing.Size(51, 42);
            this.labelLVL.TabIndex = 5;
            this.labelLVL.Text = "01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "YOUR HP:";
            // 
            // CorLavel
            // 
            this.CorLavel.AutoSize = true;
            this.CorLavel.BackColor = System.Drawing.Color.Transparent;
            this.CorLavel.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorLavel.ForeColor = System.Drawing.Color.White;
            this.CorLavel.Location = new System.Drawing.Point(197, 225);
            this.CorLavel.Name = "CorLavel";
            this.CorLavel.Size = new System.Drawing.Size(70, 42);
            this.CorLavel.TabIndex = 7;
            this.CorLavel.Text = "100";
            // 
            // TreeBox
            // 
            this.TreeBox.BackColor = System.Drawing.Color.Transparent;
            this.TreeBox.Image = global::_2D_LastDay.Properties.Resources.Yg6D;
            this.TreeBox.Location = new System.Drawing.Point(12, 543);
            this.TreeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TreeBox.Name = "TreeBox";
            this.TreeBox.Size = new System.Drawing.Size(267, 263);
            this.TreeBox.TabIndex = 8;
            this.TreeBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "TREE HP:";
            // 
            // HPTreeBox
            // 
            this.HPTreeBox.AutoSize = true;
            this.HPTreeBox.BackColor = System.Drawing.Color.Transparent;
            this.HPTreeBox.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPTreeBox.ForeColor = System.Drawing.Color.White;
            this.HPTreeBox.Location = new System.Drawing.Point(197, 172);
            this.HPTreeBox.Name = "HPTreeBox";
            this.HPTreeBox.Size = new System.Drawing.Size(72, 42);
            this.HPTreeBox.TabIndex = 10;
            this.HPTreeBox.Text = "300";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2D_LastDay.Properties.Resources.background_jpeg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 838);
            this.Controls.Add(this.HPTreeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TreeBox);
            this.Controls.Add(this.CorLavel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLVL);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPlayer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "2D_LastDay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox MainPlayer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer MoveBulletsTimer;
        private System.Windows.Forms.Timer MoveEnemiesTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLVL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CorLavel;
        private System.Windows.Forms.PictureBox TreeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HPTreeBox;
    }
}

