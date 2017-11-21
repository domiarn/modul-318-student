using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace DigitalÖVGUI
{
    public partial class autocompleteSearch : UserControl
    {
        Transport transport = new Transport();
        public event EventHandler onEnterPressed;

        public String text
        {
            get { return acsInput.Text; }
        }

        public autocompleteSearch()
        {
            InitializeComponent();
        }

        private void acsInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(acsInput.Text))
            {
                this.Height = acsInput.Height;
            }
            else
            {
                this.BringToFront();
                this.Height = 150;
                acsListbox.Items.Clear();
                Stations stations = transport.GetStations(acsInput.Text);
                foreach (Station sta in stations.StationList)
                    acsListbox.Items.Add(sta.Name);
            }
        }

        private void acsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                acsListbox.Focus();
                if (acsListbox.Items.Count > 0)
                    acsListbox.SelectedItem = acsListbox.Items[0];
            }
        }

        private void autocompleteSearch_Leave(object sender, EventArgs e)
        {
            this.Height = acsInput.Height;
        }

        private void autocompleteSearch_Load(object sender, EventArgs e)
        {
            this.Height = acsInput.Height;
        }

        private void acsListbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (acsListbox.SelectedItem != null)
                {
                    acsInput.Text = acsListbox.SelectedItem.ToString();
                    this.Height = acsInput.Height;
                }

                if (onEnterPressed != null)
                    onEnterPressed(this, null);
            }
        }
    }
}
