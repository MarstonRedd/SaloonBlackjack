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
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlayS_Click(object sender, EventArgs e)
        {
            MainForm form = this.FindForm() as MainForm;
            if (form != null)
            {
                form.LoadUserControl(new SingleplayerControl());
            }
        }

    }
}
