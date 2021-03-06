﻿using System;
using System.Net;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System.Net.Mail;

namespace SwisstransportGUI
{

    public partial class UserControl1 : UserControl
    {
        private BrowserView browserView;
        public UserControl1()
        {
            InitializeComponent();
            dtmDate.Format = DateTimePickerFormat.Custom;
            dtmDate.Value = DateTime.Now.Date;
            dtmDate.CustomFormat = "dd.MM.yyyy";

            int intHour = int.Parse(DateTime.Now.ToString("HH"));
            txtHour.Text = intHour.ToString("00");

            string strMin = DateTime.Now.ToString("mm");
            txtMin.Text = strMin;

            browserView = new WinFormsBrowserView();
            wbBrowserMap.Controls.Add((Control)browserView.GetComponent());

            //Events für Controls hinzufügen
            txtFrom.KeyUp += Common_txtKeyUp;
            txtTo.KeyUp += Common_txtKeyUp;
            txtStBoard.KeyUp += Common_txtKeyUp;
            dtmDate.ValueChanged += params_FormChanged;
            txtHour.ValueChanged += params_FormChanged;
            txtMin.ValueChanged += params_FormChanged;
            btnRefresh.Click+= params_FormChanged;
            rdBtnLimit.Click += params_FormChanged;
            rdBtnNoLimit.Click += params_FormChanged;
            tabClTxt.KeyUp += ListBoxListener;

            foreach (Control c in gBoxAdvSearch.Controls)
            {  
                if ((c is CheckBox) || (c is RadioButton))
                {
                    c.Click += params_FormChanged;   
                }
            }
        }

        //fragt nach Stationen, die in in Textbox eingegeben wurde.
        public void getStListe(string clName, double lat, double longt, string clText)
        {

            SwissTransport.Transport transport = new SwissTransport.Transport();
            SwissTransport.Stations stList = new SwissTransport.Stations();

            if (clName == "NULL")
            {
                stList = transport.GetStations("NULL", lat, longt);
            }
            else
            {
                stList = transport.GetStations(clText, 0, 0);
            }

            listResult.Items.Clear();

            int i = 0;
            for (i = 0; i < stList.StationList.Count; i++)
            {
                listResult.Items.Add(stList.StationList[i].Name.ToString());
                if (clText == stList.StationList[i].Name)
                {
                    listResult.SelectedItem = 0;
                }
            }

            listResult.BringToFront();
        }

        //es sammelt die Parameters welche via URL an Swiss Transport Datenbank gesendet wird.
        public string getParams()
        {
            string strDtTm = dtmDate.Value.ToString("yyyy-MM-dd");

            strDtTm += " " + txtHour.Value + ":" + txtMin.Value;
            string strParams = "&datetime=" + strDtTm;

            string uncheck = "NULL";

            foreach (Control c in gBoxAdvSearch.Controls)
            {
                if ((c is CheckBox) && (((CheckBox)c).Tag.ToString() == "childZug" || ((CheckBox)c).Tag.ToString() == "anotherChb"))
                    {

                    if (!((CheckBox)c).Checked)
                    {

                        uncheck = "needURL";
                    }
                    else if (((CheckBox)c).Checked)
                    {


                    }
                }

            }
            if (uncheck == "needURL")
            {

                foreach (Control c in gBoxAdvSearch.Controls)
                {
                    if ((c is CheckBox) && (((CheckBox)c).Tag.ToString() == "childZug" || ((CheckBox)c).Tag.ToString() == "anotherChb"))
                    {
                        if (((CheckBox)c).Checked)
                        {

                            string strPrm = ((CheckBox)c).Name.Replace("chb", "");
                            strParams += "&transportations[]=" + strPrm;

                        }
                    }

                }
            }
            if (chbBike.Checked)
                strParams += "&bike=1";

            if (rdBtnLimit.Checked)
                strParams += "&accessibility=independent_boarding";


            return strParams;

        }

