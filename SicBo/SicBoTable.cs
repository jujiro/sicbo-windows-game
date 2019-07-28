using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SicBo
{
    public partial class SicBoTable : Form
    {
        const int maxAnyOneNumber = 6;
        const int maxBigSmall = 2;
        const int maxAllDiceTotals = 14;
        const int maxTwoDiceCombos = 15;
        const int maxTwoOfAKindCombos = 6;
        const int maxThreeOfAKindCombos = 6;

        private int credits = 0;
        private int myBets = 0;
        private int winningsInLastRoll = 0;
        private int totalWinnings = 0;
        private bool muted = false;

        int[,] AnyOneNumberPositions = new int[maxAnyOneNumber, 4] {
                    {7,324,1,1}, // X, Y, Pays, Winning Number
                    {106,324,1,2},
                    {204,324,1,3},
                    {303,324,1,4},
                    {402,324,1,5},
                    {499,324,1,6}};

        int[,] BigSmallPositions = new int[maxBigSmall, 4] {
            {9,85,1,0},// X, Y, Pays, 0=Small, 1=Big
            {501,85,1,1}};

        int[,] allDiceTotalPositions = new int[maxAllDiceTotals, 4] {
            {9,180,60,4},// X, Y, Pays, Winning Number
            {50,180,20,5},
            {93,180,18,6},
            {135,180,12,7},
            {177,180,8,8},
            {219,180,6,9},
            {261,180,6,10},
            {303,180,6,11},
            {346,180,6,12},
            {388,180,8,13},
            {430,180,12,14},
            {472,180,18,15},
            {514,180,20,16},
            {557,180,60,17}};

        int[,] twoDiceComboPositions = new int[maxTwoDiceCombos, 5] {
            {67,251,6,1,2},// X, Y, Pays, Die1, Die2
            {102,251,6,1,3},
            {137,251,6,1,4},
            {173,251,6,1,5},
            {209,251,6,1,6},
            {244,251,6,2,3},
            {279,251,6,2,4},
            {314,251,6,2,5},
            {348,251,6,2,6},
            {385,251,6,3,4},
            {420,251,6,3,5},
            {455,251,6,3,6},
            {491,251,6,4,5},
            {526,251,6,4,6},
            {563,251,6,5,6}};

        int[,] twoOfAKindPositions = new int[maxTwoOfAKindCombos, 4] {
            {109,113,11,1},// X, Y, Pays, Winning Number
            {149,113,11,2},
            {187,113,11,3},
            {383,113,11,4},
            {421,113,11,5},
            {460,113,11,6}};

        int[,] threeOfAKindPositions = new int[maxThreeOfAKindCombos, 4] {
            {226,114,180,1},// X, Y, Pays, Winning Number
            {226,134,180,2},
            {226,156,180,3},
            {324,114,180,4},
            {324,134,180,5},
            {324,156,180,6}};

        private SicBoControls.AnyOneNumber[] anyOneNumber = new SicBoControls.AnyOneNumber[maxAnyOneNumber];
        private SicBoControls.BigSmall[] bigSmall = new SicBoControls.BigSmall[maxBigSmall];
        private SicBoControls.AllDiceTotal[] allDiceTotal = new SicBoControls.AllDiceTotal[maxAllDiceTotals];
        private SicBoControls.TwoDiceCombo[] twoDiceCombo = new SicBoControls.TwoDiceCombo[maxTwoDiceCombos];
        private SicBoControls.TwoOfAKind[] twoOfAKind = new SicBoControls.TwoOfAKind[maxTwoOfAKindCombos];
        private SicBoControls.ThreeOfAKind[] threeOfAKind = new SicBoControls.ThreeOfAKind[maxThreeOfAKindCombos];

        private SicBoControls.BettingSpotCollection bsc = new SicBoControls.BettingSpotCollection();

        public SicBoTable()
        {
            InitializeComponent();
            // Construct rest of the SicBo table using user controls
            // AnyNumber1
            for (int i = 0; i < maxAnyOneNumber; i++)
            {
                this.anyOneNumber[i] = new SicBoControls.AnyOneNumber();
                this.anyOneNumber[i].Pays = AnyOneNumberPositions[i, 2];
                this.anyOneNumber[i].WinningNumber = AnyOneNumberPositions[i, 3];
                this.anyOneNumber[i].Location = new System.Drawing.Point(AnyOneNumberPositions[i, 0], AnyOneNumberPositions[i, 1]);
                this.Controls.Add(this.anyOneNumber[i]);
                bsc.Add(this.anyOneNumber[i]);
            }

            // Big and Small
            for (int i = 0; i < maxBigSmall; i++)
            {
                this.bigSmall[i] = new SicBoControls.BigSmall();
                this.bigSmall[i].Pays = BigSmallPositions[i, 2];
                this.bigSmall[i].Location = new System.Drawing.Point(BigSmallPositions[i, 0], BigSmallPositions[i, 1]);
                this.bigSmall[i].BigOrSmall = (BigSmallPositions[i, 3] == 0) ? "Small" : "Big";
                this.Controls.Add(this.bigSmall[i]);
                bsc.Add(this.bigSmall[i]);
            }

            // Any triplets
            this.anyTriplets.Pays = 30;
            bsc.Add(this.anyTriplets);

            // AllDiceTotals
            for (int i = 0; i < maxAllDiceTotals; i++)
            {
                this.allDiceTotal[i] = new SicBoControls.AllDiceTotal();
                this.allDiceTotal[i].Pays = allDiceTotalPositions[i, 2];
                this.allDiceTotal[i].WinningNumber = allDiceTotalPositions[i, 3];
                this.allDiceTotal[i].Location = new System.Drawing.Point(allDiceTotalPositions[i, 0], allDiceTotalPositions[i, 1]);
                this.Controls.Add(this.allDiceTotal[i]);
                bsc.Add(this.allDiceTotal[i]);
            }

            // Two dice combo
            for (int i = 0; i < maxTwoDiceCombos; i++)
            {
                this.twoDiceCombo[i] = new SicBoControls.TwoDiceCombo();
                this.twoDiceCombo[i].Pays = twoDiceComboPositions[i, 2];
                this.twoDiceCombo[i].Die1 = twoDiceComboPositions[i, 3];
                this.twoDiceCombo[i].Die2 = twoDiceComboPositions[i, 4];
                this.twoDiceCombo[i].Location = new System.Drawing.Point(twoDiceComboPositions[i, 0], twoDiceComboPositions[i, 1]);
                this.Controls.Add(this.twoDiceCombo[i]);
                bsc.Add(this.twoDiceCombo[i]);
            }

            // Two of a kind
            for (int i = 0; i < maxTwoOfAKindCombos; i++)
            {
                this.twoOfAKind[i] = new SicBoControls.TwoOfAKind();
                this.twoOfAKind[i].Pays = twoOfAKindPositions[i, 2];
                this.twoOfAKind[i].WinningNumber = twoOfAKindPositions[i, 3];
                this.twoOfAKind[i].Location = new System.Drawing.Point(twoOfAKindPositions[i, 0], twoOfAKindPositions[i, 1]);
                this.Controls.Add(this.twoOfAKind[i]);
                bsc.Add(this.twoOfAKind[i]);
            }

            // Three of a kind
            for (int i = 0; i < maxThreeOfAKindCombos; i++)
            {
                this.threeOfAKind[i] = new SicBoControls.ThreeOfAKind();
                this.threeOfAKind[i].Pays = threeOfAKindPositions[i, 2];
                this.threeOfAKind[i].WinningNumber = threeOfAKindPositions[i, 3];
                this.threeOfAKind[i].Location = new System.Drawing.Point(threeOfAKindPositions[i, 0], threeOfAKindPositions[i, 1]);
                this.Controls.Add(this.threeOfAKind[i]);
                bsc.Add(this.threeOfAKind[i]);
            }

            // Set the click event handler for placing a bet
            foreach (SicBoControls.BettingSpot obj in bsc)
            {
                obj.ButtonClick += new SicBoControls.BettingSpot.ButtonClickHandler(PlaceBet_ButtonClicked);
            }

            // Give the player $200 worth of credits.
            this.credits = 200;
            updateCredits();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Sic Bo",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuyChips_Click(object sender, EventArgs e)
        {
            // InputBox with value validation - first define validation delegate, which
            // returns empty string for valid values and error message for invalid values
            InputBoxValidation validation = delegate (string val)
            {
                if (val == "")
                    return "Please enter the amount";
                int num;
                bool isNumeric = int.TryParse(val, out num);
                if (!(isNumeric))
                {
                    return "Please enter a valid integer amount";
                }
                if (int.Parse(val) < 1)
                {
                    return "Please enter a valid amount > 0";
                }
                return "";
            };
            string value = "0";
            if (InputBox.Show("Buy Chips", "Enter the amount of chips you want to buy (Whole number only)", ref value, validation) == DialogResult.OK)
            {
                this.credits = Convert.ToInt16(value);
            }
            updateCredits();
        }

        private void PlaceBet_ButtonClicked(object sender, string plusMinus)
        {
            SicBoControls.BettingSpot obj = (SicBoControls.BettingSpot)sender;
            int oldBet = obj.Bet;
            if (plusMinus == "-")
                obj.PlaceBet(-Convert.ToInt16(this.numUpDownBetIncrement.Value));
            else
            {
                if ((this.credits - this.myBets) < Convert.ToInt16(this.numUpDownBetIncrement.Value))
                {
                    MessageBox.Show("You don't have enough money to bet");
                    return;
                }
                obj.PlaceBet(Convert.ToInt16(this.numUpDownBetIncrement.Value));
            }
            int newBet = obj.Bet;
            this.myBets += -oldBet + newBet;
            updateCredits();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int totGain = 0;
            if (this.myBets > this.credits)
            {
                MessageBox.Show("Cannot roll. Your bet(s) exceed the credits");
                return;
            }
            this.credits -= this.myBets;
            updateCredits();
            int[] dice = rolledDice1.RollDice(muted);
            foreach (SicBoControls.BettingSpot obj in bsc)
            {
                obj.ComputePayOut(dice);
                totGain += obj.Winning;
            }
            this.winningsInLastRoll = totGain;
            this.totalWinnings += totGain;
            this.credits += (totGain >= 0) ? totGain + this.myBets : 0;
            updateCredits();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (SicBoControls.BettingSpot obj in bsc)
            {
                obj.ClearAllBets();
            }
            this.myBets = 0;
            updateCredits();
        }

        private void updateCredits()
        {
            this.txtCredits.Text = this.credits.ToString("C", CultureInfo.CurrentCulture);
            this.txtBet.Text = this.myBets.ToString("C", CultureInfo.CurrentCulture);
            this.txtWinRoll.Text = this.winningsInLastRoll.ToString("C", CultureInfo.CurrentCulture);
            this.txtWinTotal.Text = this.totalWinnings.ToString("C", CultureInfo.CurrentCulture);
            Application.DoEvents();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SicBo.About frmAbout = new SicBo.About();
            frmAbout.ShowDialog();
        }

        private void ckMute_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckMute.CheckState == CheckState.Unchecked)
            {
                //Unmute
                this.ckMute.BackgroundImage = SicBo.Properties.Resources.SoundOn;
                muted = false;
            }
            else
            {
                this.ckMute.BackgroundImage = SicBo.Properties.Resources.SoundOff;
                muted = true;
            }
        }
    }
}
