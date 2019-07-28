using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class AnyTriplets : BettingSpot
    {
        private System.Windows.Forms.PictureBox[] picSmallDice = new System.Windows.Forms.PictureBox[18];

        public AnyTriplets()
        {
            InitializeComponent();
            int k = -1;
            // Create an image of the triplet combos.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    k++;
                    this.picSmallDice[k] = new System.Windows.Forms.PictureBox();
                    this.picSmallDice[k].BackgroundImage = this.GetImageResourceByName("Dice" + (j + 1).ToString());
                    this.picSmallDice[k].Margin= new System.Windows.Forms.Padding(0);
                    this.picSmallDice[k].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    this.picSmallDice[k].Location = new System.Drawing.Point(2+(i * 10), (j)*9+3);
                    this.picSmallDice[k].Name = "picSmallDice";
                    this.picSmallDice[k].Size = new System.Drawing.Size(8,8);
                    this.picSmallDice[k].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.picSmallDice[k].TabIndex = 2;
                    this.picSmallDice[k].TabStop = false;
                    this.Controls.Add(this.picSmallDice[k]);
                    // Let us associate the click event
                    this.picSmallDice[k].Click += new EventHandler(BettingSpot_Click);
                }
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = false;
            this.lblText.Location = new System.Drawing.Point(3, 22);
            this.lblText.Size = new System.Drawing.Size(18, 13);
            this.lblText.Visible = false;
            // 
            // picDice
            // 
            this.picDie.Location = new System.Drawing.Point(4, 3);
            this.picDie.Margin = new System.Windows.Forms.Padding(0);
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(2, 27);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(13, 37);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = false;
            this.lblOdds.Size = new System.Drawing.Size(22, 13);
            // 
            // AnyTriplets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.AnyTripple0;
            this.Name = "AnyTriplets";
            this.Size = new System.Drawing.Size(34, 62);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void ComputePayOut(int[] Dice)
        {
            int myMatches = 0;
            _winning = 0;
            this.BackgroundImage = SicBoControls.Properties.Resources.AnyTripple0;
            if ((Dice[0] == Dice[1]) && (Dice[0] == Dice[2]))
                myMatches++;
            if (myMatches > 0)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.AnyTripple1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches == 0) && (_bet > 0))
                _winning = 0 - _bet;
        }

    }
}
