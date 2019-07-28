namespace SicBoControls
{
    partial class BettingSpot
    {
        /// <summary>
        /// Displays an image of a dice and the corresponding number.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.picDie = new System.Windows.Forms.PictureBox();
            this.picChip = new System.Windows.Forms.PictureBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblOdds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Location = new System.Drawing.Point(8, 11);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(24, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "SIX";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDie
            // 
            this.picDie.BackgroundImage = global::SicBoControls.Properties.Resources.Dice6;
            this.picDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie.Location = new System.Drawing.Point(60, 6);
            this.picDie.Name = "picDie";
            this.picDie.Size = new System.Drawing.Size(25, 25);
            this.picDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie.TabIndex = 2;
            this.picDie.TabStop = false;
            // 
            // picChip
            // 
            this.picChip.BackColor = System.Drawing.Color.Transparent;
            this.picChip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picChip.Image = global::SicBoControls.Properties.Resources.Chip;
            this.picChip.Location = new System.Drawing.Point(27, 3);
            this.picChip.Name = "picChip";
            this.picChip.Size = new System.Drawing.Size(30, 30);
            this.picChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picChip.TabIndex = 3;
            this.picChip.TabStop = false;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(38, 14);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(9, 9);
            this.lblBet.TabIndex = 4;
            this.lblBet.Text = "0";
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = true;
            this.lblOdds.BackColor = System.Drawing.Color.Transparent;
            this.lblOdds.Location = new System.Drawing.Point(7, 9);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(32, 13);
            this.lblOdds.TabIndex = 5;
            this.lblOdds.Text = "Odds";
            // 
            // BettingSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SicBoControls.Properties.Resources.AnyOne0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.picChip);
            this.Controls.Add(this.picDie);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblOdds);
            this.Name = "BettingSpot";
            this.Size = new System.Drawing.Size(96, 37);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblText;
        protected System.Windows.Forms.PictureBox picDie;
        protected System.Windows.Forms.PictureBox picChip;
        protected System.Windows.Forms.Label lblBet;
        protected System.Windows.Forms.Label lblOdds;




    }
}
