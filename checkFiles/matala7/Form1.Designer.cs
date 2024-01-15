
namespace matala7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxWoman = new System.Windows.Forms.ListBox();
            this.lblWoman = new System.Windows.Forms.Label();
            this.lblCouples = new System.Windows.Forms.Label();
            this.lbxCouples = new System.Windows.Forms.ListBox();
            this.btnFindMatch = new System.Windows.Forms.Button();
            this.lbxSingleWoman = new System.Windows.Forms.ListBox();
            this.lblSingleWoman = new System.Windows.Forms.Label();
            this.lbxSingleMan = new System.Windows.Forms.ListBox();
            this.lblSingleMan = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.rdbSman = new System.Windows.Forms.RadioButton();
            this.rdbSwoman = new System.Windows.Forms.RadioButton();
            this.rdbCouples = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelSave = new System.Windows.Forms.Panel();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxWoman
            // 
            this.lbxWoman.FormattingEnabled = true;
            this.lbxWoman.ItemHeight = 25;
            this.lbxWoman.Location = new System.Drawing.Point(39, 48);
            this.lbxWoman.Name = "lbxWoman";
            this.lbxWoman.Size = new System.Drawing.Size(180, 129);
            this.lbxWoman.TabIndex = 0;
            // 
            // lblWoman
            // 
            this.lblWoman.AutoSize = true;
            this.lblWoman.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWoman.Location = new System.Drawing.Point(39, 20);
            this.lblWoman.Name = "lblWoman";
            this.lblWoman.Size = new System.Drawing.Size(67, 21);
            this.lblWoman.TabIndex = 1;
            this.lblWoman.Text = "Woman:";
            // 
            // lblCouples
            // 
            this.lblCouples.AutoSize = true;
            this.lblCouples.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCouples.Location = new System.Drawing.Point(37, 211);
            this.lblCouples.Name = "lblCouples";
            this.lblCouples.Size = new System.Drawing.Size(69, 21);
            this.lblCouples.TabIndex = 2;
            this.lblCouples.Text = "Couples:";
            // 
            // lbxCouples
            // 
            this.lbxCouples.FormattingEnabled = true;
            this.lbxCouples.ItemHeight = 25;
            this.lbxCouples.Location = new System.Drawing.Point(39, 239);
            this.lbxCouples.Name = "lbxCouples";
            this.lbxCouples.Size = new System.Drawing.Size(248, 129);
            this.lbxCouples.TabIndex = 3;
            // 
            // btnFindMatch
            // 
            this.btnFindMatch.Location = new System.Drawing.Point(261, 48);
            this.btnFindMatch.Name = "btnFindMatch";
            this.btnFindMatch.Size = new System.Drawing.Size(122, 34);
            this.btnFindMatch.TabIndex = 4;
            this.btnFindMatch.Text = "find a match";
            this.btnFindMatch.UseVisualStyleBackColor = true;
            this.btnFindMatch.Click += new System.EventHandler(this.btnFindMatch_Click);
            // 
            // lbxSingleWoman
            // 
            this.lbxSingleWoman.FormattingEnabled = true;
            this.lbxSingleWoman.ItemHeight = 25;
            this.lbxSingleWoman.Location = new System.Drawing.Point(312, 239);
            this.lbxSingleWoman.Name = "lbxSingleWoman";
            this.lbxSingleWoman.Size = new System.Drawing.Size(196, 129);
            this.lbxSingleWoman.TabIndex = 5;
            // 
            // lblSingleWoman
            // 
            this.lblSingleWoman.AutoSize = true;
            this.lblSingleWoman.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSingleWoman.Location = new System.Drawing.Point(312, 211);
            this.lblSingleWoman.Name = "lblSingleWoman";
            this.lblSingleWoman.Size = new System.Drawing.Size(208, 21);
            this.lblSingleWoman.TabIndex = 6;
            this.lblSingleWoman.Text = "Single woman (num of kids):";
            // 
            // lbxSingleMan
            // 
            this.lbxSingleMan.FormattingEnabled = true;
            this.lbxSingleMan.ItemHeight = 25;
            this.lbxSingleMan.Location = new System.Drawing.Point(530, 239);
            this.lbxSingleMan.Name = "lbxSingleMan";
            this.lbxSingleMan.Size = new System.Drawing.Size(235, 129);
            this.lbxSingleMan.TabIndex = 7;
            // 
            // lblSingleMan
            // 
            this.lblSingleMan.AutoSize = true;
            this.lblSingleMan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSingleMan.Location = new System.Drawing.Point(526, 211);
            this.lblSingleMan.Name = "lblSingleMan";
            this.lblSingleMan.Size = new System.Drawing.Size(239, 21);
            this.lblSingleMan.TabIndex = 8;
            this.lblSingleMan.Text = "Single men (distance from work):";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSave.Location = new System.Drawing.Point(8, 9);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(86, 21);
            this.lblSave.TabIndex = 9;
            this.lblSave.Text = "Save to file";
            // 
            // rdbSman
            // 
            this.rdbSman.AutoSize = true;
            this.rdbSman.Location = new System.Drawing.Point(27, 42);
            this.rdbSman.Name = "rdbSman";
            this.rdbSman.Size = new System.Drawing.Size(123, 29);
            this.rdbSman.TabIndex = 10;
            this.rdbSman.TabStop = true;
            this.rdbSman.Text = "single men";
            this.rdbSman.UseVisualStyleBackColor = true;
            // 
            // rdbSwoman
            // 
            this.rdbSwoman.AutoSize = true;
            this.rdbSwoman.Location = new System.Drawing.Point(27, 77);
            this.rdbSwoman.Name = "rdbSwoman";
            this.rdbSwoman.Size = new System.Drawing.Size(147, 29);
            this.rdbSwoman.TabIndex = 11;
            this.rdbSwoman.TabStop = true;
            this.rdbSwoman.Text = "single women";
            this.rdbSwoman.UseVisualStyleBackColor = true;
            // 
            // rdbCouples
            // 
            this.rdbCouples.AutoSize = true;
            this.rdbCouples.Location = new System.Drawing.Point(27, 112);
            this.rdbCouples.Name = "rdbCouples";
            this.rdbCouples.Size = new System.Drawing.Size(98, 29);
            this.rdbCouples.TabIndex = 12;
            this.rdbCouples.TabStop = true;
            this.rdbCouples.Text = "couples";
            this.rdbCouples.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.rdbSwoman);
            this.panelSave.Controls.Add(this.rdbSman);
            this.panelSave.Controls.Add(this.rdbCouples);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Controls.Add(this.lblSave);
            this.panelSave.Enabled = false;
            this.panelSave.Location = new System.Drawing.Point(39, 374);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(300, 150);
            this.panelSave.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.lblSingleMan);
            this.Controls.Add(this.lbxSingleMan);
            this.Controls.Add(this.lblSingleWoman);
            this.Controls.Add(this.lbxSingleWoman);
            this.Controls.Add(this.btnFindMatch);
            this.Controls.Add(this.lbxCouples);
            this.Controls.Add(this.lblCouples);
            this.Controls.Add(this.lblWoman);
            this.Controls.Add(this.lbxWoman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWoman;
        private System.Windows.Forms.Label lblWoman;
        private System.Windows.Forms.Label lblCouples;
        private System.Windows.Forms.ListBox lbxCouples;
        private System.Windows.Forms.Button btnFindMatch;
        private System.Windows.Forms.ListBox lbxSingleWoman;
        private System.Windows.Forms.Label lblSingleWoman;
        private System.Windows.Forms.ListBox lbxSingleMan;
        private System.Windows.Forms.Label lblSingleMan;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.RadioButton rdbSman;
        private System.Windows.Forms.RadioButton rdbSwoman;
        private System.Windows.Forms.RadioButton rdbCouples;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelSave;
    }
}

