using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicBoControls
{
    public class AnyOneNumber : BettingSpot
    {

        private int _winningNumber = -1;

        public int WinningNumber
        {
            set
            {
                _winningNumber = value;
                lblText.Text = this.numberInWords[_winningNumber - 1].ToUpper();
                picDie.Image = this.GetImageResourceByName("Dice" + _winningNumber.ToString());
            }
            get
            {
                return _winningNumber;
            }
        }

        public override void ComputePayOut(int[] Dice)
        {
            int myMatches = 0;
            _winning = 0;
            this.BackgroundImage = SicBoControls.Properties.Resources.AnyOne0;
            for (int i = 0; i < maxDice; i++)
            {
                if (Dice[i] == _winningNumber)
                    myMatches++;
            }
            if (myMatches > 0)
            {
                this.BackgroundImage = SicBoControls.Properties.Resources.AnyOne1;
                _winning = (myMatches * Pays * _bet);
            }
            if ((myMatches == 0) && (_bet > 0))
                _winning = 0 -_bet;
        }

    }
}
