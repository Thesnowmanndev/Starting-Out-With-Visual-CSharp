using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagApplication
{
    public partial class FlagApplication : Form
    {
        public FlagApplication()
        {
            InitializeComponent();
        }

        private void finlandFlag_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void franceFlag_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void germanyFlag_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}
