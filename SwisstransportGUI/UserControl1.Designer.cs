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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbSSnR = new System.Windows.Forms.CheckBox();
            this.chbIr = new System.Windows.Forms.CheckBox();
            this.chbEcIc = new System.Windows.Forms.CheckBox();
            this.chbICE = new System.Windows.Forms.CheckBox();
            this.chbAutoExt = new System.Windows.Forms.CheckBox();
            this.chbZug = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdBtnNoLimit = new System.Windows.Forms.RadioButton();
            this.lblBarrier = new System.Windows.Forms.Label();
            this.chbSchiff = new System.Windows.Forms.CheckBox();
            this.chbSeilbahn = new System.Windows.Forms.CheckBox();
            this.chbVelo = new System.Windows.Forms.CheckBox();
            this.lblVia = new System.Windows.Forms.Label();
            this.chbTram = new System.Windows.Forms.CheckBox();
            this.chbBus = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNearst = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnDtInc = new System.Windows.Forms.Button();
            this.btnDtDec = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(307, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.chbSchiff);
            this.groupBox3.Controls.Add(this.chbSeilbahn);
            this.groupBox3.Controls.Add(this.chbVelo);
            this.groupBox3.Controls.Add(this.lblVia);
            this.groupBox3.Controls.Add(this.chbTram);
            this.groupBox3.Controls.Add(this.chbBus);
            this.groupBox3.Location = new System.Drawing.Point(39, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 418);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ertweiterte Suche";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbSSnR);
            this.groupBox1.Controls.Add(this.chbIr);
            this.groupBox1.Controls.Add(this.chbEcIc);
            this.groupBox1.Controls.Add(this.chbICE);
            this.groupBox1.Controls.Add(this.chbAutoExt);
            this.groupBox1.Controls.Add(this.chbZug);
            this.groupBox1.Location = new System.Drawing.Point(24, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chbSSnR
            // 
            this.chbSSnR.AutoSize = true;
            this.chbSSnR.Checked = true;
            this.chbSSnR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSSnR.Location = new System.Drawing.Point(19, 112);
            this.chbSSnR.Name = "chbSSnR";
            this.chbSSnR.Size = new System.Drawing.Size(66, 17);
            this.chbSSnR.TabIndex = 5;
            this.chbSSnR.Text = "S/SN/R";
            this.chbSSnR.UseVisualStyleBackColor = true;
            // 
            // chbIr
            // 
            this.chbIr.AutoSize = true;
            this.chbIr.Checked = true;
            this.chbIr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIr.Location = new System.Drawing.Point(19, 89);
            this.chbIr.Name = "chbIr";
            this.chbIr.Size = new System.Drawing.Size(37, 17);
            this.chbIr.TabIndex = 4;
            this.chbIr.Text = "IR";
            this.chbIr.UseVisualStyleBackColor = true;
            // 
            // chbEcIc
            // 
            this.chbEcIc.AutoSize = true;
            this.chbEcIc.Checked = true;
            this.chbEcIc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEcIc.Location = new System.Drawing.Point(19, 66);
            this.chbEcIc.Name = "chbEcIc";
            this.chbEcIc.Size = new System.Drawing.Size(55, 17);
            this.chbEcIc.TabIndex = 3;
            this.chbEcIc.Text = "EC/IC";
            this.chbEcIc.UseVisualStyleBackColor = true;
            // 
            // chbICE
            // 
            this.chbICE.AutoSize = true;
            this.chbICE.Checked = true;
            this.chbICE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbICE.Location = new System.Drawing.Point(19, 43);
            this.chbICE.Name = "chbICE";
            this.chbICE.Size = new System.Drawing.Size(88, 17);
            this.chbICE.TabIndex = 2;
            this.chbICE.Text = "ICE/TGV/RJ";
            this.chbICE.UseVisualStyleBackColor = true;
            // 
            // chbAutoExt
            // 
            this.chbAutoExt.AutoSize = true;
            this.chbAutoExt.Checked = true;
            this.chbAutoExt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoExt.Location = new System.Drawing.Point(19, 135);
            this.chbAutoExt.Name = "chbAutoExt";
            this.chbAutoExt.Size = new System.Drawing.Size(116, 17);
            this.chbAutoExt.TabIndex = 1;
            this.chbAutoExt.Text = "Autoreise/Extrazug";
            this.chbAutoExt.UseVisualStyleBackColor = true;
            // 
            // chbZug
            // 
            this.chbZug.AutoSize = true;
            this.chbZug.Checked = true;
            this.chbZug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbZug.Location = new System.Drawing.Point(7, 20);
            this.chbZug.Name = "chbZug";
            this.chbZug.Size = new System.Drawing.Size(45, 17);
            this.chbZug.TabIndex = 0;
            this.chbZug.Text = "Zug";
            this.chbZug.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rdBtnNoLimit);
            this.groupBox2.Controls.Add(this.lblBarrier);
            this.groupBox2.Location = new System.Drawing.Point(12, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mit Einschränkung";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdBtnNoLimit
            // 
            this.rdBtnNoLimit.AutoSize = true;
            this.rdBtnNoLimit.Location = new System.Drawing.Point(19, 44);
            this.rdBtnNoLimit.Name = "rdBtnNoLimit";
            this.rdBtnNoLimit.Size = new System.Drawing.Size(126, 17);
            this.rdBtnNoLimit.TabIndex = 15;
            this.rdBtnNoLimit.TabStop = true;
            this.rdBtnNoLimit.Text = "Keine Einschränkung";
            this.rdBtnNoLimit.UseVisualStyleBackColor = true;
            // 
            // lblBarrier
            // 
            this.lblBarrier.AutoSize = true;
            this.lblBarrier.Location = new System.Drawing.Point(6, 16);
            this.lblBarrier.Name = "lblBarrier";
            this.lblBarrier.Size = new System.Drawing.Size(120, 13);
            this.lblBarrier.TabIndex = 14;
            this.lblBarrier.Text = "Barrierefreie Verbindung";
            // 
            // chbSchiff
            // 
            this.chbSchiff.AutoSize = true;
            this.chbSchiff.Checked = true;
            this.chbSchiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSchiff.Location = new System.Drawing.Point(180, 88);
            this.chbSchiff.Name = "chbSchiff";
            this.chbSchiff.Size = new System.Drawing.Size(53, 17);
            this.chbSchiff.TabIndex = 6;
            this.chbSchiff.Text = "Schiff";
            this.chbSchiff.UseVisualStyleBackColor = true;
            // 
            // chbSeilbahn
            // 
            this.chbSeilbahn.AutoSize = true;
            this.chbSeilbahn.Checked = true;
            this.chbSeilbahn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSeilbahn.Location = new System.Drawing.Point(180, 111);
            this.chbSeilbahn.Name = "chbSeilbahn";
            this.chbSeilbahn.Size = new System.Drawing.Size(67, 17);
            this.chbSeilbahn.TabIndex = 7;
            this.chbSeilbahn.Text = "Seilbahn";
            this.chbSeilbahn.UseVisualStyleBackColor = true;
            // 
            // chbVelo
            // 
            this.chbVelo.AutoSize = true;
            this.chbVelo.Location = new System.Drawing.Point(18, 226);
            this.chbVelo.Name = "chbVelo";
            this.chbVelo.Size = new System.Drawing.Size(141, 17);
            this.chbVelo.TabIndex = 11;
            this.chbVelo.Text = "Velomitnahme (Schweiz)";
            this.chbVelo.UseVisualStyleBackColor = true;
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.Location = new System.Drawing.Point(9, 29);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(76, 13);
            this.lblVia.TabIndex = 6;
            this.lblVia.Text = "Verkehrsmittel:";
            // 
            // chbTram
            // 
            this.chbTram.AutoSize = true;
            this.chbTram.Checked = true;
            this.chbTram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTram.Location = new System.Drawing.Point(180, 134);
            this.chbTram.Name = "chbTram";
            this.chbTram.Size = new System.Drawing.Size(82, 17);
            this.chbTram.TabIndex = 8;
            this.chbTram.Text = "Tram/Metro";
            this.chbTram.UseVisualStyleBackColor = true;
            // 
            // chbBus
            // 
            this.chbBus.AutoSize = true;
            this.chbBus.Checked = true;
            this.chbBus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBus.Location = new System.Drawing.Point(180, 65);
            this.chbBus.Name = "chbBus";
            this.chbBus.Size = new System.Drawing.Size(44, 17);
            this.chbBus.TabIndex = 9;
            this.chbBus.Text = "Bus";
            this.chbBus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 306);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnNearst
            // 
            this.btnNearst.Location = new System.Drawing.Point(307, 60);
            this.btnNearst.Name = "btnNearst";
            this.btnNearst.Size = new System.Drawing.Size(75, 23);
            this.btnNearst.TabIndex = 27;
            this.btnNearst.Text = "Nähste ÖV";
            this.btnNearst.UseVisualStyleBackColor = true;
            this.btnNearst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(307, 88);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 26;
            this.btnMap.Text = "Karte";
            this.btnMap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Swiss Transport";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(31, 93);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "Nach:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(31, 67);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "Von:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(95, 90);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(205, 20);
            this.txtTo.TabIndex = 20;
            this.txtTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyUp);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(95, 64);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(205, 20);
            this.txtFrom.TabIndex = 19;
            this.txtFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyUp);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(466, 44);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(120, 95);
            this.listResult.TabIndex = 31;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listResult_SelectedIndexChanged);
            // 
            // dtmDate
            // 
            this.dtmDate.Location = new System.Drawing.Point(94, 119);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(104, 20);
            this.dtmDate.TabIndex = 21;
            this.dtmDate.ValueChanged += new System.EventHandler(this.dtmDate_ValueChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(243, 120);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(43, 20);
            this.txtTime.TabIndex = 32;
            this.txtTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDtInc
            // 
            this.btnDtInc.Location = new System.Drawing.Point(70, 118);
            this.btnDtInc.Name = "btnDtInc";
            this.btnDtInc.Size = new System.Drawing.Size(21, 24);
            this.btnDtInc.TabIndex = 33;
            this.btnDtInc.Text = "<";
            this.btnDtInc.UseVisualStyleBackColor = true;
            // 
            // btnDtDec
            // 
            this.btnDtDec.Location = new System.Drawing.Point(204, 117);
            this.btnDtDec.Name = "btnDtDec";
            this.btnDtDec.Size = new System.Drawing.Size(21, 24);
            this.btnDtDec.TabIndex = 34;
            this.btnDtDec.Text = ">";
            this.btnDtDec.UseVisualStyleBackColor = true;
            this.btnDtDec.Click += new System.EventHandler(this.btnDtDec_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDtDec);
            this.Controls.Add(this.btnDtInc);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNearst);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1165, 675);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbSSnR;
        private System.Windows.Forms.CheckBox chbIr;
        private System.Windows.Forms.CheckBox chbEcIc;
        private System.Windows.Forms.CheckBox chbICE;
        private System.Windows.Forms.CheckBox chbAutoExt;
        private System.Windows.Forms.CheckBox chbZug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdBtnNoLimit;
        private System.Windows.Forms.Label lblBarrier;
        private System.Windows.Forms.CheckBox chbSchiff;
        private System.Windows.Forms.CheckBox chbSeilbahn;
        private System.Windows.Forms.CheckBox chbVelo;
        private System.Windows.Forms.Label lblVia;
        private System.Windows.Forms.CheckBox chbTram;
        private System.Windows.Forms.CheckBox chbBus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNearst;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnDtInc;
        private System.Windows.Forms.Button btnDtDec;
    }
}
