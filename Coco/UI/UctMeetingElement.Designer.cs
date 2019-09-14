namespace Coco.UI
{
    partial class UctMeetingElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.tbxPerson = new System.Windows.Forms.TextBox();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.cbxIsUpTo = new System.Windows.Forms.CheckBox();
            this.tbxPartner = new System.Windows.Forms.TextBox();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.msCme = new System.Windows.Forms.MenuStrip();
            this.miCmeNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCmeRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.miLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.miCmeAddAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.miCmeAddBelow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.msCme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(53, 0);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(50, 23);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2017, 1, 2, 0, 0, 0, 0);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(175, 0);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(300, 23);
            this.tbxTitle.TabIndex = 4;
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(175, 0);
            this.cmbTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(300, 23);
            this.cmbTitle.TabIndex = 5;
            // 
            // tbxPerson
            // 
            this.tbxPerson.Location = new System.Drawing.Point(478, 0);
            this.tbxPerson.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tbxPerson.Name = "tbxPerson";
            this.tbxPerson.ReadOnly = true;
            this.tbxPerson.Size = new System.Drawing.Size(200, 23);
            this.tbxPerson.TabIndex = 6;
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(653, 1);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(24, 21);
            this.btnEditPerson.TabIndex = 7;
            this.btnEditPerson.Text = "...";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(122, 0);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(50, 23);
            this.nudDuration.TabIndex = 3;
            // 
            // cbxIsUpTo
            // 
            this.cbxIsUpTo.Location = new System.Drawing.Point(106, 1);
            this.cbxIsUpTo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cbxIsUpTo.Name = "cbxIsUpTo";
            this.cbxIsUpTo.Size = new System.Drawing.Size(13, 23);
            this.cbxIsUpTo.TabIndex = 2;
            this.cbxIsUpTo.UseVisualStyleBackColor = true;
            // 
            // tbxPartner
            // 
            this.tbxPartner.Location = new System.Drawing.Point(681, 0);
            this.tbxPartner.Margin = new System.Windows.Forms.Padding(0);
            this.tbxPartner.Name = "tbxPartner";
            this.tbxPartner.ReadOnly = true;
            this.tbxPartner.Size = new System.Drawing.Size(200, 23);
            this.tbxPartner.TabIndex = 8;
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.Location = new System.Drawing.Point(856, 1);
            this.btnEditPartner.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(24, 21);
            this.btnEditPartner.TabIndex = 9;
            this.btnEditPartner.Text = "...";
            this.btnEditPartner.UseVisualStyleBackColor = true;
            this.btnEditPartner.Click += new System.EventHandler(this.BtnEditPartner_Click);
            // 
            // msCme
            // 
            this.msCme.AutoSize = false;
            this.msCme.BackColor = System.Drawing.Color.Transparent;
            this.msCme.Dock = System.Windows.Forms.DockStyle.None;
            this.msCme.GripMargin = new System.Windows.Forms.Padding(0);
            this.msCme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCmeNumber});
            this.msCme.Location = new System.Drawing.Point(0, 0);
            this.msCme.Name = "msCme";
            this.msCme.Padding = new System.Windows.Forms.Padding(0);
            this.msCme.Size = new System.Drawing.Size(50, 23);
            this.msCme.Stretch = false;
            this.msCme.TabIndex = 0;
            this.msCme.Text = "msMeetingElement";
            // 
            // miCmeNumber
            // 
            this.miCmeNumber.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miCmeNumber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCmeAddAbove,
            this.miCmeAddBelow,
            this.miLine1,
            this.miLine2,
            this.miCmeRemove});
            this.miCmeNumber.Name = "miCmeNumber";
            this.miCmeNumber.Padding = new System.Windows.Forms.Padding(0);
            this.miCmeNumber.Size = new System.Drawing.Size(20, 23);
            this.miCmeNumber.Text = "1.";
            // 
            // miLine1
            // 
            this.miLine1.Name = "miLine1";
            this.miLine1.Size = new System.Drawing.Size(231, 6);
            // 
            // miCmeRemove
            // 
            this.miCmeRemove.Name = "miCmeRemove";
            this.miCmeRemove.Size = new System.Drawing.Size(234, 22);
            this.miCmeRemove.Text = "Element entfernen";
            this.miCmeRemove.Click += new System.EventHandler(this.MICmeRemove_Click);
            // 
            // miLine2
            // 
            this.miLine2.Name = "miLine2";
            this.miLine2.Size = new System.Drawing.Size(231, 6);
            // 
            // miCmeAddAbove
            // 
            this.miCmeAddAbove.Name = "miCmeAddAbove";
            this.miCmeAddAbove.Size = new System.Drawing.Size(234, 22);
            this.miCmeAddAbove.Text = "Element oberhalb hinzufügen";
            this.miCmeAddAbove.Click += new System.EventHandler(this.MICmeAddAbove_Click);
            // 
            // miCmeAddBelow
            // 
            this.miCmeAddBelow.Name = "miCmeAddBelow";
            this.miCmeAddBelow.Size = new System.Drawing.Size(234, 22);
            this.miCmeAddBelow.Text = "Element unterhalb hinzufügen";
            this.miCmeAddBelow.Click += new System.EventHandler(this.MICmeAddBelow_Click);
            // 
            // UctMeetingElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnEditPartner);
            this.Controls.Add(this.tbxPartner);
            this.Controls.Add(this.cbxIsUpTo);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.tbxPerson);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.msCme);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UctMeetingElement";
            this.Size = new System.Drawing.Size(881, 23);
            this.Load += new System.EventHandler(this.UctMeetingElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.msCme.ResumeLayout(false);
            this.msCme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.TextBox tbxPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.CheckBox cbxIsUpTo;
        private System.Windows.Forms.TextBox tbxPartner;
        private System.Windows.Forms.Button btnEditPartner;
        private System.Windows.Forms.MenuStrip msCme;
        private System.Windows.Forms.ToolStripMenuItem miCmeNumber;
        private System.Windows.Forms.ToolStripSeparator miLine1;
        private System.Windows.Forms.ToolStripMenuItem miCmeRemove;
        private System.Windows.Forms.ToolStripSeparator miLine2;
        private System.Windows.Forms.ToolStripMenuItem miCmeAddAbove;
        private System.Windows.Forms.ToolStripMenuItem miCmeAddBelow;
    }
}