        //es fragt nach mögliche Verbindungen
        private void showConnections(string from, string to)
        {
            pnlWeb.Visible = true;
            SwissTransport.Transport trns = new SwissTransport.Transport();
            SwissTransport.Connections connListe = new SwissTransport.Connections();

            connListe = trns.GetConnections(from, to, getParams());
           
            int i = 0;
            string tblBody="";
            string row1="";
            string row2="";
            for (i = 0; i < connListe.ConnectionList.Count; i++)
            {
               
                string DurTm = connListe.ConnectionList[i].Duration;
                string platformNr = connListe.ConnectionList[i].From.Platform;

                string journeyOp = "";

                if (connListe.ConnectionList[i].Sections[0].Journey.Operator != null)
                {
                    journeyOp = connListe.ConnectionList[i].Sections[0].Journey.Operator;
                    if (connListe.ConnectionList[i].Sections[0].Journey.Number!=null)
                    {
                        journeyOp += " " + connListe.ConnectionList[i].Sections[0].Journey.Number;
                    }
                }
                
                DurTm = DurTm.Substring(3, DurTm.Length - 3);

                DurTm = DurTm.Substring(0, 5);

                var array = DurTm.Split(new string[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries);
                int DurTmH = Int32.Parse(array[0]); 
                int DurTmM = Int32.Parse(array[1]);

                if (DurTmH > 0)
                {
                    DurTm = DurTmH.ToString() + " h ";
                    if (DurTmM > 0)
                    {
                        DurTm += DurTmM.ToString() + " min";
                    }
                }
                else
                {
                    DurTm = DurTmM.ToString() + " min";
                }

                int? delay= connListe.ConnectionList[i].From.Delay;

                string DepDatTim = connListe.ConnectionList[i].From.Departure;
                string ArrDatTim = connListe.ConnectionList[i].To.Arrival;

                int Capacity2 = 0;
                int Capacity1 = 0;
                string Cp2 = "&#128697;";
                string Cp1 = "&#128697;";
                if (connListe.ConnectionList[i].Capacity1st != null)
                {
                    Capacity1 = Int32.Parse(connListe.ConnectionList[i].Capacity1st);
                    
                    for (i = -1; i > Capacity1; i++)
                    {
                        Cp1 += Cp1;
                    }
                }

                if (connListe.ConnectionList[i].Capacity2st != null)
                {

                    Capacity2 = Int32.Parse(connListe.ConnectionList[i].Capacity2st);

                    for (i = -1; i > Capacity2; i++)
                    {
                        Cp2 += Cp2;
                    }
                }
                string Capacity = "1." + Cp1 + " 2." + Cp2;
                    

                DateTime dtD = Convert.ToDateTime(DepDatTim);

                string DepDt= dtD.ToUniversalTime().ToString("dd'.'MM'.'yyyy");
                string DepTm = dtD.ToUniversalTime().ToString("HH':'mm");

                DateTime dtA = Convert.ToDateTime(ArrDatTim);
                string ArrTm = dtA.ToUniversalTime().ToString("HH':'mm");
                
                if (i == 0) {
                    row1 = "<tr><td colspan='3'>"+DepDt+"<td></td>";
                }
                else {
                    row1 = "";
                }
                string DepDatTimOld="";

                if (i>0)
                {
                    DepDatTimOld = connListe.ConnectionList[i - 1].From.Departure;

                }
                else
                {
                    DepDatTimOld = connListe.ConnectionList[i].From.Departure;
                }

                DateTime dtD_Old = Convert.ToDateTime(DepDatTimOld);
                if (dtD.Day > dtD_Old.Day)
                {
                    row1 = "<tr style='background-color:blue; color:white;'><td colspan='3'>" + DepDt + "<td></td>";
                }

                string delayMin="";

                if (delay > 0)
                {
                    delayMin = " ca. +"+ delay.ToString();
                }

                row2 = "<tr><td>" + DepTm + delayMin +"</td><td>" + ArrTm + "</td><td>" + DurTm + "</td><td>" + platformNr + "</td></td>" + "</td><td>" + journeyOp + "</td><td>" + Capacity + "</td></td>";
                tblBody += row1 + row2;

                string html ="<html><head><style>table {font-size:12px;background-color:blue; color:white; border-collapse: collapse; width: 100 %;}";
                html += "th, td {padding: 0.25rem; text-align: left; border: 1px solid #ccc;} tbody tr:hover {background: red;color: white;}</style></head><body><table><thead><th>Abfahrt</th><th>Ankunft</th>";
                html +="<th> Dauer </th><th> Gleis </th><th> Mit </th><th> Belegung </th></thead> " + tblBody + " </table></body></html>";
                wbBrowserDataTable.Navigate("about:blank");
                wbBrowserDataTable.Document.OpenNew(false);
                wbBrowserDataTable.Document.Write(html);
                wbBrowserDataTable.Refresh();
            }
        }


        // schient Abfrahrtstaffel
        public void showStBoard(string clText)
        {
            pnlWeb.Visible = true;
            SwissTransport.Transport trns = new SwissTransport.Transport();
            SwissTransport.StationBoardRoot boardList = new SwissTransport.StationBoardRoot();

           
            string strPrm = getParams();

            boardList = trns.GetStationBoard(txtStBoard.Text, "", strPrm);

            int i = 0;
            string tblBody = "";
            string row1 = "";
            string row2 = "";

            for (i = 0; i < boardList.Entries.Count; i++)
            {

                string platformNr = boardList.Entries[i].Stop.Platform;
               
                string journeyCat = "";
                int? delay = 0;
                if (boardList.Entries[i].Stop.Delay!=null) { 
                     delay = Int32.Parse(boardList.Entries[i].Stop.Delay);
                }
                string DepDatTim = boardList.Entries[i].Stop.Departure;
                string ArrDatTim = boardList.Entries[i].Stop.Arrival;
                string toDest = boardList.Entries[i].To;

                int? Capacity2 = 0;
                int? Capacity1 = 0;
                string Cp2 = "&#128697;";
                string Cp1 = "&#128697;";


                journeyCat += boardList.Entries[i].Operator +" " + boardList.Entries[i].Name;

                if (boardList.Entries[i].Stop.Prognosis.Capacity1st != null)
                {
                    Capacity1 = boardList.Entries[i].Stop.Prognosis.Capacity1st;

                    for (i = -1; i > Capacity1; i++)
                    {
                        Cp1 += Cp1;
                    }
                }

                if (boardList.Entries[i].Stop.Prognosis.Capacity2nd != null)
                {

                    Capacity2 = boardList.Entries[i].Stop.Prognosis.Capacity2nd;

                    for (i = -1; i > Capacity2; i++)
                    {
                        Cp2 += Cp2;
                    }
                }
                string Capacity = "1." + Cp1 + " 2." + Cp2;


                DateTime dtD = Convert.ToDateTime(DepDatTim);

                string DepDt = dtD.ToUniversalTime().ToString("dd'.'MM'.'yyyy");
                string DepTm = dtD.ToUniversalTime().ToString("HH':'mm");

                DateTime dtA = Convert.ToDateTime(ArrDatTim);
                string ArrTm = dtA.ToUniversalTime().ToString("HH':'mm");

                if (i == 0){
                    row1 = "<tr><td colspan='3'>" + DepDt + "<td></td>";
                }
                else {
                    row1 = "";
                }
                string DepDatTimOld = "";

                if (i > 0){
                    DepDatTimOld = boardList.Entries[i].Stop.Departure;

                }
                else{
                    DepDatTimOld = boardList.Entries[i].Stop.Arrival;
                }

                DateTime dtD_Old = Convert.ToDateTime(DepDatTimOld);
                if (dtD.Day > dtD_Old.Day) {
                    row1 = "<tr style='background-color:blue; color:white;'><td colspan='5'>" + DepDt + "<td></td>";
                }

                string delayMin = "";

                if (delay> 0) {
                    delayMin = " ca. +" + delay.ToString();
                }

                row2 = "<tr><td>" + toDest  + "</td><td>" + DepTm + delayMin+ "</td><td>" + platformNr + "</td></td>" + "</td><td>" + journeyCat + "</td><td>" + Capacity + "</td></td>";
                tblBody += row1 + row2;
                string htmlData = "<html><head><style>table {font-size:12px; border-collapse: collapse; width: 100 %;} ";
                htmlData +="th, td {padding: 0.25rem; text-align: left; border: 1px solid #ccc;} tbody tr:hover {background: red;color: white;}</style></head><body>";
                string html =htmlData+"<table><thead><th>Nach</th><th>Ankunft</th><th>Gleis</th><th>Mit</th><th>Belegung</th></thead>" + tblBody + "</table></body></html>";
                wbBrowserDataTable.Navigate("about:blank");
                wbBrowserDataTable.Document.OpenNew(false);
                wbBrowserDataTable.Document.Write(html);
                wbBrowserDataTable.Refresh();
            }

        }

        // wird aufgerufen falls Text Eingabe gibt.
        private void InputsListener(string clName)
        {
            string clText = "";
            listResult.Visible = true;
            listResult.Tag = clName;

            foreach (TabPage t in tabClTxt.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c.Name == clName)
                    {
                        clText = c.Text;
                        listResult.Width = c.Width;
                        listResult.Location = new Point(c.Location.X + 16, c.Location.Y + 113);
                    }
                }
            }

