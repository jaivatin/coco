using System.Windows.Forms;

namespace Coco.UI
{
    partial class FrmCoco
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miSwitchCongregation = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblCongregation = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPublishers = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMinisterialServants = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOverseers = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPioneers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpPersons = new System.Windows.Forms.TabPage();
            this.uctPerson = new Coco.UI.UctPerson();
            this.tpDocuments = new System.Windows.Forms.TabPage();
            this.uctDocument = new Coco.UI.UctDocument();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpPersons.SuspendLayout();
            this.tpDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMenu,
            this.miSettings});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1234, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // miMenu
            // 
            this.miMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miMenu.Name = "miMenu";
            this.miMenu.Size = new System.Drawing.Size(50, 20);
            this.miMenu.Text = "&Menü";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(125, 22);
            this.miExit.Text = "&Schließen";
            this.miExit.Click += new System.EventHandler(this.MIExit_Click);
            // 
            // miSettings
            // 
            this.miSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSwitchCongregation,
            this.miShowSettings});
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(90, 20);
            this.miSettings.Text = "&Einstellungen";
            // 
            // miSwitchCongregation
            // 
            this.miSwitchCongregation.Name = "miSwitchCongregation";
            this.miSwitchCongregation.Size = new System.Drawing.Size(210, 22);
            this.miSwitchCongregation.Text = "&Versammlung Wechseln...";
            this.miSwitchCongregation.Click += new System.EventHandler(this.MISwitchCongregation_Click);
            // 
            // miShowSettings
            // 
            this.miShowSettings.Name = "miShowSettings";
            this.miShowSettings.Size = new System.Drawing.Size(210, 22);
            this.miShowSettings.Text = "&Einstellungen...";
            this.miShowSettings.Click += new System.EventHandler(this.MIShowSettings_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCongregation,
            this.lblPublishers,
            this.lblMinisterialServants,
            this.lblOverseers,
            this.lblPioneers});
            this.ssMain.Location = new System.Drawing.Point(0, 739);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1234, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 2;
            // 
            // lblCongregation
            // 
            this.lblCongregation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongregation.Name = "lblCongregation";
            this.lblCongregation.Size = new System.Drawing.Size(868, 17);
            this.lblCongregation.Spring = true;
            this.lblCongregation.Text = "Versammlung Soundso";
            this.lblCongregation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPublishers
            // 
            this.lblPublishers.Name = "lblPublishers";
            this.lblPublishers.Size = new System.Drawing.Size(94, 17);
            this.lblPublishers.Text = "Verkündiger: 0    ";
            // 
            // lblMinisterialServants
            // 
            this.lblMinisterialServants.Name = "lblMinisterialServants";
            this.lblMinisterialServants.Size = new System.Drawing.Size(128, 17);
            this.lblMinisterialServants.Text = "Dienstamtgehilfen: 0    ";
            // 
            // lblOverseers
            // 
            this.lblOverseers.Name = "lblOverseers";
            this.lblOverseers.Size = new System.Drawing.Size(67, 17);
            this.lblOverseers.Text = "Älteste: 0    ";
            // 
            // lblPioneers
            // 
            this.lblPioneers.Name = "lblPioneers";
            this.lblPioneers.Size = new System.Drawing.Size(62, 17);
            this.lblPioneers.Text = "Pioniere: 0";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpPersons);
            this.tabMain.Controls.Add(this.tpDocuments);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1234, 715);
            this.tabMain.TabIndex = 1;
            // 
            // tpPersons
            // 
            this.tpPersons.Controls.Add(this.uctPerson);
            this.tpPersons.Location = new System.Drawing.Point(4, 24);
            this.tpPersons.Name = "tpPersons";
            this.tpPersons.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersons.Size = new System.Drawing.Size(1226, 687);
            this.tpPersons.TabIndex = 0;
            this.tpPersons.Text = "Personen";
            this.tpPersons.UseVisualStyleBackColor = true;
            // 
            // uctPerson
            // 
            this.uctPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctPerson.Location = new System.Drawing.Point(3, 3);
            this.uctPerson.Name = "uctPerson";
            this.uctPerson.Size = new System.Drawing.Size(1220, 681);
            this.uctPerson.TabIndex = 0;
            // 
            // tpDocuments
            // 
            this.tpDocuments.Controls.Add(this.uctDocument);
            this.tpDocuments.Location = new System.Drawing.Point(4, 24);
            this.tpDocuments.Name = "tpDocuments";
            this.tpDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tpDocuments.Size = new System.Drawing.Size(1226, 687);
            this.tpDocuments.TabIndex = 1;
            this.tpDocuments.Text = "Dokumente";
            this.tpDocuments.UseVisualStyleBackColor = true;
            // 
            // uctDocument
            // 
            this.uctDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctDocument.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctDocument.Location = new System.Drawing.Point(3, 3);
            this.uctDocument.Name = "uctDocument";
            this.uctDocument.Size = new System.Drawing.Size(1220, 681);
            this.uctDocument.TabIndex = 0;
            // 
            // FrmCoco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FrmCoco";
            this.Text = "Coco";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tpPersons.ResumeLayout(false);
            this.tpDocuments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miMenu;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripMenuItem miSwitchCongregation;
        private StatusStrip ssMain;
        private ToolStripStatusLabel lblCongregation;
        private ToolStripMenuItem miShowSettings;
        private TabControl tabMain;
        private TabPage tpPersons;
        private TabPage tpDocuments;
        private ToolStripStatusLabel lblPublishers;
        private ToolStripStatusLabel lblMinisterialServants;
        private ToolStripStatusLabel lblOverseers;
        private ToolStripStatusLabel lblPioneers;
        private UctDocument uctDocument;
        private UctPerson uctPerson;
    }
}
