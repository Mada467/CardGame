namespace BlackJack_Client
{
    partial class Client_Window
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
            this.connect_Btn = new System.Windows.Forms.Button();
            this.ipAddress_Tb = new System.Windows.Forms.TextBox();
            this.playerCardImg1 = new System.Windows.Forms.PictureBox();
            this.playerCardImg2 = new System.Windows.Forms.PictureBox();
            this.playerCardImg3 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg3 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg2 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawCardBtn = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.determineWinnerBtn = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.dealerCardImg5 = new System.Windows.Forms.PictureBox();
            this.dealerCardImg4 = new System.Windows.Forms.PictureBox();
            this.playerCardImg5 = new System.Windows.Forms.PictureBox();
            this.playerCardImg4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg4)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_Btn
            // 
            this.connect_Btn.Location = new System.Drawing.Point(661, 248);
            this.connect_Btn.Name = "connect_Btn";
            this.connect_Btn.Size = new System.Drawing.Size(100, 23);
            this.connect_Btn.TabIndex = 1;
            this.connect_Btn.Text = "Connect";
            this.connect_Btn.UseVisualStyleBackColor = true;
            this.connect_Btn.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ipAddress_Tb
            // 
            this.ipAddress_Tb.Location = new System.Drawing.Point(661, 302);
            this.ipAddress_Tb.Name = "ipAddress_Tb";
            this.ipAddress_Tb.Size = new System.Drawing.Size(100, 22);
            this.ipAddress_Tb.TabIndex = 2;
            this.ipAddress_Tb.Text = "127.0.0.1";
            // 
            // playerCardImg1
            // 
            this.playerCardImg1.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg1.Location = new System.Drawing.Point(33, 248);
            this.playerCardImg1.Name = "playerCardImg1";
            this.playerCardImg1.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg1.TabIndex = 5;
            this.playerCardImg1.TabStop = false;
            // 
            // playerCardImg2
            // 
            this.playerCardImg2.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg2.Location = new System.Drawing.Point(94, 248);
            this.playerCardImg2.Name = "playerCardImg2";
            this.playerCardImg2.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg2.TabIndex = 6;
            this.playerCardImg2.TabStop = false;
            // 
            // playerCardImg3
            // 
            this.playerCardImg3.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg3.Location = new System.Drawing.Point(148, 248);
            this.playerCardImg3.Name = "playerCardImg3";
            this.playerCardImg3.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg3.TabIndex = 7;
            this.playerCardImg3.TabStop = false;
            // 
            // dealerCardImg3
            // 
            this.dealerCardImg3.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg3.Location = new System.Drawing.Point(148, 41);
            this.dealerCardImg3.Name = "dealerCardImg3";
            this.dealerCardImg3.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg3.TabIndex = 10;
            this.dealerCardImg3.TabStop = false;
            // 
            // dealerCardImg2
            // 
            this.dealerCardImg2.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg2.Location = new System.Drawing.Point(94, 41);
            this.dealerCardImg2.Name = "dealerCardImg2";
            this.dealerCardImg2.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg2.TabIndex = 9;
            this.dealerCardImg2.TabStop = false;
            // 
            // dealerCardImg1
            // 
            this.dealerCardImg1.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg1.Location = new System.Drawing.Point(33, 41);
            this.dealerCardImg1.Name = "dealerCardImg1";
            this.dealerCardImg1.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg1.TabIndex = 8;
            this.dealerCardImg1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEALER";
            // 
            // drawCardBtn
            // 
            this.drawCardBtn.BackColor = System.Drawing.Color.Silver;
            this.drawCardBtn.Location = new System.Drawing.Point(181, 402);
            this.drawCardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.drawCardBtn.Name = "drawCardBtn";
            this.drawCardBtn.Size = new System.Drawing.Size(105, 39);
            this.drawCardBtn.TabIndex = 12;
            this.drawCardBtn.Text = "Magic button\r\n";
            this.drawCardBtn.UseVisualStyleBackColor = false;
            this.drawCardBtn.Click += new System.EventHandler(this.drawCard_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Location = new System.Drawing.Point(563, 367);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(46, 16);
            this.playerScoreLabel.TabIndex = 13;
            this.playerScoreLabel.Text = "Score:";
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Location = new System.Drawing.Point(563, 41);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(46, 16);
            this.dealerScoreLabel.TabIndex = 14;
            this.dealerScoreLabel.Text = "Score:";
            // 
            // determineWinnerBtn
            // 
            this.determineWinnerBtn.Location = new System.Drawing.Point(661, 346);
            this.determineWinnerBtn.Name = "determineWinnerBtn";
            this.determineWinnerBtn.Size = new System.Drawing.Size(100, 46);
            this.determineWinnerBtn.TabIndex = 15;
            this.determineWinnerBtn.Text = "Determine winner";
            this.determineWinnerBtn.UseVisualStyleBackColor = true;
            this.determineWinnerBtn.Click += new System.EventHandler(this.determineWinnerBtn_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(680, 130);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(47, 16);
            this.statusMessage.TabIndex = 16;
            this.statusMessage.Text = "Status:";
            // 
            // dealerCardImg5
            // 
            this.dealerCardImg5.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg5.Location = new System.Drawing.Point(261, 41);
            this.dealerCardImg5.Name = "dealerCardImg5";
            this.dealerCardImg5.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg5.TabIndex = 20;
            this.dealerCardImg5.TabStop = false;
            // 
            // dealerCardImg4
            // 
            this.dealerCardImg4.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardImg4.Location = new System.Drawing.Point(207, 41);
            this.dealerCardImg4.Name = "dealerCardImg4";
            this.dealerCardImg4.Size = new System.Drawing.Size(100, 135);
            this.dealerCardImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardImg4.TabIndex = 19;
            this.dealerCardImg4.TabStop = false;
            // 
            // playerCardImg5
            // 
            this.playerCardImg5.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg5.Location = new System.Drawing.Point(261, 248);
            this.playerCardImg5.Name = "playerCardImg5";
            this.playerCardImg5.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg5.TabIndex = 18;
            this.playerCardImg5.TabStop = false;
            // 
            // playerCardImg4
            // 
            this.playerCardImg4.BackColor = System.Drawing.Color.Transparent;
            this.playerCardImg4.Location = new System.Drawing.Point(207, 248);
            this.playerCardImg4.Name = "playerCardImg4";
            this.playerCardImg4.Size = new System.Drawing.Size(100, 135);
            this.playerCardImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardImg4.TabIndex = 17;
            this.playerCardImg4.TabStop = false;
            // 
            // Client_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_Client.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.dealerCardImg5);
            this.Controls.Add(this.dealerCardImg4);
            this.Controls.Add(this.playerCardImg5);
            this.Controls.Add(this.playerCardImg4);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.determineWinnerBtn);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.drawCardBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerCardImg3);
            this.Controls.Add(this.dealerCardImg2);
            this.Controls.Add(this.dealerCardImg1);
            this.Controls.Add(this.playerCardImg3);
            this.Controls.Add(this.playerCardImg2);
            this.Controls.Add(this.playerCardImg1);
            this.Controls.Add(this.ipAddress_Tb);
            this.Controls.Add(this.connect_Btn);
            this.Name = "Client_Window";
            this.Text = "BlackJack Client";
            this.Load += new System.EventHandler(this.Client_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardImg4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect_Btn;
        private System.Windows.Forms.TextBox ipAddress_Tb;
        private System.Windows.Forms.PictureBox playerCardImg1;
        private System.Windows.Forms.PictureBox playerCardImg2;
        private System.Windows.Forms.PictureBox playerCardImg3;
        private System.Windows.Forms.PictureBox dealerCardImg3;
        private System.Windows.Forms.PictureBox dealerCardImg2;
        private System.Windows.Forms.PictureBox dealerCardImg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawCardBtn;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label dealerScoreLabel;
        private System.Windows.Forms.Button determineWinnerBtn;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.PictureBox dealerCardImg5;
        private System.Windows.Forms.PictureBox dealerCardImg4;
        private System.Windows.Forms.PictureBox playerCardImg5;
        private System.Windows.Forms.PictureBox playerCardImg4;
    }
}

