namespace Snake_Game__o.o_
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
            this.gametick = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbInfo2 = new System.Windows.Forms.Label();
            this.btnRES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gametick
            // 
            this.gametick.Interval = 180;
            this.gametick.Tick += new System.EventHandler(this.Gametick_Tick);
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbScore.Location = new System.Drawing.Point(758, 94);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(294, 43);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "Score : 0000";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.BorderSize = 4;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(763, 161);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(290, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START GAME !!!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.BorderSize = 4;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(763, 359);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(290, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Quit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnHD
            // 
            this.btnHD.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnHD.FlatAppearance.BorderSize = 4;
            this.btnHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.Color.Yellow;
            this.btnHD.Location = new System.Drawing.Point(763, 290);
            this.btnHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(290, 45);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "HOW TO PLAY";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.BtnHD_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("SVN-Bango", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Yellow;
            this.lbName.Location = new System.Drawing.Point(758, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(294, 96);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Trò chơi rắn săn mồi\r\n cổ điển\r\n";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.Black;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbInfo.Location = new System.Drawing.Point(19, 18);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(716, 119);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "SNAKE GAME";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbInfo2
            // 
            this.lbInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo2.ForeColor = System.Drawing.Color.Yellow;
            this.lbInfo2.Location = new System.Drawing.Point(19, 137);
            this.lbInfo2.Name = "lbInfo2";
            this.lbInfo2.Size = new System.Drawing.Size(716, 284);
            this.lbInfo2.TabIndex = 7;
            this.lbInfo2.Text = "PRESS START GAME TO PLAY !!!! :3\r\n";
            this.lbInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRES
            // 
            this.btnRES.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRES.FlatAppearance.BorderSize = 4;
            this.btnRES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRES.ForeColor = System.Drawing.Color.Yellow;
            this.btnRES.Location = new System.Drawing.Point(763, 226);
            this.btnRES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRES.Name = "btnRES";
            this.btnRES.Size = new System.Drawing.Size(290, 45);
            this.btnRES.TabIndex = 8;
            this.btnRES.Text = "RESTART GAME";
            this.btnRES.UseVisualStyleBackColor = true;
            this.btnRES.Click += new System.EventHandler(this.BtnRES_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1063, 435);
            this.Controls.Add(this.btnRES);
            this.Controls.Add(this.lbInfo2);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbScore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Snake Game !!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gametick;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInfo2;
        private System.Windows.Forms.Button btnRES;
        private System.Windows.Forms.Label lbInfo;
    }
}

