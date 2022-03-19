
namespace MyTransportApp
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbxStartstation = new System.Windows.Forms.TextBox();
      this.lblStartstation = new System.Windows.Forms.Label();
      this.lblEndstation = new System.Windows.Forms.Label();
      this.tbxEndstation = new System.Windows.Forms.TextBox();
      this.btnConnection = new System.Windows.Forms.Button();
      this.dgvConnection = new System.Windows.Forms.DataGridView();
      this.lblStation = new System.Windows.Forms.Label();
      this.tbxStation = new System.Windows.Forms.TextBox();
      this.btnTimetable = new System.Windows.Forms.Button();
      this.dgvTimetable = new System.Windows.Forms.DataGridView();
      this.timeColumnStationboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.destinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbxStartstation = new System.Windows.Forms.ListBox();
      this.lbxEndstation = new System.Windows.Forms.ListBox();
      this.lbxStation = new System.Windows.Forms.ListBox();
      this.btnSwitch = new System.Windows.Forms.Button();
      this.lblConnections = new System.Windows.Forms.Label();
      this.lblTimetable = new System.Windows.Forms.Label();
      this.dtpDateConnections = new System.Windows.Forms.DateTimePicker();
      this.departureColumnConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.arrivalColumnConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.journeyColumnConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.platformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtpTimeConnections = new System.Windows.Forms.DateTimePicker();
      this.dtpDateTimetable = new System.Windows.Forms.DateTimePicker();
      this.dtpTimeTimetable = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
      this.SuspendLayout();
      // 
      // tbxStartstation
      // 
      this.tbxStartstation.Location = new System.Drawing.Point(153, 76);
      this.tbxStartstation.Name = "tbxStartstation";
      this.tbxStartstation.Size = new System.Drawing.Size(137, 20);
      this.tbxStartstation.TabIndex = 0;
      this.tbxStartstation.TextChanged += new System.EventHandler(this.tbxStartstation_TextChanged);
      // 
      // lblStartstation
      // 
      this.lblStartstation.AutoSize = true;
      this.lblStartstation.Location = new System.Drawing.Point(9, 79);
      this.lblStartstation.Name = "lblStartstation";
      this.lblStartstation.Size = new System.Drawing.Size(63, 13);
      this.lblStartstation.TabIndex = 1;
      this.lblStartstation.Text = "Startstation:";
      // 
      // lblEndstation
      // 
      this.lblEndstation.AutoSize = true;
      this.lblEndstation.Location = new System.Drawing.Point(9, 209);
      this.lblEndstation.Name = "lblEndstation";
      this.lblEndstation.Size = new System.Drawing.Size(60, 13);
      this.lblEndstation.TabIndex = 2;
      this.lblEndstation.Text = "Endstation:";
      // 
      // tbxEndstation
      // 
      this.tbxEndstation.Location = new System.Drawing.Point(153, 206);
      this.tbxEndstation.Name = "tbxEndstation";
      this.tbxEndstation.Size = new System.Drawing.Size(137, 20);
      this.tbxEndstation.TabIndex = 2;
      this.tbxEndstation.TextChanged += new System.EventHandler(this.tbxEndstation_TextChanged);
      // 
      // btnConnection
      // 
      this.btnConnection.Location = new System.Drawing.Point(153, 275);
      this.btnConnection.Name = "btnConnection";
      this.btnConnection.Size = new System.Drawing.Size(137, 23);
      this.btnConnection.TabIndex = 5;
      this.btnConnection.Text = "Search";
      this.btnConnection.UseVisualStyleBackColor = true;
      this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
      // 
      // dgvConnection
      // 
      this.dgvConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureColumnConnections,
            this.arrivalColumnConnections,
            this.journeyColumnConnections,
            this.platformColumn});
      this.dgvConnection.Location = new System.Drawing.Point(12, 344);
      this.dgvConnection.Name = "dgvConnection";
      this.dgvConnection.RowHeadersVisible = false;
      this.dgvConnection.Size = new System.Drawing.Size(576, 150);
      this.dgvConnection.TabIndex = 5;
      this.dgvConnection.TabStop = false;
      // 
      // lblStation
      // 
      this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblStation.AutoSize = true;
      this.lblStation.Location = new System.Drawing.Point(375, 83);
      this.lblStation.Name = "lblStation";
      this.lblStation.Size = new System.Drawing.Size(43, 13);
      this.lblStation.TabIndex = 6;
      this.lblStation.Text = "Station:";
      // 
      // tbxStation
      // 
      this.tbxStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbxStation.Location = new System.Drawing.Point(451, 76);
      this.tbxStation.Name = "tbxStation";
      this.tbxStation.Size = new System.Drawing.Size(137, 20);
      this.tbxStation.TabIndex = 6;
      this.tbxStation.TextChanged += new System.EventHandler(this.tbxStation_TextChanged);
      // 
      // btnTimetable
      // 
      this.btnTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTimetable.Location = new System.Drawing.Point(451, 151);
      this.btnTimetable.Name = "btnTimetable";
      this.btnTimetable.Size = new System.Drawing.Size(137, 23);
      this.btnTimetable.TabIndex = 9;
      this.btnTimetable.Text = "Search";
      this.btnTimetable.UseVisualStyleBackColor = true;
      this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
      // 
      // dgvTimetable
      // 
      this.dgvTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeColumnStationboard,
            this.destinationColumn});
      this.dgvTimetable.Location = new System.Drawing.Point(343, 180);
      this.dgvTimetable.Name = "dgvTimetable";
      this.dgvTimetable.RowHeadersVisible = false;
      this.dgvTimetable.Size = new System.Drawing.Size(245, 118);
      this.dgvTimetable.TabIndex = 9;
      this.dgvTimetable.TabStop = false;
      // 
      // timeColumnStationboard
      // 
      this.timeColumnStationboard.HeaderText = "Time";
      this.timeColumnStationboard.Name = "timeColumnStationboard";
      this.timeColumnStationboard.ReadOnly = true;
      // 
      // destinationColumn
      // 
      this.destinationColumn.HeaderText = "Destination";
      this.destinationColumn.Name = "destinationColumn";
      this.destinationColumn.ReadOnly = true;
      // 
      // lbxStartstation
      // 
      this.lbxStartstation.FormattingEnabled = true;
      this.lbxStartstation.Location = new System.Drawing.Point(153, 96);
      this.lbxStartstation.Name = "lbxStartstation";
      this.lbxStartstation.Size = new System.Drawing.Size(137, 43);
      this.lbxStartstation.TabIndex = 10;
      this.lbxStartstation.TabStop = false;
      this.lbxStartstation.SelectedIndexChanged += new System.EventHandler(this.lbxStartstation_SelectedIndexChanged);
      // 
      // lbxEndstation
      // 
      this.lbxEndstation.FormattingEnabled = true;
      this.lbxEndstation.Location = new System.Drawing.Point(153, 226);
      this.lbxEndstation.Name = "lbxEndstation";
      this.lbxEndstation.Size = new System.Drawing.Size(137, 43);
      this.lbxEndstation.TabIndex = 11;
      this.lbxEndstation.TabStop = false;
      this.lbxEndstation.SelectedIndexChanged += new System.EventHandler(this.lbxEndstation_SelectedIndexChanged);
      // 
      // lbxStation
      // 
      this.lbxStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbxStation.FormattingEnabled = true;
      this.lbxStation.Location = new System.Drawing.Point(451, 96);
      this.lbxStation.Name = "lbxStation";
      this.lbxStation.Size = new System.Drawing.Size(137, 43);
      this.lbxStation.TabIndex = 12;
      this.lbxStation.TabStop = false;
      this.lbxStation.SelectedIndexChanged += new System.EventHandler(this.lbxStation_SelectedIndexChanged);
      // 
      // btnSwitch
      // 
      this.btnSwitch.Location = new System.Drawing.Point(153, 160);
      this.btnSwitch.Name = "btnSwitch";
      this.btnSwitch.Size = new System.Drawing.Size(137, 23);
      this.btnSwitch.TabIndex = 1;
      this.btnSwitch.Text = "Switch";
      this.btnSwitch.UseVisualStyleBackColor = true;
      this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
      // 
      // lblConnections
      // 
      this.lblConnections.AutoSize = true;
      this.lblConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblConnections.Location = new System.Drawing.Point(9, 21);
      this.lblConnections.Name = "lblConnections";
      this.lblConnections.Size = new System.Drawing.Size(161, 18);
      this.lblConnections.TabIndex = 16;
      this.lblConnections.Text = "Search Connections";
      // 
      // lblTimetable
      // 
      this.lblTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTimetable.AutoSize = true;
      this.lblTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTimetable.Location = new System.Drawing.Point(385, 21);
      this.lblTimetable.Name = "lblTimetable";
      this.lblTimetable.Size = new System.Drawing.Size(162, 18);
      this.lblTimetable.TabIndex = 17;
      this.lblTimetable.Text = "Search Stationboard";
      // 
      // dtpDateConnections
      // 
      this.dtpDateConnections.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateConnections.Location = new System.Drawing.Point(12, 249);
      this.dtpDateConnections.Name = "dtpDateConnections";
      this.dtpDateConnections.Size = new System.Drawing.Size(90, 20);
      this.dtpDateConnections.TabIndex = 3;
      // 
      // departureColumnConnections
      // 
      this.departureColumnConnections.HeaderText = "Departure";
      this.departureColumnConnections.Name = "departureColumnConnections";
      this.departureColumnConnections.ReadOnly = true;
      // 
      // arrivalColumnConnections
      // 
      this.arrivalColumnConnections.HeaderText = "Arrival";
      this.arrivalColumnConnections.Name = "arrivalColumnConnections";
      this.arrivalColumnConnections.ReadOnly = true;
      // 
      // journeyColumnConnections
      // 
      this.journeyColumnConnections.HeaderText = "Journey";
      this.journeyColumnConnections.Name = "journeyColumnConnections";
      this.journeyColumnConnections.ReadOnly = true;
      // 
      // platformColumn
      // 
      this.platformColumn.HeaderText = "Platform";
      this.platformColumn.Name = "platformColumn";
      this.platformColumn.ReadOnly = true;
      // 
      // dtpTimeConnections
      // 
      this.dtpTimeConnections.CustomFormat = "HH:mm";
      this.dtpTimeConnections.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpTimeConnections.Location = new System.Drawing.Point(12, 278);
      this.dtpTimeConnections.Name = "dtpTimeConnections";
      this.dtpTimeConnections.ShowUpDown = true;
      this.dtpTimeConnections.Size = new System.Drawing.Size(90, 20);
      this.dtpTimeConnections.TabIndex = 4;
      // 
      // dtpDateTimetable
      // 
      this.dtpDateTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dtpDateTimetable.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateTimetable.Location = new System.Drawing.Point(355, 119);
      this.dtpDateTimetable.Name = "dtpDateTimetable";
      this.dtpDateTimetable.Size = new System.Drawing.Size(90, 20);
      this.dtpDateTimetable.TabIndex = 7;
      // 
      // dtpTimeTimetable
      // 
      this.dtpTimeTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.dtpTimeTimetable.CustomFormat = "HH:mm";
      this.dtpTimeTimetable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpTimeTimetable.Location = new System.Drawing.Point(355, 150);
      this.dtpTimeTimetable.Name = "dtpTimeTimetable";
      this.dtpTimeTimetable.ShowUpDown = true;
      this.dtpTimeTimetable.Size = new System.Drawing.Size(90, 20);
      this.dtpTimeTimetable.TabIndex = 8;
      // 
      // Form1
      // 
      this.AcceptButton = this.btnConnection;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 506);
      this.Controls.Add(this.dtpTimeTimetable);
      this.Controls.Add(this.dtpDateTimetable);
      this.Controls.Add(this.dtpTimeConnections);
      this.Controls.Add(this.dtpDateConnections);
      this.Controls.Add(this.lblTimetable);
      this.Controls.Add(this.lblConnections);
      this.Controls.Add(this.btnSwitch);
      this.Controls.Add(this.lbxStation);
      this.Controls.Add(this.lbxEndstation);
      this.Controls.Add(this.lbxStartstation);
      this.Controls.Add(this.dgvTimetable);
      this.Controls.Add(this.btnTimetable);
      this.Controls.Add(this.tbxStation);
      this.Controls.Add(this.lblStation);
      this.Controls.Add(this.dgvConnection);
      this.Controls.Add(this.btnConnection);
      this.Controls.Add(this.tbxEndstation);
      this.Controls.Add(this.lblEndstation);
      this.Controls.Add(this.lblStartstation);
      this.Controls.Add(this.tbxStartstation);
      this.Name = "Form1";
      this.Text = "Transport App";
      ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbxStartstation;
    private System.Windows.Forms.Label lblStartstation;
    private System.Windows.Forms.Label lblEndstation;
    private System.Windows.Forms.TextBox tbxEndstation;
    private System.Windows.Forms.Button btnConnection;
    private System.Windows.Forms.DataGridView dgvConnection;
    private System.Windows.Forms.Label lblStation;
    private System.Windows.Forms.TextBox tbxStation;
    private System.Windows.Forms.Button btnTimetable;
    private System.Windows.Forms.DataGridView dgvTimetable;
    private System.Windows.Forms.DataGridViewTextBoxColumn timeColumnStationboard;
    private System.Windows.Forms.DataGridViewTextBoxColumn destinationColumn;
    private System.Windows.Forms.ListBox lbxStartstation;
    private System.Windows.Forms.ListBox lbxEndstation;
    private System.Windows.Forms.ListBox lbxStation;
    private System.Windows.Forms.Button btnSwitch;
    private System.Windows.Forms.Label lblConnections;
    private System.Windows.Forms.Label lblTimetable;
    private System.Windows.Forms.DateTimePicker dtpDateConnections;
    private System.Windows.Forms.DataGridViewTextBoxColumn departureColumnConnections;
    private System.Windows.Forms.DataGridViewTextBoxColumn arrivalColumnConnections;
    private System.Windows.Forms.DataGridViewTextBoxColumn journeyColumnConnections;
    private System.Windows.Forms.DataGridViewTextBoxColumn platformColumn;
    private System.Windows.Forms.DateTimePicker dtpTimeConnections;
    private System.Windows.Forms.DateTimePicker dtpDateTimetable;
    private System.Windows.Forms.DateTimePicker dtpTimeTimetable;
  }
}

