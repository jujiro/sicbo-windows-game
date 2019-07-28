namespace SicBoControls
{
    partial class RolledDice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.picBlackCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.SystemColors.Control;
            this.Dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dice1.Image = global::SicBoControls.Properties.Resources.Dice6;
            this.Dice1.Location = new System.Drawing.Point(11, 11);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(25, 25);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice1.TabIndex = 0;
            this.Dice1.TabStop = false;
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.SystemColors.Control;
            this.Dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dice2.Image = global::SicBoControls.Properties.Resources.Dice6;
            this.Dice2.Location = new System.Drawing.Point(42, 11);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(25, 25);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice2.TabIndex = 1;
            this.Dice2.TabStop = false;
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.SystemColors.Control;
            this.Dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dice3.Image = global::SicBoControls.Properties.Resources.Dice6;
            this.Dice3.Location = new System.Drawing.Point(73, 11);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(25, 25);
            this.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice3.TabIndex = 2;
            this.Dice3.TabStop = false;
            // 
            // picBlackCover
            // 
            this.picBlackCover.BackColor = System.Drawing.Color.Black;
            this.picBlackCover.Location = new System.Drawing.Point(0, 0);
            this.picBlackCover.Name = "picBlackCover";
            this.picBlackCover.Size = new System.Drawing.Size(114, 50);
            this.picBlackCover.TabIndex = 3;
            this.picBlackCover.TabStop = false;
            this.picBlackCover.Visible = false;
            // 
            // RolledDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.picBlackCover);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Name = "RolledDice";
            this.Size = new System.Drawing.Size(112, 48);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.PictureBox picBlackCover;
    }
}
