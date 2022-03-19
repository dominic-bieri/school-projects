using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;

namespace MyTransportApp
{
  public partial class Form1 : Form
  {
    // new Object to use the Swiss public transport API
    ITransport transport = new Transport();

    public Form1()
    {
      InitializeComponent();
    }

    // prints departure / arrival + how long journey takes
    private void btnConnection_Click(object sender, EventArgs e)
    {
      try
      {
        dgvConnection.Rows.Clear();
        List<Connection> row = transport.GetConnections(tbxStartstation.Text, tbxEndstation.Text, dtpDateConnections.Value.ToString("yyyy-MM-dd"), dtpTimeConnections.Value.ToString("HH:mm")).ConnectionList;
        for (int i = 0; i < 4; i++)
        {
          dgvConnection.Rows.Add(new[]
          {
            row[i].From.Departure.ToString(),
            row[i].To.Arrival.Value.ToString(),
            row[i].Duration.Replace("00d", ""),
            row[i].From.Platform
           }) ;
        }
      }
      catch
      {
        MessageBox.Show("Error was found\nPlease check your input");
      }
    }

    private string timetableGetId(string station)
    {
      return transport.GetStations(station).StationList[0].Id.ToString();
    }

    // searches for departures at a Station
    private void btnTimetable_Click(object sender, EventArgs e)
    {
      try
      {
        dgvTimetable.Rows.Clear();
        var row = transport.GetStationBoard(tbxStation.Text, timetableGetId(tbxStation.Text), dtpDateTimetable.Value.ToString("yyyy-MM-dd") + " " + dtpTimeTimetable.Value.ToString("HH:mm")).Entries;
        for (int i = 0; i <= 10; i++)
        {
            dgvTimetable.Rows.Add(
            row[i].Stop.Departure.ToString("HH:mm"),
            row[i].To
          );
        }
      }
      catch
      {
        MessageBox.Show("Error was found\nPlease check your input");
      }
     }

    // autocompletion for Textbox-Startstation
    private void tbxStartstation_TextChanged(object sender, EventArgs e)
    {
      try
      {
        lbxStartstation.Items.Clear();

        List<Station> stationList = transport.GetStations(tbxStartstation.Text).StationList;
        
        foreach(Station station in stationList)
        {
          lbxStartstation.Items.Add(station.Name);
        }
      }
      
      catch
      {
        MessageBox.Show("Error was found\nPlease check your input");
      }
    }

    // autocompletion for Textbox-Endstation
    private void tbxEndstation_TextChanged(object sender, EventArgs e)
    {
      try
      {
        lbxEndstation.Items.Clear();

        List<Station> stationList = transport.GetStations(tbxEndstation.Text).StationList;

        foreach (Station station in stationList)
        {
          lbxEndstation.Items.Add(station.Name);
        }
      }
      catch
      {
        MessageBox.Show("Error was found\nPlease check your input");
      }
    }

    // autocompletion for Textbox-Station
    private void tbxStation_TextChanged(object sender, EventArgs e)
    {
      try
      {
        lbxStation.Items.Clear();

        List<Station> stationList = transport.GetStations(tbxStation.Text).StationList;

        foreach (Station station in stationList)
        {
          lbxStation.Items.Add(station.Name);
        }
      }
      catch
      {
        MessageBox.Show("Error was found\nPlease check your input");
      }
    }

    // to select a value from Autocompletion-Startstation
    private void lbxStartstation_SelectedIndexChanged(object sender, EventArgs e)
    {
      tbxStartstation.Text = lbxStartstation.SelectedItem.ToString();
      lbxStartstation.Items.Clear();
    }

    // to select a value from Autocompletion-Endstation
    private void lbxEndstation_SelectedIndexChanged(object sender, EventArgs e)
    {
      tbxEndstation.Text = lbxEndstation.SelectedItem.ToString();
      lbxEndstation.Items.Clear();
    }

    private void lbxStation_SelectedIndexChanged(object sender, EventArgs e)
    {
      tbxStation.Text = lbxStation.SelectedItem.ToString();
      lbxStation.Items.Clear();
    }

    // switch Start with End & End with Start
    private void btnSwitch_Click(object sender, EventArgs e)
    {
      string station1 = tbxStartstation.Text;
      string station2 = tbxEndstation.Text;
      tbxStartstation.Text = station2;
      tbxEndstation.Text = station1;

      lbxStartstation.Items.Clear();
      lbxEndstation.Items.Clear();
    }
  }
}