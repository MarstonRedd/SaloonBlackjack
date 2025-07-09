namespace SaloonBlackjack
{
    partial class SingleplayerControl
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.pbxNext2 = new System.Windows.Forms.PictureBox();
            this.pbxDealerCard1 = new System.Windows.Forms.PictureBox();
            this.pbxDealerCard2 = new System.Windows.Forms.PictureBox();
            this.pbxPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.pbxPlayerCard2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(40, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(131, 21);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Console Output.";
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(856, 480);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(96, 47);
            this.buttonBegin.TabIndex = 1;
            this.buttonBegin.Text = "Begin Round";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // pbxNext
            // 
            this.pbxNext.BackColor = System.Drawing.Color.Transparent;
            this.pbxNext.BackgroundImage = global::SaloonBlackjack.Properties.Resources.GreenArrowRight;
            this.pbxNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxNext.Location = new System.Drawing.Point(864, 456);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(80, 90);
            this.pbxNext.TabIndex = 2;
            this.pbxNext.TabStop = false;
            this.pbxNext.Visible = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.Location = new System.Drawing.Point(648, 112);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(127, 21);
            this.dealerLabel.TabIndex = 3;
            this.dealerLabel.Text = "Dealer Total: 0";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(200, 352);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(126, 21);
            this.playerLabel.TabIndex = 4;
            this.playerLabel.Text = "Player Total: 0";
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(224, 416);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(80, 24);
            this.buttonStand.TabIndex = 5;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Visible = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(224, 384);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(80, 24);
            this.buttonHit.TabIndex = 6;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Visible = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // pbxNext2
            // 
            this.pbxNext2.BackColor = System.Drawing.Color.Transparent;
            this.pbxNext2.BackgroundImage = global::SaloonBlackjack.Properties.Resources.GreenArrowRight;
            this.pbxNext2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxNext2.Location = new System.Drawing.Point(864, 456);
            this.pbxNext2.Name = "pbxNext2";
            this.pbxNext2.Size = new System.Drawing.Size(80, 90);
            this.pbxNext2.TabIndex = 7;
            this.pbxNext2.TabStop = false;
            this.pbxNext2.Visible = false;
            this.pbxNext2.Click += new System.EventHandler(this.pbxNext2_Click);
            // 
            // pbxDealerCard1
            // 
            this.pbxDealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.pbxDealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDealerCard1.Location = new System.Drawing.Point(360, 32);
            this.pbxDealerCard1.Name = "pbxDealerCard1";
            this.pbxDealerCard1.Size = new System.Drawing.Size(72, 96);
            this.pbxDealerCard1.TabIndex = 8;
            this.pbxDealerCard1.TabStop = false;
            this.pbxDealerCard1.Visible = false;
            // 
            // pbxDealerCard2
            // 
            this.pbxDealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.pbxDealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDealerCard2.Location = new System.Drawing.Point(440, 32);
            this.pbxDealerCard2.Name = "pbxDealerCard2";
            this.pbxDealerCard2.Size = new System.Drawing.Size(72, 96);
            this.pbxDealerCard2.TabIndex = 9;
            this.pbxDealerCard2.TabStop = false;
            this.pbxDealerCard2.Visible = false;
            // 
            // pbxPlayerCard1
            // 
            this.pbxPlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.pbxPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPlayerCard1.Location = new System.Drawing.Point(352, 424);
            this.pbxPlayerCard1.Name = "pbxPlayerCard1";
            this.pbxPlayerCard1.Size = new System.Drawing.Size(64, 80);
            this.pbxPlayerCard1.TabIndex = 11;
            this.pbxPlayerCard1.TabStop = false;
            this.pbxPlayerCard1.Visible = false;
            // 
            // pbxPlayerCard2
            // 
            this.pbxPlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.pbxPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPlayerCard2.Location = new System.Drawing.Point(424, 424);
            this.pbxPlayerCard2.Name = "pbxPlayerCard2";
            this.pbxPlayerCard2.Size = new System.Drawing.Size(64, 80);
            this.pbxPlayerCard2.TabIndex = 12;
            this.pbxPlayerCard2.TabStop = false;
            this.pbxPlayerCard2.Visible = false;
            // 
            // SingleplayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaloonBlackjack.Properties.Resources.BlackjackGameTable;
            this.Controls.Add(this.pbxPlayerCard2);
            this.Controls.Add(this.pbxPlayerCard1);
            this.Controls.Add(this.pbxDealerCard2);
            this.Controls.Add(this.pbxDealerCard1);
            this.Controls.Add(this.pbxNext2);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.outputLabel);
            this.Name = "SingleplayerControl";
            this.Size = new System.Drawing.Size(960, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.PictureBox pbxNext2;
        private System.Windows.Forms.PictureBox pbxDealerCard1;
        private System.Windows.Forms.PictureBox pbxDealerCard2;
        private System.Windows.Forms.PictureBox pbxPlayerCard1;
        private System.Windows.Forms.PictureBox pbxPlayerCard2;
    }
}
