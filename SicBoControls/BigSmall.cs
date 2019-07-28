using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class BigSmall : BettingSpot
    {
        private string _BigSmall = "";

        public string BigOrSmall
        {
            set
            {
                _BigSmall = value;
                switch (_BigSmall)
                {
                    case "Small":
                        lblText.Text = "SMALL";
                        lblOdds.Text = "Are numbers 4 to 10\r1 wins 1\rLose if any triple appears";
                        break;
                    case "Big":
                        lblText.Text = "BIG";
                        lblOdds.Text = "Are numbers 11 to 17\r1 wins 1\rLose if any triple appears";
                        break;
                }
            }
        }

        public BigSmall()
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
            this.lblText.Location = new System.Drawing.Point(3, 7);
            this.lblText.Size = new System.Drawing.Size(87, 14);
            // 
            // picDice
            // 
            this.picDie.Location = new System.Drawing.Point(65, 55);
            this.picDie.Visible = false;
            // 
            // picChip
            // 
            this.picChip.Location = new System.Drawing.Point(32, 37);
            // 
            // lblBet
            // 
            this.lblBet.Location = new System.Drawing.Point(42, 47);
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = false;
            this.lblOdds.Location = new System.Drawing.Point(4, 29);
            this.lblOdds.Size = new System.Drawing.Size(86, 51);
            this.lblOdds.Text = "1 Wins 1";
            this.lblOdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdds.Visible = true;
            // 
            // BigSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::SicBoControls.Properties.Resources.BigSmall0;
            this.Name = "BigSmall";
            this.Size = new System.Drawing.Size(96, 89);
            ((System.ComponentModel.ISupportInitialize)(this.picDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void ComputePayOut(int[] Dice)
        {
            // Winning: No triplets.  
            // Small: Total of three dice between 4 and 10
            // Big: Total of three dice between 11 and 17
            int myMatches = 0;
            int tot=Dice[0]+Dice[1]+Dice[2];

            _winning = 0;

            this.BackgroundImage = SicBoControls.Properties.Resources.BigSmall0;
            if (!((Dice[0] == Dice[1]) && (Dice[0] == Dice[2]))) // No triplets
            {
                if ((_BigSmall == "Small") && (tot >= 4) && (tot <= 10))
                    myMatches++;
                if ((_BigSmall == "Big") && (tot >= 11) && (tot <= 17))
                    myMatches++;
            }
            if (myMatches > 0)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.BigSmall1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches == 0) && (_bet > 0))
                _winning = 0 - _bet;
        }
    }
}
