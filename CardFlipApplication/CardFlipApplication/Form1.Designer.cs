namespace CardFlipApplication
{
    partial class CardFlipApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardFlipApplication));
            this.faceDownCard = new System.Windows.Forms.PictureBox();
            this.faceUpCard = new System.Windows.Forms.PictureBox();
            this.faceDownButton = new System.Windows.Forms.Button();
            this.faceUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faceDownCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceUpCard)).BeginInit();
            this.SuspendLayout();
            // 
            // faceDownCard
            // 
            this.faceDownCard.Image = ((System.Drawing.Image)(resources.GetObject("faceDownCard.Image")));
            this.faceDownCard.Location = new System.Drawing.Point(79, 42);
            this.faceDownCard.Name = "faceDownCard";
            this.faceDownCard.Size = new System.Drawing.Size(364, 515);
            this.faceDownCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.faceDownCard.TabIndex = 0;
            this.faceDownCard.TabStop = false;
            // 
            // faceUpCard
            // 
            this.faceUpCard.Image = ((System.Drawing.Image)(resources.GetObject("faceUpCard.Image")));
            this.faceUpCard.Location = new System.Drawing.Point(562, 42);
            this.faceUpCard.Name = "faceUpCard";
            this.faceUpCard.Size = new System.Drawing.Size(364, 515);
            this.faceUpCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.faceUpCard.TabIndex = 1;
            this.faceUpCard.TabStop = false;
            this.faceUpCard.Visible = false;
            // 
            // faceDownButton
            // 
            this.faceDownButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceDownButton.Location = new System.Drawing.Point(79, 604);
            this.faceDownButton.Name = "faceDownButton";
            this.faceDownButton.Size = new System.Drawing.Size(364, 51);
            this.faceDownButton.TabIndex = 2;
            this.faceDownButton.Text = "Show the Card Back";
            this.faceDownButton.UseVisualStyleBackColor = true;
            this.faceDownButton.Click += new System.EventHandler(this.faceDownButton_Click);
            // 
            // faceUpButton
            // 
            this.faceUpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceUpButton.Location = new System.Drawing.Point(562, 604);
            this.faceUpButton.Name = "faceUpButton";
            this.faceUpButton.Size = new System.Drawing.Size(364, 51);
            this.faceUpButton.TabIndex = 3;
            this.faceUpButton.Text = "Show the Card Front";
            this.faceUpButton.UseVisualStyleBackColor = true;
            this.faceUpButton.Click += new System.EventHandler(this.faceUpButton_Click);
            // 
            // CardFlipApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.faceUpButton);
            this.Controls.Add(this.faceDownButton);
            this.Controls.Add(this.faceUpCard);
            this.Controls.Add(this.faceDownCard);
            this.MaximizeBox = false;
            this.Name = "CardFlipApplication";
            this.ShowIcon = false;
            this.Text = "Card Flip Application";
            ((System.ComponentModel.ISupportInitialize)(this.faceDownCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceUpCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox faceDownCard;
        private System.Windows.Forms.PictureBox faceUpCard;
        private System.Windows.Forms.Button faceDownButton;
        private System.Windows.Forms.Button faceUpButton;
    }
}

