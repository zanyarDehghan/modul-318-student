using System;
using System.Net;
using System.Net.Http;
using System.Device.Location;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web;
using Newtonsoft.Json.Linq;


namespace SwisstransportGUI
{

    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            dtmDate.Format = DateTimePickerFormat.Custom;
            dtmDate.Value= DateTime.Now.Date;
            dtmDate.CustomFormat = "dd.MM.yyyy";

            string strTime = DateTime.Now.ToString("HH:mm");
            txtTime.Text = strTime;
        }

        public string GetInfo(string ipAddress)
        {
          return new WebClient().DownloadString("http://freegeoip.net/json/" + ipAddress);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.Start(); //started watcher
            GeoCoordinate coord = watcher.Position.Location;
            if (!watcher.Position.Location.IsUnknown)
            {
                double lat = coord.Latitude; //latitude
                double longt = coord.Longitude;  //logitude

                getStations("NULL", lat, longt);
            }
            else {

                string IPAdr = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
                string jsonInfo=GetInfo(IPAdr);

                var obj = JObject.Parse(jsonInfo);
                var city = (string)obj["city"];
                txtFrom.Text = city;
                getStations("txtFrom", 0, 0);

            }

        }
        private void txtFrom_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (txtFrom.Text != "" && !string.IsNullOrWhiteSpace(txtFrom.Text)) { 
                getStations(((Control)sender).Name, 0, 0);
            }else
            {
                listResult.Visible = false;
            }
        }

        private void txtTo_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (txtTo.Text != "" && !string.IsNullOrWhiteSpace(txtTo.Text))
            {
                getStations(((Control)sender).Name,0,0);
            }
            else
            {
                listResult.Visible = false;
            }
        }

        public void getStations(string clName, double x, double y)
        {
            listResult.Visible = true;

            listResult.Tag = clName;
            
            SwissTransport.Transport transport = new SwissTransport.Transport();
            SwissTransport.Stations stList = new SwissTransport.Stations();

            stList = transport.GetStations(this.Controls[clName].Text, x, y);
            
            listResult.Items.Clear();
 
            int i = 0;
            for (i = 0; i < stList.StationList.Count; i++){
                   listResult.Items.Add(stList.StationList[i].Name.ToString());
            }
            listResult.BringToFront();
            listResult.Width = this.Controls[clName].Width;
            listResult.Location = new Point(this.Controls[clName].Location.X, this.Controls[clName].Location.Y + 15);
        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            string clsName = ((Control)sender).Tag.ToString();
            this.Controls[clsName].Text = listResult.SelectedItem.ToString();
            listResult.Visible = false;
        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDtDec_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
