using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalÖVGUI
{
    public partial class autocompleteSearch : UserControl
    {
        public autocompleteSearch()
        {
            InitializeComponent();
        }

        private void acsInput_TextChanged(object sender, EventArgs e)
        {
            acsListbox.Visible = true;
            this.BringToFront();
            if (String.IsNullOrWhiteSpace(acsInput.Text))
                acsListbox.Visible = false;
        }

        private void acsInput_Leave(object sender, EventArgs e)
        {
            acsListbox.Visible = false;
            this.SendToBack();
        }
    }
}
