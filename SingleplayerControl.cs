using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaloonBlackjack
{
    public partial class SingleplayerControl : UserControl
    {
        BlackjackHelper blackjackHelper = new BlackjackHelper(); //Create a new instance of the BlackjackHelper class to handle card generation
        string[][] deck; //The deck of cards used in the game

        string CardName, dealerCard2;
        Image cardImage;

        int rankNo = 0, suitNo = 0, valueNo = 0; //Used to call the cards
        int track = 0; //Used to track the number of times the dealer has dealt a card

        int DealerCard1 = 0, DealerCard2 = 0, PlayerCard1 = 0, PlayerCard2 = 0;
        int playerScore = 0, dealerScore = 0, dealerDealt = 0, playerDealt = 0, extraPlayerCards = 0, extraDealerCards = 0;

        bool PlayerStand = false, DealerStand = false, playerAce = false, dealerAce = false, playerAceSubtract = false, dealerAceSubtract = false;


        public SingleplayerControl()
        {
            InitializeComponent();
            this.Focus();
            
            deck = blackjackHelper.CreateDeck(); //Create a new deck of cards using the BlackjackHelper class
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Return to the main menu when Escape is pressed
        {
            if (keyData == Keys.Escape)
            {
                var answer = MessageBox.Show("Are you sure you want to return to the Menu?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    MainForm form = this.FindForm() as MainForm;
                    if (form != null)
                    {
                        form.LoadUserControl(new MainMenuControl());
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonBegin_Click(object sender, EventArgs e) //Begin the round
        {
            buttonBegin.Visible = false;
            pbxNext.Visible = true;
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            switch (track)
            {
                case 0: //dealer card 1
                    rankNo = blackjackHelper.GenerateRankNo();
                    suitNo = blackjackHelper.GenerateSuiteNo();
                    valueNo = blackjackHelper.ReturnValue(rankNo, dealerScore);
                    if ((rankNo == 0) && (!dealerAce) && (valueNo == 11)) //Check if the dealer has been dealt an Ace and hasn't already been dealt one
                        dealerAce = true; //Check if the dealer has been dealt an Ace
                    outputLabel.Text = ($"The dealer was dealt the {deck[suitNo][rankNo]}, with a value of {valueNo}.");

                    pbxDealerCard1.Visible = true;
                    pbxDealerCard1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(deck[suitNo][rankNo]);


                    dealerScore += valueNo;
                    dealerLabel.Text = "Dealer Total: " + dealerScore;
                    track++;
                    break;

                case 1: //dealer card 2
                    rankNo = blackjackHelper.GenerateRankNo();
                    suitNo = blackjackHelper.GenerateSuiteNo();
                    valueNo = blackjackHelper.ReturnValue(rankNo, dealerScore);
                    if ((rankNo == 0) && (!dealerAce) && (valueNo == 11)) //Check if the dealer has been dealt an Ace and hasn't already been dealt one
                        dealerAce = true; //Check if the dealer has been dealt an Ace
                    outputLabel.Text = ($"The dealer was dealt their second card.");

                    pbxDealerCard2.Visible = true;
                    pbxDealerCard2.BackgroundImage = (Image)Properties.Resources.CardDown;
                    dealerCard2 = deck[suitNo][rankNo];

                    dealerScore += valueNo;
                    dealerLabel.Text = "Dealer Total: ??";
                    track++;
                    break;

                case 2: //player card 1
                    rankNo = blackjackHelper.GenerateRankNo();
                    suitNo = blackjackHelper.GenerateSuiteNo();
                    valueNo = blackjackHelper.ReturnValue(rankNo, playerScore);
                    if ((rankNo == 0) && (!playerAce) && (valueNo == 11)) //Check if the player has been dealt an Ace and hasn't already been dealt one
                        playerAce = true; //Check if the player has been dealt an Ace
                    outputLabel.Text = ($"Your first card dealt was the {deck[suitNo][rankNo]}, with a value of {valueNo}.");

                    pbxPlayerCard1.Visible = true;
                    pbxPlayerCard1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(deck[suitNo][rankNo]);

                    playerScore += valueNo;
                    playerLabel.Text = "Player Total: " + playerScore;
                    track++;
                    break;
                case 3: //player card 2
                    rankNo = blackjackHelper.GenerateRankNo();
                    suitNo = blackjackHelper.GenerateSuiteNo();
                    valueNo = blackjackHelper.ReturnValue(rankNo, playerScore);
                    if ((rankNo == 0) && (!playerAce) && (valueNo == 11)) //Check if the player has been dealt an Ace and hasn't already been dealt one
                        playerAce = true; //Check if the player has been dealt an Ace
                    outputLabel.Text = ($"Your second card dealt was the {deck[suitNo][rankNo]}, with a value of {valueNo}.");

                    pbxPlayerCard2.Visible = true;
                    pbxPlayerCard2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(deck[suitNo][rankNo]);

                    playerScore += valueNo;
                    playerLabel.Text = "Player Total: " + playerScore;
                    track++;
                    pbxNext.Visible = false;
                    buttonHit.Visible = true;
                    buttonStand.Visible = true;
                    break;
                case 4:
                    if (dealerScore > playerScore && dealerScore <= 21)
                    {
                        MessageBox.Show("The dealer wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetGame();
                    }
                    else if (dealerScore < playerScore || dealerScore > 21)
                    {
                        MessageBox.Show("You win!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetGame();
                    }
                    else
                    {
                        MessageBox.Show("It's a tie!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetGame();
                    }
                    break;
            }
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            rankNo = blackjackHelper.GenerateRankNo();
            suitNo = blackjackHelper.GenerateSuiteNo();
            valueNo = blackjackHelper.ReturnValue(rankNo, playerScore);
            outputLabel.Text = ($"Your next card dealt was the {deck[suitNo][rankNo]}, with a value of {valueNo}.");

            CreatePlayerCardImage(deck[suitNo][rankNo]);

            playerScore += valueNo;
            playerLabel.Text = "Player Total: " + playerScore;

            if (playerScore > 21)
            {
                if (playerAce && !playerAceSubtract)
                {
                    playerScore -= 10; // If the player has an Ace, reduce the score by 10 to avoid busting
                    playerLabel.Text = "Player Total: " + playerScore;
                    playerAceSubtract = true;
                    if (playerScore <= 21)
                    {
                        outputLabel.Text += " (Ace counted as 1 instead of 11)";
                    }
                    else
                    {
                        dealerLabel.Text = "Dealer Total: " + dealerScore;
                        MessageBox.Show("You went bust! The dealer wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ResetGame();
                    }
                }
                else
                {
                    dealerLabel.Text = "Dealer Total: " + dealerScore;
                    MessageBox.Show("You went bust! The dealer wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ResetGame();
                }
            }
        }


        private void buttonStand_Click(object sender, EventArgs e)
        {
            buttonHit.Visible = false;
            buttonStand.Visible = false;
            pbxNext2.Visible = true;
            PlayerStand = true;

            outputLabel.Text = "You have chosen to stand. The dealer will now play.";
            dealerLabel.Text = "Dealer Total: " + dealerScore;

            pbxDealerCard2.Visible = true;
            cardImage = (Image)Properties.Resources.ResourceManager.GetObject(dealerCard2);
            pbxDealerCard2.BackgroundImage = cardImage;

            if (dealerScore >= 17)
                DealerStand = true;
        }

        private void pbxNext2_Click(object sender, EventArgs e)
        {
            if (DealerStand)
            {
                outputLabel.Text = "The dealer has chosen to stand.";
                pbxNext2.Visible = false;
                pbxNext.Visible = true;
            }
            else
            {
                if (dealerScore < 17)
                {
                    rankNo = blackjackHelper.GenerateRankNo();
                    suitNo = blackjackHelper.GenerateSuiteNo();
                    valueNo = blackjackHelper.ReturnValue(rankNo, dealerScore);
                    outputLabel.Text = ($"The dealer was dealt the {deck[suitNo][rankNo]}, with a value of {valueNo}");
                    CreateDealerCardImage(deck[suitNo][rankNo]);
                    dealerScore += valueNo;
                    dealerLabel.Text = "Dealer Total: " + dealerScore;

                    if (dealerScore > 21)
                    {
                        if (dealerAce && !dealerAceSubtract)
                        {
                            dealerScore -= 10; // If the player has an Ace, reduce the score by 10 to avoid busting
                            dealerLabel.Text = "Player Total: " + dealerScore;
                            dealerAceSubtract = true;
                            if (dealerScore <= 21)
                            {
                                outputLabel.Text += " (Ace counted as 1 instead of 11)";
                            }
                            else
                            {
                                MessageBox.Show("The dealer went bust! You win!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ResetGame();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The dealer went bust! You win!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ResetGame();
                        }
                    }
                }
                else
                {
                    outputLabel.Text = "The dealer has chosen to stand.";
                    DealerStand = true;
                    pbxNext2.Visible = false;
                    pbxNext.Visible = true;
                }
            }
            
        }

        public void ResetGame()
        {
            dealerLabel.Text = "Dealer Total: 0";
            playerLabel.Text = "Player Total: 0";
            outputLabel.Text = "Console Output.";
            buttonHit.Visible = false;
            buttonStand.Visible = false;
            pbxNext.Visible = false;
            pbxNext2.Visible = false;
            buttonBegin.Visible = true;
            pbxPlayerCard1.Visible = false;
            pbxPlayerCard2.Visible = false;
            pbxDealerCard1.Visible = false;
            pbxDealerCard2.Visible = false;
            DeleteExtraPictureboxes();

            DealerCard1 = 0;
            DealerCard2 = 0;
            PlayerCard1 = 0;
            PlayerCard2 = 0;
            PlayerStand = false;
            DealerStand = false;
            playerAce = false;
            dealerAce = false;
            playerAceSubtract = false;
            dealerAceSubtract = false;
            playerScore = 0;
            dealerScore = 0;
            dealerDealt = 0;
            playerDealt = 0;
            track = 0;
            extraPlayerCards = 0;
            extraDealerCards = 0;
        }

        public PictureBox CreateDealerCardImage(string cardName)
        {
            PictureBox pbx = new PictureBox();
            pbx.Name = $"dealerCard{extraDealerCards}";
            pbx.Width = 72;
            pbx.Height = 96;
            pbx.BackgroundImageLayout = ImageLayout.Stretch;
            pbx.Left = 520 + (extraDealerCards * 20);
            extraDealerCards++;
            pbx.Top = 32;

            Image cardImage = (Image)Properties.Resources.ResourceManager.GetObject(cardName);
            pbx.BackgroundImage = cardImage;
            this.Controls.Add(pbx);
            pbx.BringToFront();

            return pbx;
        }

        public PictureBox CreatePlayerCardImage(string cardName)
        {
            PictureBox pbx = new PictureBox();
            pbx.Name = $"playerCard{extraPlayerCards}";
            pbx.Width = 64;
            pbx.Height = 80;
            pbx.BackgroundImageLayout = ImageLayout.Stretch;
            pbx.Left = 496 + (extraPlayerCards * 20);
            extraPlayerCards++;
            pbx.Top = 424;

            Image cardImage = (Image)Properties.Resources.ResourceManager.GetObject(cardName);
            pbx.BackgroundImage = cardImage;
            this.Controls.Add(pbx);
            pbx.BringToFront();

            return pbx;
        }

        public void DeleteExtraPictureboxes()
        {
            List<Control> toDelete = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox &&
                   (ctrl.Name.StartsWith("dealerCard") || ctrl.Name.StartsWith("playerCard")))
                {
                    toDelete.Add(ctrl);
                }
            }

            foreach (Control ctrl in toDelete)
            {
                this.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }
    }
}