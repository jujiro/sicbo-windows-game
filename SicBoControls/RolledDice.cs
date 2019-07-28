using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SicBoControls
{
    public partial class RolledDice : UserControl
    {

        private static Random random = new Random();

        public RolledDice()
        {
            InitializeComponent();
        }

        public int[] RollDice(bool muted)
        {
            // Rolls three dice randomly and returns their values
            int[] dice={0,0,0};
            this.picBlackCover.Visible = true;
            Application.DoEvents();

            SoundPlayer simpleSound = new SoundPlayer(SicBoControls.Properties.Resources.Shake);
            if (!muted)
            {
                simpleSound.PlaySync();
            }
            Application.DoEvents();

            int num = random.Next(1, 7);
            setDiceImage(Dice1, num);
            dice[0] = num;
            
            num = random.Next(1, 7);
            setDiceImage(Dice2, num);
            dice[1] = num;

            num = random.Next(1, 7);
            setDiceImage(Dice3, num);
            dice[2] = num;

            this.picBlackCover.Visible = false;
            Application.DoEvents(); 
            return dice;
        }

        private void setDiceImage(System.Windows.Forms.PictureBox picDice, int num)
        {
            picDice.Image = (System.Drawing.Image)SicBoControls.Properties.Resources.ResourceManager.GetObject("Dice" + num.ToString());
        }
    }
}
