namespace BlackJack_Server
{
    partial class Server_Window
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
            this.label1 = new System.Windows.Forms.Label();
            this.drawCardBtn = new System.Windows.Forms.Button();
            this.determineWinnerBtn = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.dealerCardImg5 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg4 = new System.Windows.Forms.PictureBox();
            this.playerCardImg5 = new System.Windows.Forms.PictureBox();
            this.playerCardImg4 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg3 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg2 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg1 = new System.Windows.Forms.PictureBox();
            this.playerCardImg3 = new System.Windows.Forms.PictureBox();
            this.playerCardImg2 = new System.Windows.Forms.PictureBox();
            this.playerCardImg1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "DEALER";
            // 
            // drawCardBtn
            // 
            this.drawCardBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.drawCardBtn.Location = new System.Drawing.Point(202, 396);
            this.drawCardBtn.Name = "drawCardBtn";
            this.drawCardBtn.Size = new System.Drawing.Size(105, 30);
            this.drawCardBtn.TabIndex = 18;
            this.drawCardBtn.Text = "Magic button\r\n";
            this.drawCardBtn.UseVisualStyleBackColor = false;
            this.drawCardBtn.Click += new System.EventHandler(this.drawCard_Click);
            // 
            // determineWinnerBtn
            // 
            this.determineWinnerBtn.Location = new System.Drawing.Point(696, 407);
            this.determineWinnerBtn.Name = "determineWinnerBtn";
            this.determineWinnerBtn.Size = new System.Drawing.Size(100, 46);
            this.determineWinnerBtn.TabIndex = 19;
            this.determineWinnerBtn.Text = "Determine winner";
            this.determineWinnerBtn.UseVisualStyleBackColor = true;
            this.determineWinnerBtn.Click += new System.EventHandler(this.determineWinnerBtn_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(707, 71);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(47, 16);
            this.statusMessage.TabIndex = 20;
            this.statusMessage.Text = "Status:";
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Location = new System.Drawing.Point(616, 396);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(46, 16);
            this.dealerScoreLabel.TabIndex = 22;
            this.dealerScoreLabel.Text = "Score:";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(616, 35);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(46, 16);
            this.playerScoreLabel.TabIndex = 21;
            this.playerScoreLabel.Text = "Score:";
            // 
            // dealerCardImg5
            // 
            this.dealerCardImg5.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg5.Location = new System.Drawing.Point(261, 248);
            this.dealerCardImg5.Name = "dealerCardImg5";
            this.dealerCardImg5.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg5.TabIndex = 32;
            this.dealerCardImg5.TabStop = false;
            // 
            // dealerCardImg4
            // 
            this.dealerCardImg4.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg4.Location = new System.Drawing.Point(207, 248);
            this.dealerCardImg4.Name = "dealerCardImg4";
            this.dealerCardImg4.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg4.TabIndex = 31;
            this.dealerCardImg4.TabStop = false;
            // 
            // playerCardImg5
            // 
            this.playerCardImg5.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg5.Location = new System.Drawing.Point(261, 43);
            this.playerCardImg5.Name = "playerCardImg5";
            this.playerCardImg5.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg5.TabIndex = 30;
            this.playerCardImg5.TabStop = false;
            // 
            // playerCardImg4
            // 
            this.playerCardImg4.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg4.Location = new System.Drawing.Point(207, 43);
            this.playerCardImg4.Name = "playerCardImg4";
            this.playerCardImg4.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg4.TabIndex = 29;
            this.playerCardImg4.TabStop = false;
            // 
            // dealerCardImg3
            // 
            this.dealerCardImg3.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg3.Location = new System.Drawing.Point(148, 248);
            this.dealerCardImg3.Name = "dealerCardImg3";
            this.dealerCardImg3.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg3.TabIndex = 28;
            this.dealerCardImg3.TabStop = false;
            // 
            // dealerCardImg2
            // 
            this.dealerCardImg2.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg2.Location = new System.Drawing.Point(94, 248);
            this.dealerCardImg2.Name = "dealerCardImg2";
            this.dealerCardImg2.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg2.TabIndex = 27;
            this.dealerCardImg2.TabStop = false;
            // 
            // dealerCardImg1
            // 
            this.dealerCardImg1.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg1.Location = new System.Drawing.Point(33, 248);
            this.dealerCardImg1.Name = "dealerCardImg1";
            this.dealerCardImg1.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg1.TabIndex = 26;
            this.dealerCardImg1.TabStop = false;
            // 
            // playerCardImg3
            // 
            this.playerCardImg3.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg3.Location = new System.Drawing.Point(148, 43);
            this.playerCardImg3.Name = "playerCardImg3";
            this.playerCardImg3.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg3.TabIndex = 25;
            this.playerCardImg3.TabStop = false;
            // 
            // playerCardImg2
            // 
            this.playerCardImg2.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg2.Location = new System.Drawing.Point(94, 43);
            this.playerCardImg2.Name = "playerCardImg2";
            this.playerCardImg2.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg2.TabIndex = 24;
            this.playerCardImg2.TabStop = false;
            // 
            // playerCardImg1
            // 
            this.playerCardImg1.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg1.Location = new System.Drawing.Point(33, 43);
            this.playerCardImg1.Name = "playerCardImg1";
            this.playerCardImg1.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg1.TabIndex = 23;
            this.playerCardImg1.TabStop = false;
            // 
            // Server_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_Server.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.dealerCardImg5);
            this.Controls.Add(this.dealerCardImg4);
            this.Controls.Add(this.playerCardImg5);
            this.Controls.Add(this.playerCardImg4);
            this.Controls.Add(this.dealerCardImg3);
            this.Controls.Add(this.dealerCardImg2);
            this.Controls.Add(this.dealerCardImg1);
            this.Controls.Add(this.playerCardImg3);
            this.Controls.Add(this.playerCardImg2);
            this.Controls.Add(this.playerCardImg1);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.determineWinnerBtn);
            this.Controls.Add(this.drawCardBtn);
            this.Controls.Add(this.label1);
            this.Name = "Server_Window";
            this.Text = "BlackJack Server";
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawCardBtn;
        private System.Windows.Forms.Button determineWinnerBtn;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.Label dealerScoreLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.PictureBox dealerCardImg5;
        private System.Windows.Forms.PictureBox dealerCardImg4;
        private System.Windows.Forms.PictureBox playerCardImg5;
        private System.Windows.Forms.PictureBox playerCardImg4;
        private System.Windows.Forms.PictureBox dealerCardImg3;
        private System.Windows.Forms.PictureBox dealerCardImg2;
        private System.Windows.Forms.PictureBox dealerCardImg1;
        private System.Windows.Forms.PictureBox playerCardImg3;
        private System.Windows.Forms.PictureBox playerCardImg2;
        private System.Windows.Forms.PictureBox playerCardImg1;
    }
}

