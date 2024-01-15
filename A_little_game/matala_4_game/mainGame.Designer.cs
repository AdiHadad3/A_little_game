
namespace matala_4_game
{
    partial class mainGame
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
            this.lblHello = new System.Windows.Forms.Label();
            this.lblTryRemember = new System.Windows.Forms.Label();
            this.lableS = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuation = new System.Windows.Forms.Label();
            this.cmbAnswers = new System.Windows.Forms.ComboBox();
            this.panelAns = new System.Windows.Forms.Panel();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lable1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAns.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHello.Location = new System.Drawing.Point(27, 9);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(58, 25);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello ";
            // 
            // lblTryRemember
            // 
            this.lblTryRemember.AutoSize = true;
            this.lblTryRemember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTryRemember.Location = new System.Drawing.Point(284, 9);
            this.lblTryRemember.Name = "lblTryRemember";
            this.lblTryRemember.Size = new System.Drawing.Size(225, 25);
            this.lblTryRemember.TabIndex = 2;
            this.lblTryRemember.Text = "Try to remember all details:";
            // 
            // lableS
            // 
            this.lableS.AutoSize = true;
            this.lableS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableS.Location = new System.Drawing.Point(27, 120);
            this.lableS.Name = "lableS";
            this.lableS.Size = new System.Drawing.Size(77, 32);
            this.lableS.TabIndex = 3;
            this.lableS.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(48, 152);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 28);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuation
            // 
            this.lblQuation.AutoSize = true;
            this.lblQuation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuation.Location = new System.Drawing.Point(16, 15);
            this.lblQuation.Name = "lblQuation";
            this.lblQuation.Size = new System.Drawing.Size(315, 25);
            this.lblQuation.TabIndex = 6;
            this.lblQuation.Text = "What did not appear in the picture?";
            // 
            // cmbAnswers
            // 
            this.cmbAnswers.FormattingEnabled = true;
            this.cmbAnswers.Location = new System.Drawing.Point(69, 71);
            this.cmbAnswers.Name = "cmbAnswers";
            this.cmbAnswers.Size = new System.Drawing.Size(203, 33);
            this.cmbAnswers.TabIndex = 7;
            this.cmbAnswers.SelectedIndexChanged += new System.EventHandler(this.cmbAnswers_SelectedIndexChanged);
            // 
            // panelAns
            // 
            this.panelAns.Controls.Add(this.lblCorrect);
            this.panelAns.Controls.Add(this.lblQuation);
            this.panelAns.Controls.Add(this.cmbAnswers);
            this.panelAns.Location = new System.Drawing.Point(215, 105);
            this.panelAns.Name = "panelAns";
            this.panelAns.Size = new System.Drawing.Size(350, 210);
            this.panelAns.TabIndex = 8;
            this.panelAns.Visible = false;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCorrect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCorrect.Location = new System.Drawing.Point(94, 128);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 35);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCorrect.Visible = false;
            this.lblCorrect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCorrect_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable1.Location = new System.Drawing.Point(26, 10);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(80, 32);
            this.lable1.TabIndex = 9;
            this.lable1.Text = "Timer";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(59, 42);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 28);
            this.lblTimer.TabIndex = 10;
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.lblTimer);
            this.panelTimer.Controls.Add(this.lable1);
            this.panelTimer.Location = new System.Drawing.Point(649, 66);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(139, 79);
            this.panelTimer.TabIndex = 11;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.Location = new System.Drawing.Point(663, 369);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(112, 34);
            this.btnContinue.TabIndex = 12;
            this.btnContinue.Text = "continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            this.btnContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnContinue_MouseMove);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.ForeColor = System.Drawing.Color.Red;
            this.lblLevel.Location = new System.Drawing.Point(48, 252);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(23, 28);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "0";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblL.Location = new System.Drawing.Point(27, 220);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(72, 32);
            this.lblL.TabIndex = 13;
            this.lblL.Text = "Level";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ravie", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblName.Location = new System.Drawing.Point(91, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 15;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReady.Location = new System.Drawing.Point(675, 332);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(86, 25);
            this.lblReady.TabIndex = 16;
            this.lblReady.Text = "be ready";
            this.lblReady.Visible = false;
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.panelAns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lableS);
            this.Controls.Add(this.lblTryRemember);
            this.Controls.Add(this.lblHello);
            this.Name = "mainGame";
            this.Text = "mainGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAns.ResumeLayout(false);
            this.panelAns.PerformLayout();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblTryRemember;
        private System.Windows.Forms.Label lableS;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuation;
        private System.Windows.Forms.ComboBox cmbAnswers;
        private System.Windows.Forms.Panel panelAns;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReady;
    }
}