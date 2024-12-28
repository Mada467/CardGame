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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playerFirstCardImg = new System.Windows.Forms.PictureBox();
            this.playerSecondCardImg = new System.Windows.Forms.PictureBox();
            this.playerThirdCardImg = new System.Windows.Forms.PictureBox();
            this.dealerThirdCardImg = new System.Windows.Forms.PictureBox();
            this.dealerSecondCardImg = new System.Windows.Forms.PictureBox();
            this.dealerFirstCardImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerFirstCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSecondCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerThirdCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerThirdCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerSecondCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerFirstCardImg)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(672, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playerFirstCardImg
            // 
            this.playerFirstCardImg.Location = new System.Drawing.Point(72, 333);
            this.playerFirstCardImg.Name = "playerFirstCardImg";
            this.playerFirstCardImg.Size = new System.Drawing.Size(100, 50);
            this.playerFirstCardImg.TabIndex = 5;
            this.playerFirstCardImg.TabStop = false;
            // 
            // playerSecondCardImg
            // 
            this.playerSecondCardImg.Location = new System.Drawing.Point(221, 333);
            this.playerSecondCardImg.Name = "playerSecondCardImg";
            this.playerSecondCardImg.Size = new System.Drawing.Size(100, 50);
            this.playerSecondCardImg.TabIndex = 6;
            this.playerSecondCardImg.TabStop = false;
            // 
            // playerThirdCardImg
            // 
            this.playerThirdCardImg.Location = new System.Drawing.Point(359, 333);
            this.playerThirdCardImg.Name = "playerThirdCardImg";
            this.playerThirdCardImg.Size = new System.Drawing.Size(100, 50);
            this.playerThirdCardImg.TabIndex = 7;
            this.playerThirdCardImg.TabStop = false;
            // 
            // dealerThirdCardImg
            // 
            this.dealerThirdCardImg.Location = new System.Drawing.Point(359, 50);
            this.dealerThirdCardImg.Name = "dealerThirdCardImg";
            this.dealerThirdCardImg.Size = new System.Drawing.Size(100, 50);
            this.dealerThirdCardImg.TabIndex = 10;
            this.dealerThirdCardImg.TabStop = false;
            // 
            // dealerSecondCardImg
            // 
            this.dealerSecondCardImg.Location = new System.Drawing.Point(221, 50);
            this.dealerSecondCardImg.Name = "dealerSecondCardImg";
            this.dealerSecondCardImg.Size = new System.Drawing.Size(100, 50);
            this.dealerSecondCardImg.TabIndex = 9;
            this.dealerSecondCardImg.TabStop = false;
            // 
            // dealerFirstCardImg
            // 
            this.dealerFirstCardImg.Location = new System.Drawing.Point(72, 50);
            this.dealerFirstCardImg.Name = "dealerFirstCardImg";
            this.dealerFirstCardImg.Size = new System.Drawing.Size(100, 50);
            this.dealerFirstCardImg.TabIndex = 8;
            this.dealerFirstCardImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEALER";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "MagicButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerThirdCardImg);
            this.Controls.Add(this.dealerSecondCardImg);
            this.Controls.Add(this.dealerFirstCardImg);
            this.Controls.Add(this.playerThirdCardImg);
            this.Controls.Add(this.playerSecondCardImg);
            this.Controls.Add(this.playerFirstCardImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ipAddress_Tb);
            this.Controls.Add(this.connect_Btn);
            this.Name = "Client_Window";
            this.Text = "BlackJack Client";
            this.Load += new System.EventHandler(this.Client_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerFirstCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSecondCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerThirdCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerThirdCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerSecondCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerFirstCardImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect_Btn;
        private System.Windows.Forms.TextBox ipAddress_Tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox playerFirstCardImg;
        private System.Windows.Forms.PictureBox playerSecondCardImg;
        private System.Windows.Forms.PictureBox playerThirdCardImg;
        private System.Windows.Forms.PictureBox dealerThirdCardImg;
        private System.Windows.Forms.PictureBox dealerSecondCardImg;
        private System.Windows.Forms.PictureBox dealerFirstCardImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

