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
            this.dealerThirdCardImg = new System.Windows.Forms.PictureBox();
            this.dealerSecondCardImg = new System.Windows.Forms.PictureBox();
            this.dealerFirstCardImg = new System.Windows.Forms.PictureBox();
            this.playerThirdCardImg = new System.Windows.Forms.PictureBox();
            this.playerSecondCardImg = new System.Windows.Forms.PictureBox();
            this.playerFirstCardImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawCardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealerThirdCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerSecondCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerFirstCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerThirdCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSecondCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFirstCardImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dealerThirdCardImg
            // 
            this.dealerThirdCardImg.BackColor = System.Drawing.Color.Transparent;
            this.dealerThirdCardImg.Location = new System.Drawing.Point(345, 233);
            this.dealerThirdCardImg.Name = "dealerThirdCardImg";
            this.dealerThirdCardImg.Size = new System.Drawing.Size(100, 135);
            this.dealerThirdCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerThirdCardImg.TabIndex = 16;
            this.dealerThirdCardImg.TabStop = false;
            // 
            // dealerSecondCardImg
            // 
            this.dealerSecondCardImg.BackColor = System.Drawing.Color.Transparent;
            this.dealerSecondCardImg.Location = new System.Drawing.Point(207, 233);
            this.dealerSecondCardImg.Name = "dealerSecondCardImg";
            this.dealerSecondCardImg.Size = new System.Drawing.Size(100, 135);
            this.dealerSecondCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerSecondCardImg.TabIndex = 15;
            this.dealerSecondCardImg.TabStop = false;
            // 
            // dealerFirstCardImg
            // 
            this.dealerFirstCardImg.BackColor = System.Drawing.Color.Transparent;
            this.dealerFirstCardImg.Location = new System.Drawing.Point(58, 233);
            this.dealerFirstCardImg.Name = "dealerFirstCardImg";
            this.dealerFirstCardImg.Size = new System.Drawing.Size(100, 135);
            this.dealerFirstCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerFirstCardImg.TabIndex = 14;
            this.dealerFirstCardImg.TabStop = false;
            // 
            // playerThirdCardImg
            // 
            this.playerThirdCardImg.BackColor = System.Drawing.Color.Transparent;
            this.playerThirdCardImg.Location = new System.Drawing.Point(345, 35);
            this.playerThirdCardImg.Name = "playerThirdCardImg";
            this.playerThirdCardImg.Size = new System.Drawing.Size(100, 135);
            this.playerThirdCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerThirdCardImg.TabIndex = 13;
            this.playerThirdCardImg.TabStop = false;
            // 
            // playerSecondCardImg
            // 
            this.playerSecondCardImg.BackColor = System.Drawing.Color.Transparent;
            this.playerSecondCardImg.Location = new System.Drawing.Point(207, 35);
            this.playerSecondCardImg.Name = "playerSecondCardImg";
            this.playerSecondCardImg.Size = new System.Drawing.Size(100, 135);
            this.playerSecondCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerSecondCardImg.TabIndex = 12;
            this.playerSecondCardImg.TabStop = false;
            // 
            // playerFirstCardImg
            // 
            this.playerFirstCardImg.BackColor = System.Drawing.Color.Transparent;
            this.playerFirstCardImg.Location = new System.Drawing.Point(58, 35);
            this.playerFirstCardImg.Name = "playerFirstCardImg";
            this.playerFirstCardImg.Size = new System.Drawing.Size(100, 135);
            this.playerFirstCardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerFirstCardImg.TabIndex = 11;
            this.playerFirstCardImg.TabStop = false;
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
            // Server_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_Server.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(808, 465);
            this.Controls.Add(this.drawCardBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerThirdCardImg);
            this.Controls.Add(this.dealerSecondCardImg);
            this.Controls.Add(this.dealerFirstCardImg);
            this.Controls.Add(this.playerThirdCardImg);
            this.Controls.Add(this.playerSecondCardImg);
            this.Controls.Add(this.playerFirstCardImg);
            this.Name = "Server_Window";
            this.Text = "BlackJack Server";
            ((System.ComponentModel.ISupportInitialize)(this.dealerThirdCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerSecondCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerFirstCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerThirdCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSecondCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerFirstCardImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dealerThirdCardImg;
        private System.Windows.Forms.PictureBox dealerSecondCardImg;
        private System.Windows.Forms.PictureBox dealerFirstCardImg;
        private System.Windows.Forms.PictureBox playerThirdCardImg;
        private System.Windows.Forms.PictureBox playerSecondCardImg;
        private System.Windows.Forms.PictureBox playerFirstCardImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawCardBtn;
    }
}

