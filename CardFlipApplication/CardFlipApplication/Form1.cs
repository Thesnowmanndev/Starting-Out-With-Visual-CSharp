using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlipApplication
{
    public partial class CardFlipApplication : Form
    {
        public CardFlipApplication()
        {
            InitializeComponent();
        }

        private void faceDownButton_Click(object sender, EventArgs e)
        {
            faceUpCard.Visible = false;
            faceDownCard.Visible = true;
        }

        private void faceUpButton_Click(object sender, EventArgs e)
        {
            faceDownCard.Visible = false;
            faceUpCard.Visible = true;
        }
    }
}
