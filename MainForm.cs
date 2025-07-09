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
    public partial class MainForm : Form
    {
        private Panel mainPanel = new Panel(); // Panel to hold the UserControls

        public MainForm()
        {
            InitializeComponent();

            mainPanel.Dock = DockStyle.Fill;    // Makes the panel fill the form
            this.Controls.Add(mainPanel);
            LoadUserControl(new MainMenuControl()); // Load the Main Menu Control

        }

        public void LoadUserControl(UserControl uc) // Method to load a UserControl into the main panel
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
            uc.Focus();
        }

    }
}
