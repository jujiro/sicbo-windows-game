using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class AllDiceTotal : BettingSpot
    {
        private int _winningNumber=0;

        public int WinningNumber 
        {
            set
            {
                _winningNumber = value;
                this.lblText.Text = _winningNumber.ToString();
                this.lblOdds.Text = "1 wins\r" + _pays.ToString();
            }
        }

        public AllDiceTotal()
        {
            InitializeComponent();
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
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.DarkRed;
            this.lblText.Location = new System.Drawing.Point(3, 8);
            this.lblText.Size = new System.Drawing.Size(33, 23);
            // 
            // picDice
            // 
            this.picDie.Location = new System.Drawing.Point(6, 8);
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(3, 21);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(13, 31);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = false;
            this.lblOdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdds.Location = new System.Drawing.Point(3, 31);
            this.lblOdds.Size = new System.Drawing.Size(32, 29);
            this.lblOdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdds.Visible = true;
            // 
            // AllDiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.Total0;
            this.Name = "AllDiceTotal";
            this.Size = new System.Drawing.Size(38, 67);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void ComputePayOut(int[] Dice)
        {
            int myMatches = 0;
            int tot = Dice[0] + Dice[1] + Dice[2];
            _winning = 0;

            this.BackgroundImage = SicBoControls.Properties.Resources.Total0;
            if (tot == _winningNumber)
                myMatches++;

            if (myMatches > 0)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.Total1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches == 0) && (_bet > 0))
                _winning = 0 - _bet;
        }

    }
}
