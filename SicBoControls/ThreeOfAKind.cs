using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class ThreeOfAKind : BettingSpot
    {
        private int _winningNumber = 0;

        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.PictureBox picDie3;
    
        public ThreeOfAKind()
        {
            InitializeComponent();
            // Associate the two dice with the Placebet handler
            this.picDie1.Click += new EventHandler(BettingSpot_Click);
            this.picDie2.Click += new EventHandler(BettingSpot_Click);
            this.picDie3.Click += new EventHandler(BettingSpot_Click);
        }

        public int WinningNumber
        {
            set
            {
                _winningNumber = value;
                this.picDie1.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_winningNumber).ToString());
                this.picDie2.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_winningNumber).ToString());
                this.picDie3.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_winningNumber).ToString());
            }
        }

        private void InitializeComponent()
        {
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            this.picDie3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(3, 2);
            this.lblText.Visible = false;
            // 
            // picDie
            // 
            this.picDie.Location = new System.Drawing.Point(36, 3);
            this.picDie.Size = new System.Drawing.Size(13, 11);
            this.picDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(14, -4);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(24, 6);
            // 
            // lblOdds
            // 
            this.lblOdds.Location = new System.Drawing.Point(12, 3);
            // 
            // picDie1
            // 
            this.picDie1.BackgroundImage = global::SicBoControls.Properties.Resources.Dice2;
            this.picDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie1.Location = new System.Drawing.Point(3, 2);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(14, 14);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie1.TabIndex = 6;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.BackgroundImage = global::SicBoControls.Properties.Resources.Dice2;
            this.picDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie2.Location = new System.Drawing.Point(20, 2);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(14, 14);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie2.TabIndex = 7;
            this.picDie2.TabStop = false;
            // 
            // picDie3
            // 
            this.picDie3.BackgroundImage = global::SicBoControls.Properties.Resources.Dice2;
            this.picDie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie3.Location = new System.Drawing.Point(37, 2);
            this.picDie3.Margin = new System.Windows.Forms.Padding(0);
            this.picDie3.Name = "picDie3";
            this.picDie3.Size = new System.Drawing.Size(14, 14);
            this.picDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie3.TabIndex = 8;
            this.picDie3.TabStop = false;
            // 
            // ThreeOfAKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.Tripple0;
            this.Controls.Add(this.picDie3);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Name = "ThreeOfAKind";
            this.Size = new System.Drawing.Size(55, 19);
            this.Controls.SetChildIndex(this.picDie1, 0);
            this.Controls.SetChildIndex(this.lblOdds, 0);
            this.Controls.SetChildIndex(this.lblText, 0);
            this.Controls.SetChildIndex(this.picDie, 0);
            this.Controls.SetChildIndex(this.picDie2, 0);
            this.Controls.SetChildIndex(this.picDie3, 0);
            this.Controls.SetChildIndex(this.picChip, 0);
            this.Controls.SetChildIndex(this.lblBet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void ComputePayOut(int[] Dice)
        {
            // Pay when all three numbers the same as the chosen number
            int myMatches = 0;
            _winning = 0;
            this.BackgroundImage = SicBoControls.Properties.Resources.Tripple0;
            for (int i = 0; i < maxDice; i++)
            {
                if (Dice[i] == _winningNumber)
                    myMatches++;
            }
            if (myMatches > 2)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.Tripple1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches < 2) && (_bet > 0))
                _winning = 0 - _bet;
        }

    }
}
