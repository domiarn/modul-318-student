using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalÖVGUI
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void menuSearchConnections_Click(object sender, EventArgs e)
        {
            gbSearchConnections.Visible = true;
            gbDepartures.Visible = false;
            gbNearStops.Visible = false;
            gbSearchStopLocation.Visible = false;
        }

        private void menuDepartures_Click(object sender, EventArgs e)
        {
            gbSearchConnections.Visible = false;
            gbDepartures.Visible = true;
            gbNearStops.Visible = false;
            gbSearchStopLocation.Visible = false;
        }

        private void menuNearStops_Click(object sender, EventArgs e)
        {
            gbSearchConnections.Visible = false;
            gbDepartures.Visible = false;
            gbNearStops.Visible = true;
            gbSearchStopLocation.Visible = false;
        }

        private void menuSearchStopLocation_Click(object sender, EventArgs e)
        {
            gbSearchConnections.Visible = false;
            gbDepartures.Visible = false;
            gbNearStops.Visible = false;
            gbSearchStopLocation.Visible = true;
        }
    }
}
