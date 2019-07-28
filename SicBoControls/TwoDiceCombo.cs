using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{

    public class TwoDiceCombo : BettingSpot
    {
        private int _die1 = 0;
        private int _die2 = 0;

        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.PictureBox picDie1;
    
        public TwoDiceCombo()
        {
            InitializeComponent();
            // Associate the two dice with the Placebet handler
            this.picDie1.Click += new EventHandler(BettingSpot_Click);
            this.picDie2.Click += new EventHandler(BettingSpot_Click);
        }

        public int Die1 
        {
            set
            {
                _die1 = value;
                lblText.Text = _die1.ToString() + " and " + _die2.ToString();
                this.picDie1.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_die1).ToString());
            }
        }

        public int Die2
        {
            set
            {
                _die2 = value;
                lblText.Text = _die1.ToString() + " and " + _die2.ToString();
                this.picDie2.BackgroundImage = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + (_die2).ToString());
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
            this.lblText.Location = new System.Drawing.Point(2, 30);
            this.lblText.Size = new System.Drawing.Size(31, 13);
            // 
            // picDie
            // 
            this.picDie.Location = new System.Drawing.Point(3, 22);
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(2, 3);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(13, 14);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = false;
            this.lblOdds.Location = new System.Drawing.Point(7, 30);
            this.lblOdds.Size = new System.Drawing.Size(22, 12);
            // 
            // picDie1
            // 
            this.picDie1.BackgroundImage = global::SicBoControls.Properties.Resources.Dice3;
            this.picDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie1.Location = new System.Drawing.Point(5, 5);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(25, 25);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie1.TabIndex = 6;
            this.picDie1.TabStop = false;
            // 
            // picDie2
            // 
            this.picDie2.BackgroundImage = global::SicBoControls.Properties.Resources.Dice6;
            this.picDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDie2.InitialImage = global::SicBoControls.Properties.Resources.Dice5;
            this.picDie2.Location = new System.Drawing.Point(5, 42);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(25, 25);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie2.TabIndex = 7;
            this.picDie2.TabStop = false;
            // 
            // TwoDiceCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.AnyTwo0;
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie1);
            this.Name = "TwoDiceCombo";
            this.Size = new System.Drawing.Size(35, 71);
            this.Controls.SetChildIndex(this.picDie1, 0);
            this.Controls.SetChildIndex(this.picDie, 0);
            this.Controls.SetChildIndex(this.lblOdds, 0);
            this.Controls.SetChildIndex(this.lblText, 0);
            this.Controls.SetChildIndex(this.picDie2, 0);
            this.Controls.SetChildIndex(this.picChip, 0);
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
            // Two of the three numbers must match to win
            int myMatches = 0;
            _winning = 0;
            int myDie1 = _die1;
            int myDie2 = _die2;

            this.BackgroundImage = SicBoControls.Properties.Resources.AnyTwo0;
            for (int i = 0; i < maxDice; i++)
            {
                if (Dice[i] == myDie1)
                {
                    myDie1 = -1; // So that it is not compared in the next iteration
                    myMatches++;
                }
                else
                    if (Dice[i] == myDie2)
                    {
                        myDie2 = -1;
                        myMatches++;
                    }
            }
            if (myMatches > 1)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.AnyTwo1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches < 2) && (_bet > 0))
                _winning = 0 - _bet;
        }

    }
}
