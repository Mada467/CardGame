namespace CardGame
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
            this.playerCardsTextBox = new System.Windows.Forms.RichTextBox();
            this.dealerCardsTextBox = new System.Windows.Forms.RichTextBox();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.requestCardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerCardsTextBox
            // 
            this.playerCardsTextBox.Location = new System.Drawing.Point(60, 119);
            this.playerCardsTextBox.Name = "playerCardsTextBox";
            this.playerCardsTextBox.Size = new System.Drawing.Size(100, 96);
            this.playerCardsTextBox.TabIndex = 0;
            this.playerCardsTextBox.Text = "";
            // 
            // dealerCardsTextBox
            // 
            this.dealerCardsTextBox.Location = new System.Drawing.Point(588, 119);
            this.dealerCardsTextBox.Name = "dealerCardsTextBox";
            this.dealerCardsTextBox.Size = new System.Drawing.Size(100, 96);
            this.dealerCardsTextBox.TabIndex = 1;
            this.dealerCardsTextBox.Text = "";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(319, 309);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(75, 23);
            this.startGameBtn.TabIndex = 2;
            this.startGameBtn.Text = "START";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // requestCardBtn
            // 
            this.requestCardBtn.Location = new System.Drawing.Point(124, 355);
            this.requestCardBtn.Name = "requestCardBtn";
            this.requestCardBtn.Size = new System.Drawing.Size(89, 23);
            this.requestCardBtn.TabIndex = 3;
            this.requestCardBtn.Text = "Cere carte";
            this.requestCardBtn.UseVisualStyleBackColor = true;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestCardBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.dealerCardsTextBox);
            this.Controls.Add(this.playerCardsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox playerCardsTextBox;
        private System.Windows.Forms.RichTextBox dealerCardsTextBox;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button requestCardBtn;
    }
}

