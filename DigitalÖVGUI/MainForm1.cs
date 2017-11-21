using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace DigitalÖVGUI
{
    public partial class MainForm : Form
    {
        Transport transport = new Transport();
        public MainForm()
        {
            InitializeComponent();
            acsStart.onEnterPressed += AcsStart_onEnterPressed;
            acsDestination.onEnterPressed += AcsDestination_onEnterPressed;
            acsDeparture.onEnterPressed += AcsDeparture_onEnterPressed;
            acsSearchStopLocation.onEnterPressed += AcsSearchStopLocation_onEnterPressed;
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            
            Connections connections = transport.GetConnections(acsStart.text, acsDestination.text);
            tableConnections.ColumnCount = 5;
            tableConnections.Columns[0].Name = "Abfahrtsstation";
            tableConnections.Columns[1].Name = "Reiseziel";
            tableConnections.Columns[2].Name = "Abfahrtszeit";
            tableConnections.Columns[3].Name = "Ankunftszeit";
            tableConnections.Columns[4].Name = "Dauer";
            foreach (Connection conn in connections.ConnectionList)
            {
                List<string> lsConn = new List<string>();
                
                lsConn.Add(conn.From.Station.Name);
                lsConn.Add(conn.To.Station.Name);
                lsConn.Add(convertTime(conn.From.Departure));
                lsConn.Add(convertTime(conn.To.Arrival));
                lsConn.Add(trimTime(conn.Duration));

                tableConnections.Rows.Add(lsConn.ToArray());
            }
        }
        private void btnSearchDepartures_Click(object sender, EventArgs e)
        {
            Station station = transport.GetStations(acsDeparture.text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);
            tableDepartures.ColumnCount = 2;
            tableDepartures.Columns[0].Name = "Linie";
            tableDepartures.Columns[1].Name = "Nach";
            foreach (StationBoard stat in departures.Entries)
            {
                List<string> lsStat = new List<string>();

                lsStat.Add(stat.Category + " " +stat.Number);
                lsStat.Add(stat.To);
                
                tableDepartures.Rows.Add(lsStat.ToArray());
            }
        }

        private void acsAny_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tabConnections_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchConnections;
        }

        private void tabDepartures_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchDepartures;
        }

        private void tabSearchStopLocation_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchStopLocation;
        }

        private void acsConnection_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchConnections;
        }

        private void acsDeparture_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchDepartures;
        }

        private void acsSearchStopLocation_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchStopLocation;
        }
        private void AcsSearchStopLocation_onEnterPressed(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchStopLocation;
        }

        private void AcsDeparture_onEnterPressed(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchDepartures;
        }

        private void AcsDestination_onEnterPressed(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchConnections;
        }

        private void AcsStart_onEnterPressed(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchConnections;
        }

        /// <summary>
        /// Konvertiert ein DateTime der PublicTransport API in eine leserliche Zeit.
        /// </summary>
        /// <param name="time"></param>
        /// <returns>HH:mm:ss</returns>
        string convertTime(string time)
        {
            DateTime.TryParse(time, out DateTime dateValue);
            return dateValue.TimeOfDay.ToString();
        }

        /// <summary>
        /// Schneidet den unnötigen Beginn der Duration ab.
        /// </summary>
        /// <param name="time"></param>
        /// <returns>HH:mm</returns>
        string trimTime (string time)
        {
            char[] charsToTrim = { '0', 'd', ':' };
            return time.TrimStart(charsToTrim);
        }
    }
}
