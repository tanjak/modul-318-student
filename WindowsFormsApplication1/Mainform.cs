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


namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        Transport transport = new Transport();
        DataTable dt = new DataTable();

        public mainForm()
        {
            InitializeComponent();
            this.dtpDatum.Value = DateTime.Now;
            this.dtpZeit.Value = DateTime.Now;
        }

        //if radio button check changes
        private void checkedChanged(object sender, EventArgs e)
        {
            if (rbTimeTable.Checked)
            {
                btnTimeTable.Visible = true;
                txttoStation.Enabled = true;
                btnMapsTo.Enabled = true;
                btnDepartures.Visible = false;
            }
            else
            {
                btnDepartures.Visible = true;
                btnTimeTable.Visible = false;
                txttoStation.Enabled = false;
                btnMapsTo.Enabled = false;
            }
        }

        //A002 + A005
        private void searchTimeTable(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();

            dt.Columns.Add(new DataColumn("Bahnhof / Haltestelle", typeof(string)));
            dt.Columns.Add(new DataColumn("Zeit", typeof(string)));
            dt.Columns.Add(new DataColumn("Gleis", typeof(string)));
            dt.Columns.Add(new DataColumn("Dauer", typeof(string)));

            string fromStation = txtfromStation.Text;
            string toStation = txttoStation.Text;
            DateTime date = dtpDatum.Value;
            DateTime time = dtpZeit.Value;

            var connections = transport.GetConnectionsviaDate(fromStation, toStation, date, time).ConnectionList;

            foreach (var connection in connections)
            {
                dgvConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dt.Rows.Add(connection.From.Station.Name + Environment.NewLine + connection.To.Station.Name, 
                    "ab " + Convert.ToDateTime(connection.From.Departure).ToShortTimeString() + Environment.NewLine + 
                    "an " + Convert.ToDateTime(connection.To.Arrival).ToShortTimeString(), connection.From.Platform + 
                    Environment.NewLine + connection.To.Platform, connection.Duration.Substring(3));

                dgvConnections.DataSource = dt;
                dgvConnections.Columns[1].Width = 65;
                dgvConnections.Columns[2].Width = 55;
                dgvConnections.Columns[3].Width = 50;   
            }
        }

        //A003
        private void searchDepatures(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();

            dt.Columns.Add(new DataColumn("Linie", typeof(string)));
            dt.Columns.Add(new DataColumn("Ziel", typeof(string)));
            //dt.Columns.Add(new DataColumn("Gleis", typeof(string)));
            dt.Columns.Add(new DataColumn("Abfahrt", typeof(string)));

            string station = txtfromStation.Text;
            DateTime date = dtpDatum.Value; 
            DateTime time = dtpZeit.Value;
            var stationBoard = transport.GetStationBoardviaDateTime(station, transport.GetStations(station).StationList[0].Id, date, time).Entries;

            foreach (var connection in stationBoard)
            {
                dgvConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dt.Rows.Add(connection.Name, connection.To, Convert.ToDateTime(connection.Stop.Departure).ToShortTimeString());

                dgvConnections.DataSource = dt;
            }
        }

        //A004
        private void showAutoCompletion(object sender, KeyEventArgs e)
        {
            string station = "";
            if (txtfromStation.Focused)
            {
                station = txtfromStation.Text;
                if (station.Length == 3)
                {
                    txtfromStation.AutoCompleteCustomSource = autoComplete(station);
                    txtfromStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtfromStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else
            {
                station = txttoStation.Text;
                if (station.Length == 3)
                {
                    txttoStation.AutoCompleteCustomSource = autoComplete(station);
                    txttoStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txttoStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }            
        }

        public AutoCompleteStringCollection autoComplete(string value)
        {
            var collection = new AutoCompleteStringCollection();

            var transportList = transport.GetStations(value).StationList;

            foreach (var station in transportList)
            {
                collection.Add(station.Name);
            }
            return collection;
        }

        //A006
        private void showOnMaps(object sender, EventArgs e)
        {
            string station = "";
            if (btnMapsFrom.Focused)
            {
                station = txtfromStation.Text;  
            }
            else
            {
                station = txttoStation.Text;
                
            }

            var transportList = transport.GetStations(station).StationList;

            if (station == "")
            {
                MessageBox.Show("Bitte Station eingeben.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Applikation wird verlassen. Fortfahren?", "Achtung!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    double x = transportList[0].Coordinate.XCoordinate;
                    double y = transportList[0].Coordinate.YCoordinate;
                    System.Diagnostics.Process.Start("https://www.google.ch/maps/place/" + x + "+" + y);
                }
            }
        }

        //A008
        private void sendMail(object sender, EventArgs e)
        {
            List<string> aList = new List<string>();

            foreach (DataGridViewRow row in dgvConnections.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    aList.Add(cell.Value.ToString() + Environment.NewLine);
                }
            }

            //var rowIndex = dgvConnections.SelectedCells[0].RowIndex;
            //string temp = dgvConnections.Rows[rowIndex].Cells[0].Value.ToString() + dgvConnections.Rows[rowIndex].Cells[1].Value.ToString();

            Mail mail = new Mail(aList);
            mail.Show();
        }
    }
}
