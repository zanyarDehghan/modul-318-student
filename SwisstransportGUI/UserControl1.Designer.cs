namespace SwisstransportGUI
{
    partial class UserControl1
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.gBoxAdvSearch = new System.Windows.Forms.GroupBox();
            this.chbS_sn_r = new System.Windows.Forms.CheckBox();
            this.chbIr = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnLimit = new System.Windows.Forms.RadioButton();
            this.rdBtnNoLimit = new System.Windows.Forms.RadioButton();
            this.chbEc_ic = new System.Windows.Forms.CheckBox();
            this.chbShip = new System.Windows.Forms.CheckBox();
            this.chbIce_tgv_rj = new System.Windows.Forms.CheckBox();
            this.chbCableway = new System.Windows.Forms.CheckBox();
            this.chbArz_ext = new System.Windows.Forms.CheckBox();
            this.chbBike = new System.Windows.Forms.CheckBox();
            this.chbZug = new System.Windows.Forms.CheckBox();
            this.lblVia = new System.Windows.Forms.Label();
            this.chbTramway_underground = new System.Windows.Forms.CheckBox();
            this.chbBus = new System.Windows.Forms.CheckBox();
            this.btnNearst = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.btnDtDec = new System.Windows.Forms.Button();
            this.btnDtInc = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.NumericUpDown();
            this.txtMin = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.wbBrowserMap = new System.Windows.Forms.WebBrowser();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStBoard = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabClTxt = new System.Windows.Forms.TabControl();
            this.tabConns = new System.Windows.Forms.TabPage();
            this.tabStBoard = new System.Windows.Forms.TabPage();
            this.wbBrowserDataTable = new System.Windows.Forms.WebBrowser();
            this.btnEmail = new System.Windows.Forms.Button();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.lblNotifi = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.gBoxAdvSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).BeginInit();
            this.tabClTxt.SuspendLayout();
            this.tabConns.SuspendLayout();
            this.tabStBoard.SuspendLayout();
            this.pnlWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gBoxAdvSearch
            // 
            this.gBoxAdvSearch.Controls.Add(this.chbS_sn_r);
            this.gBoxAdvSearch.Controls.Add(this.btnReset);
            this.gBoxAdvSearch.Controls.Add(this.chbIr);
            this.gBoxAdvSearch.Controls.Add(this.groupBox2);
            this.gBoxAdvSearch.Controls.Add(this.chbEc_ic);
            this.gBoxAdvSearch.Controls.Add(this.chbShip);
            this.gBoxAdvSearch.Controls.Add(this.chbIce_tgv_rj);
            this.gBoxAdvSearch.Controls.Add(this.chbCableway);
            this.gBoxAdvSearch.Controls.Add(this.chbArz_ext);
            this.gBoxAdvSearch.Controls.Add(this.chbBike);
            this.gBoxAdvSearch.Controls.Add(this.chbZug);
            this.gBoxAdvSearch.Controls.Add(this.lblVia);
            this.gBoxAdvSearch.Controls.Add(this.chbTramway_underground);
            this.gBoxAdvSearch.Controls.Add(this.chbBus);
            this.gBoxAdvSearch.Location = new System.Drawing.Point(33, 203);
            this.gBoxAdvSearch.Name = "gBoxAdvSearch";
            this.gBoxAdvSearch.Size = new System.Drawing.Size(266, 333);
            this.gBoxAdvSearch.TabIndex = 28;
            this.gBoxAdvSearch.TabStop = false;
            this.gBoxAdvSearch.Text = "Ertweiterte Suche";
            // 
            // chbS_sn_r
            // 
            this.chbS_sn_r.AutoSize = true;
            this.chbS_sn_r.Checked = true;
            this.chbS_sn_r.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbS_sn_r.Location = new System.Drawing.Point(40, 121);
            this.chbS_sn_r.Name = "chbS_sn_r";
            this.chbS_sn_r.Size = new System.Drawing.Size(66, 17);
            this.chbS_sn_r.TabIndex = 5;
            this.chbS_sn_r.Tag = "childZug";
            this.chbS_sn_r.Text = "S/SN/R";
            this.chbS_sn_r.UseVisualStyleBackColor = true;
            // 
            // chbIr
            // 
            this.chbIr.AutoSize = true;
            this.chbIr.Checked = true;
            this.chbIr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIr.Location = new System.Drawing.Point(40, 98);
            this.chbIr.Name = "chbIr";
            this.chbIr.Size = new System.Drawing.Size(37, 17);
            this.chbIr.TabIndex = 4;
            this.chbIr.Tag = "childZug";
            this.chbIr.Text = "IR";
            this.chbIr.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnLimit);
            this.groupBox2.Controls.Add(this.rdBtnNoLimit);
            this.groupBox2.Location = new System.Drawing.Point(6, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barrierefreie Verbindung";
            // 
            // rdBtnLimit
            // 
            this.rdBtnLimit.AutoSize = true;
            this.rdBtnLimit.Location = new System.Drawing.Point(16, 51);
            this.rdBtnLimit.Name = "rdBtnLimit";
            this.rdBtnLimit.Size = new System.Drawing.Size(113, 17);
            this.rdBtnLimit.TabIndex = 16;
            this.rdBtnLimit.Text = "Mit Einschränkung";
            this.rdBtnLimit.UseVisualStyleBackColor = true;
            // 
            // rdBtnNoLimit
            // 
            this.rdBtnNoLimit.AutoSize = true;
            this.rdBtnNoLimit.Checked = true;
            this.rdBtnNoLimit.Location = new System.Drawing.Point(16, 28);
            this.rdBtnNoLimit.Name = "rdBtnNoLimit";
            this.rdBtnNoLimit.Size = new System.Drawing.Size(126, 17);
            this.rdBtnNoLimit.TabIndex = 15;
            this.rdBtnNoLimit.TabStop = true;
            this.rdBtnNoLimit.Text = "Keine Einschränkung";
            this.rdBtnNoLimit.UseVisualStyleBackColor = true;
            // 
            // chbEc_ic
            // 
            this.chbEc_ic.AutoSize = true;
            this.chbEc_ic.Checked = true;
            this.chbEc_ic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEc_ic.Location = new System.Drawing.Point(40, 75);
            this.chbEc_ic.Name = "chbEc_ic";
            this.chbEc_ic.Size = new System.Drawing.Size(55, 17);
            this.chbEc_ic.TabIndex = 3;
            this.chbEc_ic.Tag = "childZug";
            this.chbEc_ic.Text = "EC/IC";
            this.chbEc_ic.UseVisualStyleBackColor = true;
            // 
            // chbShip
            // 
            this.chbShip.AutoSize = true;
            this.chbShip.Checked = true;
            this.chbShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShip.Location = new System.Drawing.Point(173, 62);
            this.chbShip.Name = "chbShip";
            this.chbShip.Size = new System.Drawing.Size(53, 17);
            this.chbShip.TabIndex = 6;
            this.chbShip.Tag = "anotherChb";
            this.chbShip.Text = "Schiff";
            this.chbShip.UseVisualStyleBackColor = true;
            // 
            // chbIce_tgv_rj
            // 
            this.chbIce_tgv_rj.AutoSize = true;
            this.chbIce_tgv_rj.Checked = true;
            this.chbIce_tgv_rj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIce_tgv_rj.Location = new System.Drawing.Point(40, 52);
            this.chbIce_tgv_rj.Name = "chbIce_tgv_rj";
            this.chbIce_tgv_rj.Size = new System.Drawing.Size(88, 17);
            this.chbIce_tgv_rj.TabIndex = 2;
            this.chbIce_tgv_rj.Tag = "childZug";
            this.chbIce_tgv_rj.Text = "ICE/TGV/RJ";
            this.chbIce_tgv_rj.UseVisualStyleBackColor = true;
            // 
            // chbCableway
            // 
            this.chbCableway.AutoSize = true;
            this.chbCableway.Checked = true;
            this.chbCableway.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCableway.Location = new System.Drawing.Point(173, 85);
            this.chbCableway.Name = "chbCableway";
            this.chbCableway.Size = new System.Drawing.Size(67, 17);
            this.chbCableway.TabIndex = 7;
            this.chbCableway.Tag = "anotherChb";
            this.chbCableway.Text = "Seilbahn";
            this.chbCableway.UseVisualStyleBackColor = true;
            // 
            // chbArz_ext
            // 
            this.chbArz_ext.AutoSize = true;
            this.chbArz_ext.Checked = true;
            this.chbArz_ext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbArz_ext.Location = new System.Drawing.Point(40, 144);
            this.chbArz_ext.Name = "chbArz_ext";
            this.chbArz_ext.Size = new System.Drawing.Size(116, 17);
            this.chbArz_ext.TabIndex = 1;
            this.chbArz_ext.Tag = "childZug";
            this.chbArz_ext.Text = "Autoreise/Extrazug";
            this.chbArz_ext.UseVisualStyleBackColor = true;
            // 
            // chbBike
            // 
            this.chbBike.AutoSize = true;
            this.chbBike.Location = new System.Drawing.Point(12, 181);
            this.chbBike.Name = "chbBike";
            this.chbBike.Size = new System.Drawing.Size(141, 17);
            this.chbBike.TabIndex = 11;
            this.chbBike.Tag = "";
            this.chbBike.Text = "Velomitnahme (Schweiz)";
            this.chbBike.UseVisualStyleBackColor = true;
            // 
            // chbZug
            // 
            this.chbZug.AutoSize = true;
            this.chbZug.Checked = true;
            this.chbZug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbZug.Location = new System.Drawing.Point(28, 29);
            this.chbZug.Name = "chbZug";
            this.chbZug.Size = new System.Drawing.Size(45, 17);
            this.chbZug.TabIndex = 0;
            this.chbZug.Text = "Zug";
            this.chbZug.UseVisualStyleBackColor = true;
            this.chbZug.CheckedChanged += new System.EventHandler(this.chbZug_CheckedChanged);
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.Location = new System.Drawing.Point(9, 29);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(0, 13);
            this.lblVia.TabIndex = 6;
            // 
            // chbTramway_underground
            // 
            this.chbTramway_underground.AutoSize = true;
            this.chbTramway_underground.Checked = true;
            this.chbTramway_underground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTramway_underground.Location = new System.Drawing.Point(173, 108);
            this.chbTramway_underground.Name = "chbTramway_underground";
            this.chbTramway_underground.Size = new System.Drawing.Size(82, 17);
            this.chbTramway_underground.TabIndex = 8;
            this.chbTramway_underground.Tag = "anotherChb";
            this.chbTramway_underground.Text = "Tram/Metro";
            this.chbTramway_underground.UseVisualStyleBackColor = true;
            // 
            // chbBus
            // 
            this.chbBus.AutoSize = true;
            this.chbBus.Checked = true;
            this.chbBus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBus.Location = new System.Drawing.Point(173, 39);
            this.chbBus.Name = "chbBus";
            this.chbBus.Size = new System.Drawing.Size(44, 17);
            this.chbBus.TabIndex = 9;
            this.chbBus.Tag = "anotherChb";
            this.chbBus.Text = "Bus";
            this.chbBus.UseVisualStyleBackColor = true;
            // 
            // btnNearst
            // 
            this.btnNearst.Location = new System.Drawing.Point(307, 71);
            this.btnNearst.Name = "btnNearst";
            this.btnNearst.Size = new System.Drawing.Size(75, 23);
            this.btnNearst.TabIndex = 27;
            this.btnNearst.Text = "Nähste ÖV";
            this.btnNearst.UseVisualStyleBackColor = true;
            this.btnNearst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(307, 100);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 26;
            this.btnMap.Text = "Karte";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(14, 10);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(263, 41);
            this.lblTitel.TabIndex = 25;
            this.lblTitel.Text = "Swiss Transport";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(2, 37);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "Nach:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(2, 10);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "Von:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(56, 33);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(205, 20);
            this.txtTo.TabIndex = 20;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(56, 7);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(205, 20);
            this.txtFrom.TabIndex = 19;
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(-93, 533);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(120, 95);
            this.listResult.TabIndex = 31;
            this.listResult.Visible = false;
            this.listResult.Click += new System.EventHandler(this.listResult_Click);
            // 
            // dtmDate
            // 
            this.dtmDate.Location = new System.Drawing.Point(55, 177);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(104, 20);
            this.dtmDate.TabIndex = 21;
            // 
            // btnDtDec
            // 
            this.btnDtDec.Location = new System.Drawing.Point(33, 176);
            this.btnDtDec.Name = "btnDtDec";
            this.btnDtDec.Size = new System.Drawing.Size(21, 23);
            this.btnDtDec.TabIndex = 33;
            this.btnDtDec.Text = "<";
            this.btnDtDec.UseVisualStyleBackColor = true;
            // 
            // btnDtInc
            // 
            this.btnDtInc.Location = new System.Drawing.Point(160, 176);
            this.btnDtInc.Name = "btnDtInc";
            this.btnDtInc.Size = new System.Drawing.Size(21, 23);
            this.btnDtInc.TabIndex = 34;
            this.btnDtInc.Text = ">";
            this.btnDtInc.UseVisualStyleBackColor = true;
            this.btnDtInc.Click += new System.EventHandler(this.btnDtDec_Click);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(181, 177);
            this.txtHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(44, 20);
            this.txtHour.TabIndex = 35;
            this.txtHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMin
            // 
            this.txtMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtMin.Location = new System.Drawing.Point(224, 177);
            this.txtMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(43, 20);
            this.txtMin.TabIndex = 36;
            // 
            // wbBrowserMap
            // 
            this.wbBrowserMap.Location = new System.Drawing.Point(389, 258);
            this.wbBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowserMap.Name = "wbBrowserMap";
            this.wbBrowserMap.Size = new System.Drawing.Size(467, 255);
            this.wbBrowserMap.TabIndex = 41;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(6, 17);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 13);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station:";
            // 
            // txtStBoard
            // 
            this.txtStBoard.Location = new System.Drawing.Point(55, 14);
            this.txtStBoard.Name = "txtStBoard";
            this.txtStBoard.Size = new System.Drawing.Size(207, 20);
            this.txtStBoard.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(307, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 22);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tabClTxt
            // 
            this.tabClTxt.Controls.Add(this.tabConns);
            this.tabClTxt.Controls.Add(this.tabStBoard);
            this.tabClTxt.Location = new System.Drawing.Point(12, 71);
            this.tabClTxt.Name = "tabClTxt";
            this.tabClTxt.SelectedIndex = 0;
            this.tabClTxt.Size = new System.Drawing.Size(287, 100);
            this.tabClTxt.TabIndex = 49;
            // 
            // tabConns
            // 
            this.tabConns.Controls.Add(this.lblTo);
            this.tabConns.Controls.Add(this.lblFrom);
            this.tabConns.Controls.Add(this.txtFrom);
            this.tabConns.Controls.Add(this.txtTo);
            this.tabConns.Location = new System.Drawing.Point(4, 22);
            this.tabConns.Name = "tabConns";
            this.tabConns.Padding = new System.Windows.Forms.Padding(3);
            this.tabConns.Size = new System.Drawing.Size(279, 74);
            this.tabConns.TabIndex = 0;
            this.tabConns.Text = "Fahrplan";
            this.tabConns.UseVisualStyleBackColor = true;
            // 
            // tabStBoard
            // 
            this.tabStBoard.Controls.Add(this.txtStBoard);
            this.tabStBoard.Controls.Add(this.lblStation);
            this.tabStBoard.Location = new System.Drawing.Point(4, 22);
            this.tabStBoard.Name = "tabStBoard";
            this.tabStBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStBoard.Size = new System.Drawing.Size(279, 74);
            this.tabStBoard.TabIndex = 1;
            this.tabStBoard.Text = "Abfahrtstafel";
            this.tabStBoard.UseVisualStyleBackColor = true;
            // 
            // wbBrowserDataTable
            // 
            this.wbBrowserDataTable.Location = new System.Drawing.Point(-1, 32);
            this.wbBrowserDataTable.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowserDataTable.Name = "wbBrowserDataTable";
            this.wbBrowserDataTable.Size = new System.Drawing.Size(474, 186);
            this.wbBrowserDataTable.TabIndex = 50;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(387, 3);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 51;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // pnlWeb
            // 
            this.pnlWeb.Controls.Add(this.lblNotifi);
            this.pnlWeb.Controls.Add(this.txtMail);
            this.pnlWeb.Controls.Add(this.btnEmail);
            this.pnlWeb.Controls.Add(this.wbBrowserDataTable);
            this.pnlWeb.Location = new System.Drawing.Point(389, 28);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(467, 221);
            this.pnlWeb.TabIndex = 52;
            this.pnlWeb.Visible = false;
            // 
            // lblNotifi
            // 
            this.lblNotifi.AutoSize = true;
            this.lblNotifi.Location = new System.Drawing.Point(4, 12);
            this.lblNotifi.Name = "lblNotifi";
            this.lblNotifi.Size = new System.Drawing.Size(0, 13);
            this.lblNotifi.TabIndex = 53;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(166, 6);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(215, 20);
            this.txtMail.TabIndex = 52;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWeb);
            this.Controls.Add(this.tabClTxt);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.wbBrowserMap);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnDtInc);
            this.Controls.Add(this.btnDtDec);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.gBoxAdvSearch);
            this.Controls.Add(this.btnNearst);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dtmDate);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(876, 565);
            this.gBoxAdvSearch.ResumeLayout(false);
            this.gBoxAdvSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin)).EndInit();
            this.tabClTxt.ResumeLayout(false);
            this.tabConns.ResumeLayout(false);
            this.tabConns.PerformLayout();
            this.tabStBoard.ResumeLayout(false);
            this.tabStBoard.PerformLayout();
            this.pnlWeb.ResumeLayout(false);
            this.pnlWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gBoxAdvSearch;
        private System.Windows.Forms.CheckBox chbS_sn_r;
        private System.Windows.Forms.CheckBox chbIr;
        private System.Windows.Forms.CheckBox chbEc_ic;
        private System.Windows.Forms.CheckBox chbIce_tgv_rj;
        private System.Windows.Forms.CheckBox chbArz_ext;
        private System.Windows.Forms.CheckBox chbZug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnLimit;
        private System.Windows.Forms.RadioButton rdBtnNoLimit;
        private System.Windows.Forms.CheckBox chbShip;
        private System.Windows.Forms.CheckBox chbCableway;
        private System.Windows.Forms.CheckBox chbBike;
        private System.Windows.Forms.Label lblVia;
        private System.Windows.Forms.CheckBox chbTramway_underground;
        private System.Windows.Forms.CheckBox chbBus;
        private System.Windows.Forms.Button btnNearst;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Button btnDtDec;
        private System.Windows.Forms.Button btnDtInc;
        private System.Windows.Forms.NumericUpDown txtHour;
        private System.Windows.Forms.NumericUpDown txtMin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.WebBrowser wbBrowserMap;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStBoard;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabClTxt;
        private System.Windows.Forms.TabPage tabConns;
        private System.Windows.Forms.TabPage tabStBoard;
        private System.Windows.Forms.WebBrowser wbBrowserDataTable;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Panel pnlWeb;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblNotifi;
    }
}
