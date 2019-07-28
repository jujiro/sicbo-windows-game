using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SicBoControls
{
    
    public partial class BettingSpot : UserControl
    {

        protected int maxDice = 3;
        protected int _pays = 0;
        protected int _bet = 0;
        protected int _winning = 0;

        protected string[] numberInWords = {"One", "Two", "Three", "Four", "Five" ,"Six"}; 

        public int Pays
        {
            get
            {
                return _pays;
            }
            set
            {
                _pays = value;
            }
        }

        public int Bet
        {
            get
            {
                return _bet;
            }
        }

        public int Winning
        {
            get
            {
                return _winning;
            }
        }

        public int PayOut
        {
            get
            {
                return _winning;
            }
        }

        public void PlaceBet(int betIncrement)
        {
            _bet = _bet + betIncrement;
            _bet = (_bet < 0) ? 0 : _bet;
            if (_bet > 0)
            {
                this.lblBet.Text = _bet.ToString();
                this.lblBet.Visible = true;
                this.picChip.Visible = true;
            }
            else
            {
                this.picChip.Visible = false;
                this.lblBet.Visible = false;
            }
        }

        public void ClearAllBets()
        {
            _bet = 0;
            this.picChip.Visible = false;
            this.lblBet.Visible = false;
        }

        public delegate void ButtonClickHandler(object sender, string plusMinus);

        public event ButtonClickHandler ButtonClick;

        protected virtual void RaiseButtonClick(string plusMinus)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, plusMinus);
            }
        }

        public BettingSpot()
        {
            InitializeComponent();
            this.Click += new EventHandler(BettingSpot_Click); 
            foreach (Control ctl in this.Controls)
            {
                ctl.Click += new EventHandler(BettingSpot_Click);
            }
            this.picChip.Visible = false;
            this.lblBet.Visible = false;
            _winning = 0;
            _bet = 0;
            this.lblOdds.Visible = false;
        }

        protected void BettingSpot_Click(object sender, EventArgs e)
        {
            RaiseButtonClick((Control.ModifierKeys == Keys.Shift)?"-":"+");
        }

        public virtual void ComputePayOut(int[] Dice)
        {
            // This method will need to be customized for every type of bet.
            _winning = 0;
        }

        public System.Drawing.Image GetImageResourceByName(string imageName)
        {
            return (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject(imageName);
        }
    }

    public class BettingSpotCollection : CollectionBase
    {
        public IList GetList
        {
            get
            {
                return List;
            }
        }
        public void Add(BettingSpot bt)
        {
            List.Add(bt);
        }
    } 
}
