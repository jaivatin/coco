namespace Coco.UI
{
    partial class FrmSettings
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.lblGeneral6 = new System.Windows.Forms.Label();
            this.lblGeneral3 = new System.Windows.Forms.Label();
            this.lblGeneral5 = new System.Windows.Forms.Label();
            this.lblGeneral2 = new System.Windows.Forms.Label();
            this.dtpMeetingWeekend = new System.Windows.Forms.DateTimePicker();
            this.cmbMeetingWeekend = new System.Windows.Forms.ComboBox();
            this.lblGeneral4 = new System.Windows.Forms.Label();
            this.lblGeneral1 = new System.Windows.Forms.Label();
            this.dtpMeetingMidweek = new System.Windows.Forms.DateTimePicker();
            this.cmbMeetingMidweek = new System.Windows.Forms.ComboBox();
            this.tpSongs = new System.Windows.Forms.TabPage();
            this.btnSongUpdate = new System.Windows.Forms.Button();
            this.nudSongNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblSongNumber = new System.Windows.Forms.Label();
            this.tbxSongName = new System.Windows.Forms.TextBox();
            this.btnSongRemove = new System.Windows.Forms.Button();
            this.btnSongAdd = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(375, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(481, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Zurücksetzen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpGeneral);
            this.tabMain.Controls.Add(this.tpSongs);
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(578, 293);
            this.tabMain.TabIndex = 3;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.lblGeneral6);
            this.tpGeneral.Controls.Add(this.lblGeneral3);
            this.tpGeneral.Controls.Add(this.lblGeneral5);
            this.tpGeneral.Controls.Add(this.lblGeneral2);
            this.tpGeneral.Controls.Add(this.dtpMeetingWeekend);
            this.tpGeneral.Controls.Add(this.cmbMeetingWeekend);
            this.tpGeneral.Controls.Add(this.lblGeneral4);
            this.tpGeneral.Controls.Add(this.lblGeneral1);
            this.tpGeneral.Controls.Add(this.dtpMeetingMidweek);
            this.tpGeneral.Controls.Add(this.cmbMeetingMidweek);
            this.tpGeneral.Location = new System.Drawing.Point(4, 24);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(570, 265);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Allgemein";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // lblGeneral6
            // 
            this.lblGeneral6.AutoSize = true;
            this.lblGeneral6.Location = new System.Drawing.Point(467, 38);
            this.lblGeneral6.Name = "lblGeneral6";
            this.lblGeneral6.Size = new System.Drawing.Size(33, 15);
            this.lblGeneral6.TabIndex = 11;
            this.lblGeneral6.Text = "statt.";
            // 
            // lblGeneral3
            // 
            this.lblGeneral3.AutoSize = true;
            this.lblGeneral3.Location = new System.Drawing.Point(467, 9);
            this.lblGeneral3.Name = "lblGeneral3";
            this.lblGeneral3.Size = new System.Drawing.Size(33, 15);
            this.lblGeneral3.TabIndex = 10;
            this.lblGeneral3.Text = "statt.";
            // 
            // lblGeneral5
            // 
            this.lblGeneral5.AutoSize = true;
            this.lblGeneral5.Location = new System.Drawing.Point(380, 38);
            this.lblGeneral5.Name = "lblGeneral5";
            this.lblGeneral5.Size = new System.Drawing.Size(25, 15);
            this.lblGeneral5.TabIndex = 9;
            this.lblGeneral5.Text = "um";
            // 
            // lblGeneral2
            // 
            this.lblGeneral2.AutoSize = true;
            this.lblGeneral2.Location = new System.Drawing.Point(380, 9);
            this.lblGeneral2.Name = "lblGeneral2";
            this.lblGeneral2.Size = new System.Drawing.Size(25, 15);
            this.lblGeneral2.TabIndex = 8;
            this.lblGeneral2.Text = "um";
            // 
            // dtpMeetingWeekend
            // 
            this.dtpMeetingWeekend.CustomFormat = "HH:mm";
            this.dtpMeetingWeekend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMeetingWeekend.Location = new System.Drawing.Point(411, 35);
            this.dtpMeetingWeekend.Name = "dtpMeetingWeekend";
            this.dtpMeetingWeekend.ShowUpDown = true;
            this.dtpMeetingWeekend.Size = new System.Drawing.Size(50, 23);
            this.dtpMeetingWeekend.TabIndex = 7;
            this.dtpMeetingWeekend.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // cmbMeetingWeekend
            // 
            this.cmbMeetingWeekend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeetingWeekend.FormattingEnabled = true;
            this.cmbMeetingWeekend.Location = new System.Drawing.Point(274, 35);
            this.cmbMeetingWeekend.Name = "cmbMeetingWeekend";
            this.cmbMeetingWeekend.Size = new System.Drawing.Size(100, 23);
            this.cmbMeetingWeekend.TabIndex = 6;
            // 
            // lblGeneral4
            // 
            this.lblGeneral4.AutoSize = true;
            this.lblGeneral4.Location = new System.Drawing.Point(6, 38);
            this.lblGeneral4.Name = "lblGeneral4";
            this.lblGeneral4.Size = new System.Drawing.Size(262, 15);
            this.lblGeneral4.TabIndex = 3;
            this.lblGeneral4.Text = "Die Zusammenkunft am Wochenende findet am";
            // 
            // lblGeneral1
            // 
            this.lblGeneral1.AutoSize = true;
            this.lblGeneral1.Location = new System.Drawing.Point(8, 9);
            this.lblGeneral1.Name = "lblGeneral1";
            this.lblGeneral1.Size = new System.Drawing.Size(260, 15);
            this.lblGeneral1.TabIndex = 2;
            this.lblGeneral1.Text = "Die Zusammenkunft unter der Woche findet am";
            // 
            // dtpMeetingMidweek
            // 
            this.dtpMeetingMidweek.CustomFormat = "HH:mm";
            this.dtpMeetingMidweek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMeetingMidweek.Location = new System.Drawing.Point(411, 6);
            this.dtpMeetingMidweek.Name = "dtpMeetingMidweek";
            this.dtpMeetingMidweek.ShowUpDown = true;
            this.dtpMeetingMidweek.Size = new System.Drawing.Size(50, 23);
            this.dtpMeetingMidweek.TabIndex = 1;
            this.dtpMeetingMidweek.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // cmbMeetingMidweek
            // 
            this.cmbMeetingMidweek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeetingMidweek.FormattingEnabled = true;
            this.cmbMeetingMidweek.Location = new System.Drawing.Point(274, 6);
            this.cmbMeetingMidweek.Name = "cmbMeetingMidweek";
            this.cmbMeetingMidweek.Size = new System.Drawing.Size(100, 23);
            this.cmbMeetingMidweek.TabIndex = 0;
            // 
            // tpSongs
            // 
            this.tpSongs.Controls.Add(this.btnSongUpdate);
            this.tpSongs.Controls.Add(this.nudSongNumber);
            this.tpSongs.Controls.Add(this.lblSongName);
            this.tpSongs.Controls.Add(this.lblSongNumber);
            this.tpSongs.Controls.Add(this.tbxSongName);
            this.tpSongs.Controls.Add(this.btnSongRemove);
            this.tpSongs.Controls.Add(this.btnSongAdd);
            this.tpSongs.Controls.Add(this.lstSongs);
            this.tpSongs.Location = new System.Drawing.Point(4, 24);
            this.tpSongs.Name = "tpSongs";
            this.tpSongs.Size = new System.Drawing.Size(570, 265);
            this.tpSongs.TabIndex = 1;
            this.tpSongs.Text = "Lieder";
            this.tpSongs.UseVisualStyleBackColor = true;
            // 
            // btnSongUpdate
            // 
            this.btnSongUpdate.Location = new System.Drawing.Point(287, 97);
            this.btnSongUpdate.Name = "btnSongUpdate";
            this.btnSongUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnSongUpdate.TabIndex = 8;
            this.btnSongUpdate.Text = "Aktualisieren";
            this.btnSongUpdate.UseVisualStyleBackColor = true;
            this.btnSongUpdate.Click += new System.EventHandler(this.BtnSongUpdate_Click);
            // 
            // nudSongNumber
            // 
            this.nudSongNumber.Location = new System.Drawing.Point(287, 21);
            this.nudSongNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSongNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSongNumber.Name = "nudSongNumber";
            this.nudSongNumber.Size = new System.Drawing.Size(278, 23);
            this.nudSongNumber.TabIndex = 7;
            this.nudSongNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(287, 50);
            this.lblSongName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(42, 15);
            this.lblSongName.TabIndex = 6;
            this.lblSongName.Text = "Name:";
            // 
            // lblSongNumber
            // 
            this.lblSongNumber.AutoSize = true;
            this.lblSongNumber.Location = new System.Drawing.Point(287, 3);
            this.lblSongNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblSongNumber.Name = "lblSongNumber";
            this.lblSongNumber.Size = new System.Drawing.Size(58, 15);
            this.lblSongNumber.TabIndex = 5;
            this.lblSongNumber.Text = "Nummer:";
            // 
            // tbxSongName
            // 
            this.tbxSongName.Location = new System.Drawing.Point(287, 68);
            this.tbxSongName.Name = "tbxSongName";
            this.tbxSongName.Size = new System.Drawing.Size(278, 23);
            this.tbxSongName.TabIndex = 4;
            // 
            // btnSongRemove
            // 
            this.btnSongRemove.Location = new System.Drawing.Point(287, 155);
            this.btnSongRemove.Name = "btnSongRemove";
            this.btnSongRemove.Size = new System.Drawing.Size(100, 23);
            this.btnSongRemove.TabIndex = 2;
            this.btnSongRemove.Text = "Entfernen";
            this.btnSongRemove.UseVisualStyleBackColor = true;
            this.btnSongRemove.Click += new System.EventHandler(this.BtnSongRemove_Click);
            // 
            // btnSongAdd
            // 
            this.btnSongAdd.Location = new System.Drawing.Point(287, 126);
            this.btnSongAdd.Name = "btnSongAdd";
            this.btnSongAdd.Size = new System.Drawing.Size(100, 23);
            this.btnSongAdd.TabIndex = 1;
            this.btnSongAdd.Text = "Hinzufügen";
            this.btnSongAdd.UseVisualStyleBackColor = true;
            this.btnSongAdd.Click += new System.EventHandler(this.BtnSongAdd_Click);
            // 
            // lstSongs
            // 
            this.lstSongs.ItemHeight = 15;
            this.lstSongs.Location = new System.Drawing.Point(3, 3);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(278, 259);
            this.lstSongs.TabIndex = 0;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.LstSongs_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 328);
            this.panel1.TabIndex = 4;
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 328);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.Text = "Einstellungen";
            this.tabMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpSongs.ResumeLayout(false);
            this.tpSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSongNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpSongs;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnSongRemove;
        private System.Windows.Forms.Button btnSongAdd;
        private System.Windows.Forms.NumericUpDown nudSongNumber;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSongNumber;
        private System.Windows.Forms.TextBox tbxSongName;
        private System.Windows.Forms.ComboBox cmbMeetingMidweek;
        private System.Windows.Forms.DateTimePicker dtpMeetingMidweek;
        private System.Windows.Forms.DateTimePicker dtpMeetingWeekend;
        private System.Windows.Forms.ComboBox cmbMeetingWeekend;
        private System.Windows.Forms.Label lblGeneral4;
        private System.Windows.Forms.Label lblGeneral1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGeneral5;
        private System.Windows.Forms.Label lblGeneral2;
        private System.Windows.Forms.Label lblGeneral6;
        private System.Windows.Forms.Label lblGeneral3;
        private System.Windows.Forms.Button btnSongUpdate;
    }
}