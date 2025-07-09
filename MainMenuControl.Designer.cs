namespace SaloonBlackjack
{
    partial class MainMenuControl
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
            this.buttonPlayS = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlayS
            // 
            this.buttonPlayS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayS.Location = new System.Drawing.Point(352, 232);
            this.buttonPlayS.Name = "buttonPlayS";
            this.buttonPlayS.Size = new System.Drawing.Size(240, 63);
            this.buttonPlayS.TabIndex = 0;
            this.buttonPlayS.Text = "Singleplayer";
            this.buttonPlayS.UseVisualStyleBackColor = true;
            this.buttonPlayS.Click += new System.EventHandler(this.buttonPlayS_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(16, 488);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 39);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaloonBlackjack.Properties.Resources.BlackjackGameIntro;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayS);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(960, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayS;
        private System.Windows.Forms.Button buttonExit;
    }
}
