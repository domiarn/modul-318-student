namespace DigitalÖVGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbSearchStopLocation = new System.Windows.Forms.Label();
            this.btnSearchStopLocation = new System.Windows.Forms.Button();
            this.mapSearchStopLocation = new System.Windows.Forms.WebBrowser();
            this.gbSearchStopLocation = new System.Windows.Forms.GroupBox();
            this.acsSearchStopLocation = new DigitalÖVGUI.autocompleteSearch();
            this.mapNearStops = new System.Windows.Forms.WebBrowser();
            this.gbNearStops = new System.Windows.Forms.GroupBox();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.tableDepartures = new System.Windows.Forms.DataGridView();
            this.btnSearchDepartures = new System.Windows.Forms.Button();
            this.gbDepartures = new System.Windows.Forms.GroupBox();
            this.acsDeparture = new DigitalÖVGUI.autocompleteSearch();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.rbDeparture = new System.Windows.Forms.RadioButton();
            this.rbArrival = new System.Windows.Forms.RadioButton();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.tableConnections = new System.Windows.Forms.DataGridView();
            this.lbStart = new System.Windows.Forms.Label();
            this.gbSearchConnections = new System.Windows.Forms.GroupBox();
            this.acsDestination = new DigitalÖVGUI.autocompleteSearch();
            this.acsStart = new DigitalÖVGUI.autocompleteSearch();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabSearchConnections = new System.Windows.Forms.TabPage();
            this.tabDepartures = new System.Windows.Forms.TabPage();
            this.tabNearStops = new System.Windows.Forms.TabPage();
            this.tabSearchStopLocation = new System.Windows.Forms.TabPage();
            this.gbSearchStopLocation.SuspendLayout();
            this.gbNearStops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDepartures)).BeginInit();
            this.gbDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).BeginInit();
            this.gbSearchConnections.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabSearchConnections.SuspendLayout();
            this.tabDepartures.SuspendLayout();
            this.tabNearStops.SuspendLayout();
            this.tabSearchStopLocation.SuspendLayout();
            this.SuspendLayout();
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
            // btnSearchStopLocation
            // 
            this.btnSearchStopLocation.Location = new System.Drawing.Point(359, 23);
            this.btnSearchStopLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStopLocation.Name = "btnSearchStopLocation";
            this.btnSearchStopLocation.Size = new System.Drawing.Size(100, 28);
            this.btnSearchStopLocation.TabIndex = 2;
            this.btnSearchStopLocation.Text = "Suchen";
            this.btnSearchStopLocation.UseVisualStyleBackColor = true;
            // 
            // mapSearchStopLocation
            // 
            this.mapSearchStopLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mapSearchStopLocation.Location = new System.Drawing.Point(4, 86);
            this.mapSearchStopLocation.Margin = new System.Windows.Forms.Padding(4);
            this.mapSearchStopLocation.MinimumSize = new System.Drawing.Size(27, 25);
            this.mapSearchStopLocation.Name = "mapSearchStopLocation";
            this.mapSearchStopLocation.Size = new System.Drawing.Size(1498, 636);
            this.mapSearchStopLocation.TabIndex = 0;
            this.mapSearchStopLocation.Url = new System.Uri("https://www.bing.com/maps", System.UriKind.Absolute);
            // 
            // gbSearchStopLocation
            // 
            this.gbSearchStopLocation.Controls.Add(this.acsSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.mapSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.btnSearchStopLocation);
            this.gbSearchStopLocation.Controls.Add(this.lbSearchStopLocation);
            this.gbSearchStopLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchStopLocation.Location = new System.Drawing.Point(3, 3);
            this.gbSearchStopLocation.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchStopLocation.Name = "gbSearchStopLocation";
            this.gbSearchStopLocation.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchStopLocation.Size = new System.Drawing.Size(1506, 726);
            this.gbSearchStopLocation.TabIndex = 4;
            this.gbSearchStopLocation.TabStop = false;
            this.gbSearchStopLocation.Text = "Haltestelle auf Karte suchen";
            // 
            // acsSearchStopLocation
            // 
            this.acsSearchStopLocation.Location = new System.Drawing.Point(161, 25);
            this.acsSearchStopLocation.Margin = new System.Windows.Forms.Padding(4);
            this.acsSearchStopLocation.Name = "acsSearchStopLocation";
            this.acsSearchStopLocation.Size = new System.Drawing.Size(190, 22);
            this.acsSearchStopLocation.TabIndex = 1;
            this.acsSearchStopLocation.Enter += new System.EventHandler(this.acsAny_Enter);
            this.acsSearchStopLocation.Leave += new System.EventHandler(this.acsSearchStopLocation_Leave);
            // 
            // mapNearStops
            // 
            this.mapNearStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapNearStops.Location = new System.Drawing.Point(4, 19);
            this.mapNearStops.Margin = new System.Windows.Forms.Padding(4);
            this.mapNearStops.MinimumSize = new System.Drawing.Size(27, 25);
            this.mapNearStops.Name = "mapNearStops";
            this.mapNearStops.Size = new System.Drawing.Size(1498, 703);
            this.mapNearStops.TabIndex = 1;
            this.mapNearStops.Url = new System.Uri("https://www.bing.com/maps", System.UriKind.Absolute);
            // 
            // gbNearStops
            // 
            this.gbNearStops.Controls.Add(this.mapNearStops);
            this.gbNearStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNearStops.Location = new System.Drawing.Point(3, 3);
            this.gbNearStops.Margin = new System.Windows.Forms.Padding(4);
            this.gbNearStops.Name = "gbNearStops";
            this.gbNearStops.Padding = new System.Windows.Forms.Padding(4);
            this.gbNearStops.Size = new System.Drawing.Size(1506, 726);
            this.gbNearStops.TabIndex = 3;
            this.gbNearStops.TabStop = false;
            this.gbNearStops.Text = "Haltestellen in meiner Nähe";
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
            // datePicker2
            // 
            this.datePicker2.Location = new System.Drawing.Point(359, 21);
            this.datePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(265, 22);
            this.datePicker2.TabIndex = 2;
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
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(697, 21);
            this.txtTime2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(44, 22);
            this.txtTime2.TabIndex = 3;
            this.txtTime2.Text = "00:00";
            // 
            // tableDepartures
            // 
            this.tableDepartures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableDepartures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDepartures.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableDepartures.Location = new System.Drawing.Point(4, 86);
            this.tableDepartures.Margin = new System.Windows.Forms.Padding(4);
            this.tableDepartures.Name = "tableDepartures";
            this.tableDepartures.Size = new System.Drawing.Size(1498, 636);
            this.tableDepartures.TabIndex = 6;
            // 
            // btnSearchDepartures
            // 
            this.btnSearchDepartures.Location = new System.Drawing.Point(797, 21);
            this.btnSearchDepartures.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDepartures.Name = "btnSearchDepartures";
            this.btnSearchDepartures.Size = new System.Drawing.Size(140, 28);
            this.btnSearchDepartures.TabIndex = 4;
            this.btnSearchDepartures.Text = "Abfahrten suchen";
            this.btnSearchDepartures.UseVisualStyleBackColor = true;
            this.btnSearchDepartures.Click += new System.EventHandler(this.btnSearchDepartures_Click);
            // 
            // gbDepartures
            // 
            this.gbDepartures.Controls.Add(this.acsDeparture);
            this.gbDepartures.Controls.Add(this.btnSearchDepartures);
            this.gbDepartures.Controls.Add(this.tableDepartures);
            this.gbDepartures.Controls.Add(this.txtTime2);
            this.gbDepartures.Controls.Add(this.lbTime2);
            this.gbDepartures.Controls.Add(this.datePicker2);
            this.gbDepartures.Controls.Add(this.lbDate2);
            this.gbDepartures.Controls.Add(this.lbDeparture);
            this.gbDepartures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDepartures.Location = new System.Drawing.Point(3, 3);
            this.gbDepartures.Margin = new System.Windows.Forms.Padding(4);
            this.gbDepartures.Name = "gbDepartures";
            this.gbDepartures.Padding = new System.Windows.Forms.Padding(4);
            this.gbDepartures.Size = new System.Drawing.Size(1506, 726);
            this.gbDepartures.TabIndex = 2;
            this.gbDepartures.TabStop = false;
            this.gbDepartures.Text = "Abfahrtstafel";
            // 
            // acsDeparture
            // 
            this.acsDeparture.Location = new System.Drawing.Point(106, 25);
            this.acsDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.acsDeparture.Name = "acsDeparture";
            this.acsDeparture.Size = new System.Drawing.Size(186, 22);
            this.acsDeparture.TabIndex = 1;
            this.acsDeparture.Enter += new System.EventHandler(this.acsAny_Enter);
            this.acsDeparture.Leave += new System.EventHandler(this.acsDeparture_Leave);
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
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(401, 22);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(265, 22);
            this.datePicker.TabIndex = 3;
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
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(401, 69);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(45, 22);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "00:00";
            // 
            // rbDeparture
            // 
            this.rbDeparture.AutoSize = true;
            this.rbDeparture.Checked = true;
            this.rbDeparture.Location = new System.Drawing.Point(456, 69);
            this.rbDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.rbDeparture.Name = "rbDeparture";
            this.rbDeparture.Size = new System.Drawing.Size(75, 21);
            this.rbDeparture.TabIndex = 5;
            this.rbDeparture.TabStop = true;
            this.rbDeparture.Text = "Abfahrt";
            this.rbDeparture.UseVisualStyleBackColor = true;
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(543, 69);
            this.rbArrival.Margin = new System.Windows.Forms.Padding(4);
            this.rbArrival.Name = "rbArrival";
            this.rbArrival.Size = new System.Drawing.Size(77, 21);
            this.rbArrival.TabIndex = 6;
            this.rbArrival.Text = "Ankunft";
            this.rbArrival.UseVisualStyleBackColor = true;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(711, 21);
            this.btnSearchConnections.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(187, 28);
            this.btnSearchConnections.TabIndex = 7;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // tableConnections
            // 
            this.tableConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableConnections.Location = new System.Drawing.Point(4, 122);
            this.tableConnections.Margin = new System.Windows.Forms.Padding(4);
            this.tableConnections.Name = "tableConnections";
            this.tableConnections.Size = new System.Drawing.Size(1498, 600);
            this.tableConnections.TabIndex = 11;
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
            // gbSearchConnections
            // 
            this.gbSearchConnections.Controls.Add(this.tableConnections);
            this.gbSearchConnections.Controls.Add(this.acsDestination);
            this.gbSearchConnections.Controls.Add(this.acsStart);
            this.gbSearchConnections.Controls.Add(this.lbStart);
            this.gbSearchConnections.Controls.Add(this.btnSearchConnections);
            this.gbSearchConnections.Controls.Add(this.rbArrival);
            this.gbSearchConnections.Controls.Add(this.rbDeparture);
            this.gbSearchConnections.Controls.Add(this.txtTime);
            this.gbSearchConnections.Controls.Add(this.lbTime);
            this.gbSearchConnections.Controls.Add(this.datePicker);
            this.gbSearchConnections.Controls.Add(this.lbDate);
            this.gbSearchConnections.Controls.Add(this.lbDestination);
            this.gbSearchConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchConnections.Location = new System.Drawing.Point(3, 3);
            this.gbSearchConnections.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchConnections.Name = "gbSearchConnections";
            this.gbSearchConnections.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchConnections.Size = new System.Drawing.Size(1506, 726);
            this.gbSearchConnections.TabIndex = 1;
            this.gbSearchConnections.TabStop = false;
            this.gbSearchConnections.Text = "Verbindungen suchen";
            // 
            // acsDestination
            // 
            this.acsDestination.Location = new System.Drawing.Point(106, 71);
            this.acsDestination.Margin = new System.Windows.Forms.Padding(4);
            this.acsDestination.Name = "acsDestination";
            this.acsDestination.Size = new System.Drawing.Size(190, 22);
            this.acsDestination.TabIndex = 2;
            this.acsDestination.Enter += new System.EventHandler(this.acsAny_Enter);
            this.acsDestination.Leave += new System.EventHandler(this.acsConnection_Leave);
            // 
            // acsStart
            // 
            this.acsStart.Location = new System.Drawing.Point(106, 25);
            this.acsStart.Margin = new System.Windows.Forms.Padding(4);
            this.acsStart.Name = "acsStart";
            this.acsStart.Size = new System.Drawing.Size(190, 22);
            this.acsStart.TabIndex = 1;
            this.acsStart.Enter += new System.EventHandler(this.acsAny_Enter);
            this.acsStart.Leave += new System.EventHandler(this.acsConnection_Leave);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabSearchConnections);
            this.tabMenu.Controls.Add(this.tabDepartures);
            this.tabMenu.Controls.Add(this.tabNearStops);
            this.tabMenu.Controls.Add(this.tabSearchStopLocation);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1520, 761);
            this.tabMenu.TabIndex = 1;
            // 
            // tabSearchConnections
            // 
            this.tabSearchConnections.Controls.Add(this.gbSearchConnections);
            this.tabSearchConnections.Location = new System.Drawing.Point(4, 25);
            this.tabSearchConnections.Name = "tabSearchConnections";
            this.tabSearchConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchConnections.Size = new System.Drawing.Size(1512, 732);
            this.tabSearchConnections.TabIndex = 0;
            this.tabSearchConnections.Text = "Verbindungen suchen";
            this.tabSearchConnections.UseVisualStyleBackColor = true;
            this.tabSearchConnections.Enter += new System.EventHandler(this.tabConnections_Enter);
            // 
            // tabDepartures
            // 
            this.tabDepartures.Controls.Add(this.gbDepartures);
            this.tabDepartures.Location = new System.Drawing.Point(4, 25);
            this.tabDepartures.Name = "tabDepartures";
            this.tabDepartures.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartures.Size = new System.Drawing.Size(1512, 732);
            this.tabDepartures.TabIndex = 1;
            this.tabDepartures.Text = "Abfahrtstafel";
            this.tabDepartures.UseVisualStyleBackColor = true;
            this.tabDepartures.Enter += new System.EventHandler(this.tabDepartures_Enter);
            // 
            // tabNearStops
            // 
            this.tabNearStops.Controls.Add(this.gbNearStops);
            this.tabNearStops.Location = new System.Drawing.Point(4, 25);
            this.tabNearStops.Name = "tabNearStops";
            this.tabNearStops.Padding = new System.Windows.Forms.Padding(3);
            this.tabNearStops.Size = new System.Drawing.Size(1512, 732);
            this.tabNearStops.TabIndex = 2;
            this.tabNearStops.Text = "Haltestellen in meiner Nähe";
            this.tabNearStops.UseVisualStyleBackColor = true;
            // 
            // tabSearchStopLocation
            // 
            this.tabSearchStopLocation.Controls.Add(this.gbSearchStopLocation);
            this.tabSearchStopLocation.Location = new System.Drawing.Point(4, 25);
            this.tabSearchStopLocation.Name = "tabSearchStopLocation";
            this.tabSearchStopLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchStopLocation.Size = new System.Drawing.Size(1512, 732);
            this.tabSearchStopLocation.TabIndex = 3;
            this.tabSearchStopLocation.Text = "Haltestellen auf Karte suchen";
            this.tabSearchStopLocation.UseVisualStyleBackColor = true;
            this.tabSearchStopLocation.Enter += new System.EventHandler(this.tabSearchStopLocation_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 761);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1535, 798);
            this.Name = "MainForm";
            this.Text = "Digital ÖV";
            this.gbSearchStopLocation.ResumeLayout(false);
            this.gbSearchStopLocation.PerformLayout();
            this.gbNearStops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDepartures)).EndInit();
            this.gbDepartures.ResumeLayout(false);
            this.gbDepartures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).EndInit();
            this.gbSearchConnections.ResumeLayout(false);
            this.gbSearchConnections.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabSearchConnections.ResumeLayout(false);
            this.tabDepartures.ResumeLayout(false);
            this.tabNearStops.ResumeLayout(false);
            this.tabSearchStopLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSearchStopLocation;
        private System.Windows.Forms.Button btnSearchStopLocation;
        private System.Windows.Forms.WebBrowser mapSearchStopLocation;
        private System.Windows.Forms.GroupBox gbSearchStopLocation;
        private System.Windows.Forms.WebBrowser mapNearStops;
        private System.Windows.Forms.GroupBox gbNearStops;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbDate2;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.DataGridView tableDepartures;
        private System.Windows.Forms.Button btnSearchDepartures;
        private System.Windows.Forms.GroupBox gbDepartures;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.RadioButton rbDeparture;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView tableConnections;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.GroupBox gbSearchConnections;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabSearchConnections;
        private System.Windows.Forms.TabPage tabDepartures;
        private System.Windows.Forms.TabPage tabNearStops;
        private System.Windows.Forms.TabPage tabSearchStopLocation;
        private autocompleteSearch acsStart;
        private autocompleteSearch acsDestination;
        private autocompleteSearch acsDeparture;
        private autocompleteSearch acsSearchStopLocation;
    }
}