            if (clText != "" && !string.IsNullOrWhiteSpace(clText))
            {
                getStListe(clName, 0, 0, clText);
            }
            else
            {
                listResult.Visible = false;
            }

            if (txtFrom.Text.Length > 3 && txtTo.Text.Length > 3 && tabClTxt.SelectedTab == tabClTxt.TabPages["tabConns"])
            {
                showConnections(txtFrom.Text, txtTo.Text);
            }

            if (txtStBoard.Text.Length > 3 && tabClTxt.SelectedTab == tabClTxt.TabPages["tabStBoard"])
            {
                showStBoard(txtStBoard.Text);
            }
        }
        // Wenn auf Stationliste geklickt wird.
        private void listResult_Click(object sender, EventArgs e)
        {
            string clsName = ((Control)sender).Tag.ToString();
            string clsText = "";

            foreach (TabPage t in tabClTxt.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c.Name == clsName)
                    {
                        clsText = c.Text;
                        c.Text = listResult.SelectedItem.ToString();
                        c.Focus();
                        
                    }
                }
            }

            if (clsName=="txtFrom") {
                txtTo.Focus();
            }
            listResult.Visible = false;
            InputsListener(((Control)sender).Name);
        }

        private void btnDtDec_Click(object sender, EventArgs e)
        {
            dtmDate.Value = dtmDate.Value.AddDays(1);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            wbBrowserMap.Visible = true;
            getMap();
        }

        private void Common_txtKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter) { 
                InputsListener(((Control)sender).Name);
            }
        }


        private void ListBoxListener(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (listResult.Visible == true)
            {
                if ( e.KeyCode == Keys.Enter) {

                    string clsName = listResult.Tag.ToString();

                    foreach (TabPage t in tabClTxt.TabPages)
                    {
                        foreach (Control c in t.Controls)
                        {
                            if (c.Name == clsName)
                            {
                                c.Text = listResult.SelectedItem.ToString();
                                c.Focus();
                                listResult.Visible = false;
                            }
                        }
                    }
                    listResult.SetSelected(listResult.SelectedIndex,true);
                    
                }
               if ( e.KeyCode== Keys.Up) {

                    listResult.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    listResult.SelectedIndex++;
                }
            }
        }
        Decimal H_OldValue = 0;
        Decimal M_OldValue = 0;
        private void params_FormChanged(object sender, EventArgs e)
        {
           
            if (txtHour.Value > H_OldValue)
            {
                if (txtHour.Value >= 23)
                {

                    txtHour.ValueChanged -= params_FormChanged;
                    txtHour.Value = 0;
                    txtHour.ValueChanged += params_FormChanged;
                }
            }
            else if (txtHour.Value < H_OldValue)
            {
                if (txtHour.Value <= 0) {
                    txtHour.ValueChanged -= params_FormChanged;
                    txtHour.Value = 23;
                    txtHour.ValueChanged += params_FormChanged;
                   
                }
            }

            if (txtMin.Value > M_OldValue)
            {
                if (txtMin.Value >= 59)
                {
                    txtMin.ValueChanged -= params_FormChanged;
                    txtMin.Value = 00;
                    txtMin.ValueChanged += params_FormChanged;
                }
            }
            else if (txtMin.Value < M_OldValue)
            {
                if (txtMin.Value <= 0)
                {
                    txtMin.ValueChanged -= params_FormChanged;
                    txtMin.Value = 59;
                    txtMin.ValueChanged += params_FormChanged;
                }
            }

            H_OldValue = txtHour.Value;
            M_OldValue = txtMin.Value;

            if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabStBoard"] && !string.IsNullOrWhiteSpace(txtStBoard.Text) && txtStBoard.Text!="")
            {
               
                showStBoard(txtStBoard.Text);
            }
            else if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabConns"] && !string.IsNullOrWhiteSpace(txtFrom.Text) && !string.IsNullOrWhiteSpace(txtTo.Text))
            {
                
                showConnections(txtFrom.Text, txtTo.Text);
            }
        }

        private void chbZug_CheckedChanged(object sender, EventArgs e)
        {
            if (chbZug.Checked)
            {
                foreach (Control c in gBoxAdvSearch.Controls)
                {
                    if ((c is CheckBox) && ((CheckBox)c).Tag.ToString() == "childZug")
                    {
                        
                        ((CheckBox)c).Checked = true;
                    }

                }
            }
            else if (!chbZug.Checked)
            {
                foreach (Control c in gBoxAdvSearch.Controls)
                {
                    if ((c is CheckBox) && ((CheckBox)c).Tag.ToString() == "childZug")
                    {
                     
                        ((CheckBox)c).Checked = false;
                    }

                }
            }
        }

        // Form zurücksetzen
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in gBoxAdvSearch.Controls)
            {
                if ((c is CheckBox) || (c is RadioButton))
                {
                    ((CheckBox)c).Checked = true;
                    
                }

            }

            foreach (TabPage t in tabClTxt.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    if (c is TextBox || c is RichTextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            rdBtnNoLimit.Checked = true;
            chbBike.Checked = false;

            dtmDate.Format = DateTimePickerFormat.Custom;
            dtmDate.Value = DateTime.Now.Date;
            dtmDate.CustomFormat = "dd.MM.yyyy";

            int intHour = int.Parse(DateTime.Now.ToString("HH"));
            txtHour.Text = intHour.ToString("00");

            string strMin = DateTime.Now.ToString("mm");
            txtMin.Text = strMin;
        }
        //Fragt nach Karte
        public void getMap()
        {
            string place = "";
            if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabConns"])
            {
               place = txtFrom.Text;
             }
            else if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabStBoard"])
            {
                place = txtStBoard.Text;
            }
            string ltLnGPS = getLatlnUseGPS();
            string ltLnIP = getLocUseIP("ltLn");

            if (place != "")
            {
                SwissTransport.Transport trsp = new SwissTransport.Transport();
                SwissTransport.Stations stLst = new SwissTransport.Stations();
                stLst = trsp.GetStations(place, 0, 0);
                SwissTransport.Station st = new SwissTransport.Station();
                st = stLst.StationList[0];

                string cX = st.Coordinate.XCoordinate.ToString();
                string cY = st.Coordinate.YCoordinate.ToString();
                if (cX != "null" && cX != "null")
                {
                    cX = cX.Replace(',', '.');
                    cY = cY.Replace(',', '.');
                    string XY = cX + "," + cY;
                    browserView.Browser.LoadURL(Environment.CurrentDirectory + "/map.html?x=" + cX + "&y=" + cY);
                }
            }
            else if (ltLnGPS != "NULL")
            {
                browserView.Browser.LoadURL(Environment.CurrentDirectory + "/map.html?" + ltLnGPS);
                //browserView.Browser.LoadURL("https://www.google.com/maps/?api=1&query="+latLong + "&zoom=12&basemap=road");
            }
            else if (ltLnIP != "NULL")
            {
                browserView.Browser.LoadURL(Environment.CurrentDirectory + "/map.html?" + ltLnIP);
            }
            else
            {
                browserView.Browser.LoadURL("https://www.google.ch/maps/place/Luzern/@47.0548506,8.2122644,12z/data=!3m1!4b1!4m5!3m4!1s0x478ffa2a79547379:0xaef02ad1409952af!8m2!3d47.0501682!4d8.3093072?hl=de");
            }

        }

        public string getLatlnUseGPS()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.Start(); //started watcher
            GeoCoordinate coord = watcher.Position.Location;
            if (!watcher.Position.Location.IsUnknown)
            {
                double lat = coord.Latitude; //latitude
                double longt = coord.Longitude;  //logitude

                return "x=" + lat.ToString() + "&y=" + longt.ToString();
            }
            else
            {
                return "NULL";
            }
        }
        public string getInfo(string ipAddress)
        {
            return new WebClient().DownloadString("http://freegeoip.net/json/" + ipAddress);

        }
        public string getLocUseIP(string which)
        {
            string IPAdr = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
            if (IPAdr != "" && IPAdr != "null")
            {
                string jsonInfo = getInfo(IPAdr);
                var obj = JObject.Parse(jsonInfo);
                var city = (string)obj["city"];
                var lat = (string)obj["latitude"];
                var longt = (string)obj["longitude"];
                string latLong = "x=" + lat.ToString() + "&y=" + longt.ToString();
                if (which == "city")
                {
                    return city;
                }
                else if (which == "ltLn")
                {
                    return latLong;
                }
            }
            else
            {
                return "NULL";
            }
            return null;
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

                getStListe("NULL", lat, longt, "");
            }
            else
            {
                if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabStBoard"])
                {
                    txtStBoard.Text = getLocUseIP("city");
                }
                else if (tabClTxt.SelectedTab == tabClTxt.TabPages["tabConns"])
                {

                    txtFrom.Text = getLocUseIP("city");
                }

                getStListe("txtFrom", 0, 0, "");
            }

        }
        private void btnEmail_Click(object sender, EventArgs e)
        {

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(txtMail.Text);

                string fromEmail = "sbbtransport22@gmail.com";

                MailMessage mailMessage = new MailMessage(fromEmail, txtMail.Text, "SBB Fahrplan", wbBrowserDataTable.DocumentText);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, "sbb123456");
                mailMessage.IsBodyHtml = true;
                try
                {
                    smtpClient.Send(mailMessage);
                    lblNotifi.Text = "Es wurde gesendet.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es hat einen Fehler aufgetretten. Email konnte nicht gesendet werden");
                    Console.Write(ex.Message);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Bitte korrigieren Sie die Email Adressee");
                Console.Write(ex);
            }


        }
    }

}
