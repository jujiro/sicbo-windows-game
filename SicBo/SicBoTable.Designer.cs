namespace SicBo
{
    partial class SicBoTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SicBoTable));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtWinRoll = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtWinTotal = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.numUpDownBetIncrement = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.ckMute = new System.Windows.Forms.CheckBox();
            this.rolledDice1 = new SicBoControls.RolledDice();
            this.anyTriplets = new SicBoControls.AnyTriplets();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBetIncrement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(789, 680);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 680);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Reset all bets");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(339, 680);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(82, 34);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "&Roll";
            this.toolTip1.SetToolTip(this.btnRoll, "Roll the dice");
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(244, 609);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(206, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Bet";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.Black;
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.ForeColor = System.Drawing.Color.White;
            this.txtBet.Location = new System.Drawing.Point(244, 640);
            this.txtBet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBet.Name = "txtBet";
            this.txtBet.ReadOnly = true;
            this.txtBet.Size = new System.Drawing.Size(206, 26);
            this.txtBet.TabIndex = 7;
            this.txtBet.TabStop = false;
            this.txtBet.Text = "0";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(134, 9);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(624, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Welcome to Sic Bo.  Good Luck!";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWinRoll
            // 
            this.txtWinRoll.BackColor = System.Drawing.Color.Black;
            this.txtWinRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinRoll.ForeColor = System.Drawing.Color.White;
            this.txtWinRoll.Location = new System.Drawing.Point(453, 640);
            this.txtWinRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWinRoll.Name = "txtWinRoll";
            this.txtWinRoll.ReadOnly = true;
            this.txtWinRoll.Size = new System.Drawing.Size(206, 26);
            this.txtWinRoll.TabIndex = 10;
            this.txtWinRoll.TabStop = false;
            this.txtWinRoll.Text = "0";
            this.txtWinRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(453, 609);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(206, 26);
            this.textBox5.TabIndex = 9;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Winning this time";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCredits
            // 
            this.txtCredits.BackColor = System.Drawing.Color.Black;
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.ForeColor = System.Drawing.Color.White;
            this.txtCredits.Location = new System.Drawing.Point(36, 640);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.ReadOnly = true;
            this.txtCredits.Size = new System.Drawing.Size(206, 26);
            this.txtCredits.TabIndex = 12;
            this.txtCredits.TabStop = false;
            this.txtCredits.Text = "0";
            this.txtCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(36, 609);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(206, 26);
            this.textBox6.TabIndex = 11;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Credits";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWinTotal
            // 
            this.txtWinTotal.BackColor = System.Drawing.Color.Black;
            this.txtWinTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinTotal.ForeColor = System.Drawing.Color.White;
            this.txtWinTotal.Location = new System.Drawing.Point(663, 640);
            this.txtWinTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWinTotal.Name = "txtWinTotal";
            this.txtWinTotal.ReadOnly = true;
            this.txtWinTotal.Size = new System.Drawing.Size(206, 26);
            this.txtWinTotal.TabIndex = 15;
            this.txtWinTotal.TabStop = false;
            this.txtWinTotal.Text = "0";
            this.txtWinTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(663, 609);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(206, 26);
            this.textBox8.TabIndex = 14;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Total Winnings";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpDownBetIncrement
            // 
            this.numUpDownBetIncrement.Location = new System.Drawing.Point(164, 680);
            this.numUpDownBetIncrement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUpDownBetIncrement.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numUpDownBetIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBetIncrement.Name = "numUpDownBetIncrement";
            this.numUpDownBetIncrement.Size = new System.Drawing.Size(57, 26);
            this.numUpDownBetIncrement.TabIndex = 17;
            this.toolTip1.SetToolTip(this.numUpDownBetIncrement, "Change betting increment to bet smaller or larger credits");
            this.numUpDownBetIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 685);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bet increment";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(9, 9);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 37);
            this.btnInfo.TabIndex = 23;
            this.btnInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInfo, "Help/About Sic Bo");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ckMute
            // 
            this.ckMute.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckMute.BackgroundImage = global::SicBo.Properties.Resources.SoundOn;
            this.ckMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ckMute.Location = new System.Drawing.Point(528, 675);
            this.ckMute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckMute.Name = "ckMute";
            this.ckMute.Size = new System.Drawing.Size(46, 45);
            this.ckMute.TabIndex = 24;
            this.toolTip1.SetToolTip(this.ckMute, "Mute/unmute dice rolling sound");
            this.ckMute.UseVisualStyleBackColor = true;
            this.ckMute.CheckedChanged += new System.EventHandler(this.ckMute_CheckedChanged);
            // 
            // rolledDice1
            // 
            this.rolledDice1.BackColor = System.Drawing.Color.Black;
            this.rolledDice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rolledDice1.Location = new System.Drawing.Point(354, 49);
            this.rolledDice1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rolledDice1.Name = "rolledDice1";
            this.rolledDice1.Size = new System.Drawing.Size(166, 72);
            this.rolledDice1.TabIndex = 22;
            // 
            // anyTriplets
            // 
            this.anyTriplets.BackColor = System.Drawing.SystemColors.Control;
            this.anyTriplets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anyTriplets.BackgroundImage")));
            this.anyTriplets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anyTriplets.Location = new System.Drawing.Point(428, 174);
            this.anyTriplets.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.anyTriplets.Name = "anyTriplets";
            this.anyTriplets.Pays = 0;
            this.anyTriplets.Size = new System.Drawing.Size(51, 95);
            this.anyTriplets.TabIndex = 19;
            // 
            // SicBoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SicBo.Properties.Resources.SicBoMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(904, 728);
            this.Controls.Add(this.ckMute);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.rolledDice1);
            this.Controls.Add(this.anyTriplets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownBetIncrement);
            this.Controls.Add(this.txtWinTotal);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtWinRoll);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SicBoTable";
            this.Text = "Sic Bo (by Ashish)";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBetIncrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtWinRoll;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtWinTotal;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.NumericUpDown numUpDownBetIncrement;
        private System.Windows.Forms.Label label1;
        private SicBoControls.AnyTriplets anyTriplets;
        private SicBoControls.RolledDice rolledDice1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox ckMute;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

