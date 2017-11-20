namespace DigitalÖVGUI
{
    partial class MainForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuSearchConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartures = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNearStops = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchStopLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchConnections = new System.Windows.Forms.GroupBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.tableConnections = new System.Windows.Forms.DataGridView();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.rbArrival = new System.Windows.Forms.RadioButton();
            this.rbDeparture = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.gbDepartures = new System.Windows.Forms.GroupBox();
            this.btnSearchDepartures = new System.Windows.Forms.Button();
            this.tableDepartures = new System.Windows.Forms.DataGridView();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.gbNearStops = new System.Windows.Forms.GroupBox();
            this.mapNearStops = new System.Windows.Forms.WebBrowser();
            this.gbSearchStopLocation = new System.Windows.Forms.GroupBox();
            this.mapSearchStopLocation = new System.Windows.Forms.WebBrowser();
            this.btnSearchStopLocation = new System.Windows.Forms.Button();
            this.lbSearchStopLocation = new System.Windows.Forms.Label();
            this.acsDestination = new DigitalÖVGUI.autocompleteSearch();
            this.acsStart = new DigitalÖVGUI.autocompleteSearch();
            this.acsDeparture = new DigitalÖVGUI.autocompleteSearch();
            this.acsSearchStopLocation = new DigitalÖVGUI.autocompleteSearch();
            this.menu.SuspendLayout();
            this.gbSearchConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).BeginInit();
            this.gbDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDepartures)).BeginInit();
            this.gbNearStops.SuspendLayout();
            this.gbSearchStopLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchConnections,
            this.menuDepartures,
            this.menuNearStops,
            this.menuSearchStopLocation});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1520, 28);
            this.menu.TabIndex = 0;
            // 
            // menuSearchConnections
            // 
            this.menuSearchConnections.Name = "menuSearchConnections";
            this.menuSearchConnections.Size = new System.Drawing.Size(162, 24);
            this.menuSearchConnections.Text = "Verbindungen suchen";
            this.menuSearchConnections.Click += new System.EventHandler(this.menuSearchConnections_Click);
            // 
            // menuDepartures
            // 
            this.menuDepartures.Name = "menuDepartures";
            this.menuDepartures.Size = new System.Drawing.Size(107, 24);
            this.menuDepartures.Text = "Abfahrtstafel";
            this.menuDepartures.Click += new System.EventHandler(this.menuDepartures_Click);
            // 
            // menuNearStops
            // 
            this.menuNearStops.Name = "menuNearStops";
            this.menuNearStops.Size = new System.Drawing.Size(205, 24);
            this.menuNearStops.Text = "Haltestellen in meiner Nähe";
            this.menuNearStops.Click += new System.EventHandler(this.menuNearStops_Click);
            // 
            // menuSearchStopLocation
            // 
            this.menuSearchStopLocation.Name = "menuSearchStopLocation";
            this.menuSearchStopLocation.Size = new System.Drawing.Size(213, 24);
            this.menuSearchStopLocation.Text = "Haltestellen auf Karte suchen";
            this.menuSearchStopLocation.Click += new System.EventHandler(this.menuSearchStopLocation_Click);
            // 
            // gbSearchConnections
            // 
            this.gbSearchConnections.Controls.Add(this.lbStart);
            this.gbSearchConnections.Controls.Add(this.tableConnections);
            this.gbSearchConnections.Controls.Add(this.acsDestination);
            this.gbSearchConnections.Controls.Add(this.acsStart);
            this.gbSearchConnections.Controls.Add(this.btnSearchConnections);
            this.gbSearchConnections.Controls.Add(this.rbArrival);
            this.gbSearchConnections.Controls.Add(this.rbDeparture);
            this.gbSearchConnections.Controls.Add(this.txtTime);
            this.gbSearchConnections.Controls.Add(this.lbTime);
            this.gbSearchConnections.Controls.Add(this.datePicker);
            this.gbSearchConnections.Controls.Add(this.lbDate);
            this.gbSearchConnections.Controls.Add(this.lbDestination);
            this.gbSearchConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchConnections.Location = new System.Drawing.Point(0, 28);
            this.gbSearchConnections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchConnections.Name = "gbSearchConnections";
            this.gbSearchConnections.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchConnections.Size = new System.Drawing.Size(1520, 733);
            this.gbSearchConnections.TabIndex = 1;
            this.gbSearchConnections.TabStop = false;
            this.gbSearchConnections.Text = "Verbindungen suchen";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(16, 25);
            this.lbStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(82, 17);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "Abfahrtsort:";
            // 
            // tableConnections
            // 
            this.tableConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableConnections.Location = new System.Drawing.Point(4, 143);
            this.tableConnections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableConnections.Name = "tableConnections";
            this.tableConnections.Size = new System.Drawing.Size(1512, 586);
            this.tableConnections.TabIndex = 11;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(711, 21);
            this.btnSearchConnections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(187, 28);
            this.btnSearchConnections.TabIndex = 10;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(543, 69);
            this.rbArrival.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArrival.Name = "rbArrival";
            this.rbArrival.Size = new System.Drawing.Size(77, 21);
            this.rbArrival.TabIndex = 9;
            this.rbArrival.Text = "Ankunft";
            this.rbArrival.UseVisualStyleBackColor = true;
            // 
            // rbDeparture
            // 
            this.rbDeparture.AutoSize = true;
            this.rbDeparture.Checked = true;
            this.rbDeparture.Location = new System.Drawing.Point(456, 69);
            this.rbDeparture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDeparture.Name = "rbDeparture";
            this.rbDeparture.Size = new System.Drawing.Size(75, 21);
            this.rbDeparture.TabIndex = 8;
            this.rbDeparture.TabStop = true;
            this.rbDeparture.Text = "Abfahrt";
            this.rbDeparture.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(401, 69);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(45, 22);
            this.txtTime.TabIndex = 7;
            this.txtTime.Text = "00:00";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(339, 71);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 17);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Zeit:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(401, 22);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(265, 22);
            this.datePicker.TabIndex = 5;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(339, 25);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(53, 17);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Datum:";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Location = new System.Drawing.Point(16, 71);
            this.lbDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(69, 17);
            this.lbDestination.TabIndex = 1;
            this.lbDestination.Text = "Reiseziel:";
            // 
            // gbDepartures
            // 
            this.gbDepartures.Controls.Add(this.btnSearchDepartures);
            this.gbDepartures.Controls.Add(this.tableDepartures);
            this.gbDepartures.Controls.Add(this.txtTime2);
            this.gbDepartures.Controls.Add(this.lbTime2);
            this.gbDepartures.Controls.Add(this.datePicker2);
            this.gbDepartures.Controls.Add(this.lbDate2);
            this.gbDepartures.Controls.Add(this.acsDeparture);
            this.gbDepartures.Controls.Add(this.lbDeparture);
            this.gbDepartures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDepartures.Location = new System.Drawing.Point(0, 0);
            this.gbDepartures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepartures.Name = "gbDepartures";
            this.gbDepartures.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepartures.Size = new System.Drawing.Size(1520, 761);
            this.gbDepartures.TabIndex = 2;
            this.gbDepartures.TabStop = false;
            this.gbDepartures.Text = "Abfahrtstafel";
            this.gbDepartures.Visible = false;
            // 
            // btnSearchDepartures
            // 
            this.btnSearchDepartures.Location = new System.Drawing.Point(797, 21);
            this.btnSearchDepartures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchDepartures.Name = "btnSearchDepartures";
            this.btnSearchDepartures.Size = new System.Drawing.Size(100, 28);
            this.btnSearchDepartures.TabIndex = 7;
            this.btnSearchDepartures.Text = "Abfahrten suchen";
            this.btnSearchDepartures.UseVisualStyleBackColor = true;
            // 
            // tableDepartures
            // 
            this.tableDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDepartures.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableDepartures.Location = new System.Drawing.Point(4, 121);
            this.tableDepartures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableDepartures.Name = "tableDepartures";
            this.tableDepartures.Size = new System.Drawing.Size(1512, 636);
            this.tableDepartures.TabIndex = 6;
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(697, 21);
            this.txtTime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(44, 22);
            this.txtTime2.TabIndex = 5;
            this.txtTime2.Text = "00:00";
            // 
            // lbTime2
            // 
            this.lbTime2.AutoSize = true;
            this.lbTime2.Location = new System.Drawing.Point(656, 25);
            this.lbTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime2.Name = "lbTime2";
            this.lbTime2.Size = new System.Drawing.Size(36, 17);
            this.lbTime2.TabIndex = 4;
            this.lbTime2.Text = "Zeit:";
            // 
            // datePicker2
            // 
            this.datePicker2.Location = new System.Drawing.Point(359, 21);
            this.datePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(265, 22);
            this.datePicker2.TabIndex = 3;
            // 
            // lbDate2
            // 
            this.lbDate2.AutoSize = true;
            this.lbDate2.Location = new System.Drawing.Point(300, 25);
            this.lbDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(53, 17);
            this.lbDate2.TabIndex = 2;
            this.lbDate2.Text = "Datum:";
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Location = new System.Drawing.Point(16, 25);
            this.lbDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(82, 17);
            this.lbDeparture.TabIndex = 0;
            this.lbDeparture.Text = "Abfahrtsort:";
            // 
            // gbNearStops
            // 
            this.gbNearStops.Controls.Add(this.mapNearStops);
            this.gbNearStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNearStops.Location = new System.Drawing.Point(0, 0);
            this.gbNearStops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNearStops.Name = "gbNearStops";
            this.gbNearStops.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNearStops.Size = new System.Drawing.Size(1520, 761);
            this.gbNearStops.TabIndex = 3;
            this.gbNearStops.TabStop = false;
            this.gbNearStops.Text = "Haltestellen in meiner Nähe";
            this.gbNearStops.Visible = false;
            // 
            // mapNearStops
            // 
            this.mapNearStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapNearStops.Location = new System.Drawing.Point(4, 19);
            this.mapNearStops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapNearStops.MinimumSize = new System.Drawing.Size(27, 25);
            this.mapNearStops.Name = "mapNearStops";
            this.mapNearStops.Size = new System.Drawing.Size(1512, 738);
            this.mapNearStops.TabIndex = 0;
            this.mapNearStops.Url = new System.Uri("https://www.google.ch/maps/", System.UriKind.Absolute);
            // 
            // gbSearchStopLocation
            // 
            this.gbSearchStopLocation.Controls.Add(this.mapSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.acsSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.btnSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.lbSearchStopLocation);
            this.gbSearchStopLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchStopLocation.Location = new System.Drawing.Point(0, 0);
            this.gbSearchStopLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchStopLocation.Name = "gbSearchStopLocation";
            this.gbSearchStopLocation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSearchStopLocation.Size = new System.Drawing.Size(1520, 761);
            this.gbSearchStopLocation.TabIndex = 4;
            this.gbSearchStopLocation.TabStop = false;
            this.gbSearchStopLocation.Text = "Haltestelle auf Karte suchen";
            this.gbSearchStopLocation.Visible = false;
            // 
            // mapSearchStopLocation
            // 
            this.mapSearchStopLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mapSearchStopLocation.Location = new System.Drawing.Point(4, 121);
            this.mapSearchStopLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapSearchStopLocation.MinimumSize = new System.Drawing.Size(27, 25);
            this.mapSearchStopLocation.Name = "mapSearchStopLocation";
            this.mapSearchStopLocation.Size = new System.Drawing.Size(1512, 636);
            this.mapSearchStopLocation.TabIndex = 0;
            // 
            // btnSearchStopLocation
            // 
            this.btnSearchStopLocation.Location = new System.Drawing.Point(359, 21);
            this.btnSearchStopLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchStopLocation.Name = "btnSearchStopLocation";
            this.btnSearchStopLocation.Size = new System.Drawing.Size(100, 28);
            this.btnSearchStopLocation.TabIndex = 3;
            this.btnSearchStopLocation.Text = "Suchen";
            this.btnSearchStopLocation.UseVisualStyleBackColor = true;
            // 
            // lbSearchStopLocation
            // 
            this.lbSearchStopLocation.AutoSize = true;
            this.lbSearchStopLocation.Location = new System.Drawing.Point(16, 25);
            this.lbSearchStopLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearchStopLocation.Name = "lbSearchStopLocation";
            this.lbSearchStopLocation.Size = new System.Drawing.Size(143, 17);
            this.lbSearchStopLocation.TabIndex = 1;
            this.lbSearchStopLocation.Text = "Gesuchte Haltestelle:";
            // 
            // acsDestination
            // 
            this.acsDestination.Location = new System.Drawing.Point(105, 69);
            this.acsDestination.Margin = new System.Windows.Forms.Padding(5);
            this.acsDestination.Name = "acsDestination";
            this.acsDestination.Size = new System.Drawing.Size(171, 170);
            this.acsDestination.TabIndex = 3;
            // 
            // acsStart
            // 
            this.acsStart.Location = new System.Drawing.Point(105, 22);
            this.acsStart.Margin = new System.Windows.Forms.Padding(5);
            this.acsStart.Name = "acsStart";
            this.acsStart.Size = new System.Drawing.Size(171, 170);
            this.acsStart.TabIndex = 2;
            // 
            // acsDeparture
            // 
            this.acsDeparture.Location = new System.Drawing.Point(100, 21);
            this.acsDeparture.Margin = new System.Windows.Forms.Padding(5);
            this.acsDeparture.Name = "acsDeparture";
            this.acsDeparture.Size = new System.Drawing.Size(171, 140);
            this.acsDeparture.TabIndex = 1;
            // 
            // acsSearchStopLocation
            // 
            this.acsSearchStopLocation.Location = new System.Drawing.Point(160, 22);
            this.acsSearchStopLocation.Margin = new System.Windows.Forms.Padding(5);
            this.acsSearchStopLocation.Name = "acsSearchStopLocation";
            this.acsSearchStopLocation.Size = new System.Drawing.Size(171, 140);
            this.acsSearchStopLocation.TabIndex = 4;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 761);
            this.Controls.Add(this.gbSearchConnections);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.gbDepartures);
            this.Controls.Add(this.gbSearchStopLocation);
            this.Controls.Add(this.gbNearStops);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1535, 798);
            this.Name = "MainForm1";
            this.Text = "Digital ÖV";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gbSearchConnections.ResumeLayout(false);
            this.gbSearchConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).EndInit();
            this.gbDepartures.ResumeLayout(false);
            this.gbDepartures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDepartures)).EndInit();
            this.gbNearStops.ResumeLayout(false);
            this.gbSearchStopLocation.ResumeLayout(false);
            this.gbSearchStopLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuSearchConnections;
        private System.Windows.Forms.ToolStripMenuItem menuDepartures;
        private System.Windows.Forms.ToolStripMenuItem menuNearStops;
        private System.Windows.Forms.ToolStripMenuItem menuSearchStopLocation;
        private System.Windows.Forms.GroupBox gbSearchConnections;
        private System.Windows.Forms.GroupBox gbDepartures;
        private System.Windows.Forms.GroupBox gbNearStops;
        private System.Windows.Forms.GroupBox gbSearchStopLocation;
        private System.Windows.Forms.DataGridView tableConnections;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.RadioButton rbDeparture;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lbDate;
        private autocompleteSearch acsDestination;
        private autocompleteSearch acsStart;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbDate2;
        private autocompleteSearch acsDeparture;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Button btnSearchDepartures;
        private System.Windows.Forms.DataGridView tableDepartures;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.WebBrowser mapNearStops;
        private autocompleteSearch acsSearchStopLocation;
        private System.Windows.Forms.Button btnSearchStopLocation;
        private System.Windows.Forms.Label lbSearchStopLocation;
        private System.Windows.Forms.WebBrowser mapSearchStopLocation;
    }
}

