namespace FlagApplication
{
    partial class FlagApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlagApplication));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.finlandFlag = new System.Windows.Forms.PictureBox();
            this.franceFlag = new System.Windows.Forms.PictureBox();
            this.germanyFlag = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(0, 40);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(703, 25);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click a flag to see the name of its country.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finlandFlag
            // 
            this.finlandFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finlandFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finlandFlag.Image = ((System.Drawing.Image)(resources.GetObject("finlandFlag.Image")));
            this.finlandFlag.Location = new System.Drawing.Point(5, 97);
            this.finlandFlag.Name = "finlandFlag";
            this.finlandFlag.Size = new System.Drawing.Size(210, 100);
            this.finlandFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandFlag.TabIndex = 1;
            this.finlandFlag.TabStop = false;
            this.finlandFlag.Click += new System.EventHandler(this.finlandFlag_Click);
            // 
            // franceFlag
            // 
            this.franceFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.franceFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.franceFlag.Image = ((System.Drawing.Image)(resources.GetObject("franceFlag.Image")));
            this.franceFlag.Location = new System.Drawing.Point(243, 97);
            this.franceFlag.Name = "franceFlag";
            this.franceFlag.Size = new System.Drawing.Size(210, 100);
            this.franceFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.franceFlag.TabIndex = 2;
            this.franceFlag.TabStop = false;
            this.franceFlag.Click += new System.EventHandler(this.franceFlag_Click);
            // 
            // germanyFlag
            // 
            this.germanyFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanyFlag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.germanyFlag.Image = ((System.Drawing.Image)(resources.GetObject("germanyFlag.Image")));
            this.germanyFlag.Location = new System.Drawing.Point(482, 97);
            this.germanyFlag.Name = "germanyFlag";
            this.germanyFlag.Size = new System.Drawing.Size(210, 100);
            this.germanyFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyFlag.TabIndex = 3;
            this.germanyFlag.TabStop = false;
            this.germanyFlag.Click += new System.EventHandler(this.germanyFlag_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(5, 232);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(687, 89);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlagApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(696, 332);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyFlag);
            this.Controls.Add(this.franceFlag);
            this.Controls.Add(this.finlandFlag);
            this.Controls.Add(this.instructionLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FlagApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flag Application";
            ((System.ComponentModel.ISupportInitialize)(this.finlandFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox finlandFlag;
        private System.Windows.Forms.PictureBox franceFlag;
        private System.Windows.Forms.PictureBox germanyFlag;
        private System.Windows.Forms.Label countryLabel;
    }
}

