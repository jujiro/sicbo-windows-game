using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class TwoOfAKind : BettingSpot
    {
        private int _winningNumber = 0;

        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.PictureBox picDie1;

        public TwoOfAKind()
        {
            InitializeComponent();
            // Associate the two dice with the Placebet handler
            this.picDie1.Click += new EventHandler(BettingSpot_Click);
            this.picDie2.Click += new EventHandler(BettingSpot_Click);
        }

        public int WinningNumber 
        {
            set
            {
                _winningNumber = value;
                this.picDie1.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_winningNumber).ToString());
                this.picDie2.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_winningNumber).ToString());
            }
        }

        private void InitializeComponent()
        {
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = false;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 1);
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.Visible = false;
            // 
            // picDie
            // 
            this.picDie.Location = new System.Drawing.Point(3, 33);
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(2, 17);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(13, 28);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = false;
            this.lblOdds.Location = new System.Drawing.Point(6, 26);
            this.lblOdds.Size = new System.Drawing.Size(22, 12);
            // 
            // picDie1
            // 
            this.picDie1.BackgroundImage = global::SicBoControls.Properties.Resources.Dice3;
            this.picDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDie1.Location = new System.Drawing.Point(6, 6);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(22, 22);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDie1.TabIndex = 6;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.BackgroundImage = global::SicBoControls.Properties.Resources.Dice6;
            this.picDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDie2.InitialImage = global::SicBoControls.Properties.Resources.Dice5;
            this.picDie2.Location = new System.Drawing.Point(6, 34);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(22, 22);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDie2.TabIndex = 7;
            this.picDie2.TabStop = false;
            // 
            // TwoOfAKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.Double0;
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Name = "TwoOfAKind";
            this.Size = new System.Drawing.Size(33, 63);
            this.Controls.SetChildIndex(this.picDie, 0);
            this.Controls.SetChildIndex(this.lblText, 0);
            this.Controls.SetChildIndex(this.picDie1, 0);
            this.Controls.SetChildIndex(this.picDie2, 0);
            this.Controls.SetChildIndex(this.picChip, 0);
            this.Controls.SetChildIndex(this.lblOdds, 0);
            this.Controls.SetChildIndex(this.lblBet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void ComputePayOut(int[] Dice)
        {
            // Pay when two dice have the same number.
            int myMatches = 0;
            _winning = 0;
            this.BackgroundImage = SicBoControls.Properties.Resources.Double0;
            for (int i = 0; i < maxDice; i++)
            {
                if (Dice[i] == _winningNumber)
                    myMatches++;
            }
            if (myMatches > 1)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.Double1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches < 2) && (_bet > 0))
                _winning = 0 - _bet;
        }

    }
}
