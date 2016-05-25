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
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void searchArrival(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();

            dt.Columns.Add(new DataColumn("Bahnhof / Haltestelle", typeof(string)));
            dt.Columns.Add(new DataColumn("Zeit", typeof(string)));
            //dt.Columns.Add(new DataColumn("Reisen mit", typeof(string)));
            dt.Columns.Add(new DataColumn("Dauer", typeof(string)));
            dt.Columns.Add(new DataColumn("Gleis", typeof(string)));

            string fromStation = txtfromStation.Text;
            string toStation = txttoStation.Text;
            var connections = transport.GetConnections(fromStation, toStation).ConnectionList;


            foreach (var connection in connections)
            {

                //var stationBoard = transport.GetStationBoard(fromStation, connection.From.Station.Id);
                //string temp = stationBoard.Entries[0].Name;

                dgvConnections.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dt.Rows.Add(connection.From.Station.Name + Environment.NewLine + connection.To.Station.Name, "ab " + Convert.ToDateTime(connection.From.Departure).ToShortTimeString() +
                    Environment.NewLine + "an " + Convert.ToDateTime(connection.To.Arrival).ToShortTimeString(), connection.Duration.Substring(3), connection.From.Platform + Environment.NewLine + connection.To.Platform);

                dgvConnections.DataSource = dt;
                dgvConnections.Columns[1].Width = 65;
                dgvConnections.Columns[2].Width = 55;
                dgvConnections.Columns[3].Width = 50;
                //dgvConnections.Height = dgvConnections.Rows.GetRowsHeight(DataGridViewElementStates.None);                
            }


        }        

        private void showAutoCompletion(object sender, KeyEventArgs e)
        {
            string station;
            if (txtfromStation.Focused)
            {
                station = txtfromStation.Text;
            }else
            {
                station = txttoStation.Text;
            }
            

            if (station.Length == 3)
            {
                txtfromStation.AutoCompleteCustomSource = autoComplete(station);
                txtfromStation.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtfromStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            if (e.KeyData == Keys.Enter)
            {
                searchArrival(sender, e);
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
    }
}
