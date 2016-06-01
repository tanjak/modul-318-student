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
            //DateTimePickers auf aktuelles Datum und Uhrzeit setzten                    
            this.dtpDatum.Value = DateTime.Now;
            this.dtpZeit.Value = DateTime.Now;
        }       

        //A002 + A005
        //Verbindungen zwischen zwei Stationen suchen
        private void searchTimeTable(object sender, EventArgs e)
        {
            //Cursor auf Sanduhr ändern
            Cursor.Current = Cursors.WaitCursor;

            //DataTable leeren
            dt.Columns.Clear();
            dt.Rows.Clear();

            //dem DataTable Spalten hinzufügen
            dt.Columns.Add(new DataColumn("Bahnhof / Haltestelle"));
            dt.Columns.Add(new DataColumn("Zeit"));
            dt.Columns.Add(new DataColumn("Gleis"));
            dt.Columns.Add(new DataColumn("Dauer"));

            //User-Inputs auslesen
            string fromStation = txtfromStation.Text;
            string toStation = txttoStation.Text;
            DateTime date = dtpDatum.Value;
            DateTime time = dtpZeit.Value;

            try
            {
                var connections = transport.GetConnectionsviaDate(fromStation, toStation, date, time).ConnectionList;
                MessageBox.Show("Hi");

                foreach (var connection in connections)
                {
                    //WrapMode ändern, damit Zeilenumbrüche gemacht werden können
                    dgvConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //Verbindungen dem DataTable hinzufügen
                    dt.Rows.Add(connection.From.Station.Name + Environment.NewLine + connection.To.Station.Name,
                        "ab " + Convert.ToDateTime(connection.From.Departure).ToShortTimeString() + Environment.NewLine +
                        "an " + Convert.ToDateTime(connection.To.Arrival).ToShortTimeString(), connection.From.Platform +
                        Environment.NewLine + connection.To.Platform, connection.Duration.Substring(3));

                    //DataTable als Source dem DataGridView hinzufügen 
                    dgvConnections.DataSource = dt;
                    //Spaltenbreite definieren
                    dgvConnections.Columns[1].Width = 65;
                    dgvConnections.Columns[2].Width = 55;
                    dgvConnections.Columns[3].Width = 50;
                }
            }            
            catch(Exception ex)
            {
                MessageBox.Show("Verbindungen können nicht angezeigt werden." + ex);
            }
            if (dgvConnections.RowCount == 0)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Start- bzw. Endstation ein.");
            }
        }

        //A003
        //Abfahrten einer Station anzeigen
        private void searchDepatures(object sender, EventArgs e)
        {
            //Cursor auf Sanduhr ändern
            Cursor.Current = Cursors.WaitCursor;

            //DataTable leeren
            dt.Columns.Clear();
            dt.Rows.Clear();

            //dem DataTable Spalten hinzufügen
            dt.Columns.Add(new DataColumn("Linie"));
            dt.Columns.Add(new DataColumn("Ziel"));
            dt.Columns.Add(new DataColumn("Abfahrt"));

            try {
                //User-Inputs auslesen
                string station = txtfromStation.Text;
                DateTime date = dtpDatum.Value; 
                DateTime time = dtpZeit.Value;
            
                var stationBoard = transport.GetStationBoardviaDateTime(station, transport.GetStations(station).StationList[0].Id, date, time).Entries;
                                

                foreach (var connection in stationBoard)
                {
                    //Abfahrten dem DataTable hinzufügen
                    dt.Rows.Add(connection.Name, connection.To, Convert.ToDateTime(connection.Stop.Departure).ToShortTimeString());

                    //DataTable als Source dem DataGridView hinzufügen 
                    dgvConnections.DataSource = dt;
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Station ein.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Abfahrten können nicht angezeigt werden." + ex);
            }
            
            
        }

        //A004
        //Auto Complete
        private void showAutoCompletion(object sender, KeyEventArgs e)
        {
            //überprüfen, in welcher Textbox der User ist
            string station = "";
            if (txtfromStation.Focused)
            {
                //User-Input auslesen
                station = txtfromStation.Text;
                //bei User-Input von mehr als 3 Zeichen..
                if (station.Length == 3)
                {
                    //..AutoComplete hinzufügen
                    txtfromStation.AutoCompleteCustomSource = autoComplete(station);
                    txtfromStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtfromStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            else
            {
                //User-Input auslesen
                station = txttoStation.Text;
                //bei User-Input von mehr als 3 Zeichen..
                if (station.Length == 3)
                {
                    //..AutoComplete hinzufügen
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

            //alle Stationen der Collection hinzufügen
            foreach (var station in transportList)
            {
                collection.Add(station.Name);
            }
            return collection;
        }

        //A006
        //Station auf Google Maps anzeigen
        private void showOnMaps(object sender, EventArgs e)
        {            
            string station = "";

            //überprüfen, welcher Button geklickt wurde
            if (btnMapsFrom.Focused)
                station = txtfromStation.Text;
            else
                station = txttoStation.Text;           

            try
            {
                //Koordinaten auslesen
                double x = transport.GetStations(station).StationList[0].Coordinate.XCoordinate;
                double y = transport.GetStations(station).StationList[0].Coordinate.YCoordinate;

                Maps maps = new Maps(x,y);
                maps.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Station ein");
            }
        }

        //A007
        //die nahste Station finden
        private void searchStation(object sender, EventArgs e)
        {
            //Cursor auf Sanduhr ändern
            Cursor.Current = Cursors.WaitCursor;

            //DataTable leeren
            dt.Columns.Clear();
            dt.Rows.Clear();

            //dem DataTable Spalten hinzufügen
            dt.Columns.Add(new DataColumn("Station"));
            dt.Columns.Add(new DataColumn("Distanz (in Meter)"));

            try
            {
                //Koordinaten auslesen
                string xy = transport.getCoordinates(txtAdresse.Text + "," + txtPlz.Text + " " + txtOrt.Text);
                string x = xy.Substring(0, xy.LastIndexOf(','));
                string y = xy.Substring(xy.IndexOf(' ') + 1);

                var stationList = transport.getNearestStation(Convert.ToDouble(x), Convert.ToDouble(y)).StationList;

                foreach (var station in stationList)
                {
                    //jede Station dem DataTable hinzufügen
                    dt.Rows.Add(station.Name, station.Distance);
                    //DataTable als Source dem DataGridView hinzufügen 
                    dgvConnections.DataSource = dt;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Adresse ein.");
            }
            
        }

        //A008
        //Mail mit den Verbindungen versenden
        private void sendMail(object sender, EventArgs e)
        {
            
            StringBuilder mailBody = new StringBuilder();
            //Header dem Stringbuilder hinzufügen
            foreach (DataGridViewColumn col in dgvConnections.Columns)
            {
                mailBody.AppendFormat("<th>" + col.HeaderText + "</th>");
            }
            //Zeilen dem Stringbuilder hinzufügen
            foreach (DataGridViewRow row in dgvConnections.Rows)
            {
                mailBody.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody.Append("<td>" + cell.Value + "</td>");
                }
                mailBody.Append("</tr>");
            }
            mailBody.Append("</table>");           

            Mail mail = new Mail(mailBody.ToString());
            mail.ShowDialog();
        }

        //Hover über dem 'per Mail teilen'
        private void llblMail_MouseHover(object sender, EventArgs e)
        {
            llblMail.LinkColor = Color.Blue;
        }
        private void llblMail_MouseLeave(object sender, EventArgs e)
        {
            llblMail.LinkColor = Color.Black;
        }

        //RadioButton ändert, dann..
        private void checkedChanged(object sender, EventArgs e)
        {
            if (rbTimeTable.Checked)
            {
                panelSearchStation.Visible = false;
                btnMapsTo.Enabled = true;
                txttoStation.Enabled = true;
                btnTimeTable.Visible = true;

            }
            else if (rbDepartueTable.Checked)
            {
                btnDepartures.Visible = true;
                btnMapsTo.Enabled = false;
                txttoStation.Enabled = false;
                btnTimeTable.Visible = false;
                panelSearchStation.Visible = false;
            }
            else
            {
                panelSearchStation.Visible = true;
            }
        }
    }
}
