namespace Coco.UI
{
    partial class UctMeeting
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flpMeeting = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPersonTiles = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxPersonTiles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // flpMeeting
            // 
            this.flpMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpMeeting.AutoScroll = true;
            this.flpMeeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMeeting.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMeeting.Location = new System.Drawing.Point(0, 26);
            this.flpMeeting.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.flpMeeting.Name = "flpMeeting";
            this.flpMeeting.Size = new System.Drawing.Size(906, 624);
            this.flpMeeting.TabIndex = 2;
            this.flpMeeting.WrapContents = false;
            // 
            // flpPersonTiles
            // 
            this.flpPersonTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPersonTiles.AutoScroll = true;
            this.flpPersonTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPersonTiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPersonTiles.Location = new System.Drawing.Point(909, 26);
            this.flpPersonTiles.Margin = new System.Windows.Forms.Padding(0);
            this.flpPersonTiles.Name = "flpPersonTiles";
            this.flpPersonTiles.Size = new System.Drawing.Size(191, 624);
            this.flpPersonTiles.TabIndex = 4;
            this.flpPersonTiles.WrapContents = false;
            this.flpPersonTiles.Layout += new System.Windows.Forms.LayoutEventHandler(this.FlpPersonTiles_Layout);
            // 
            // cbxPersonTiles
            // 
            this.cbxPersonTiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPersonTiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonTiles.FormattingEnabled = true;
            this.cbxPersonTiles.Location = new System.Drawing.Point(909, 0);
            this.cbxPersonTiles.Name = "cbxPersonTiles";
            this.cbxPersonTiles.Size = new System.Drawing.Size(191, 23);
            this.cbxPersonTiles.TabIndex = 3;
            // 
            // UctMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbxPersonTiles);
            this.Controls.Add(this.flpPersonTiles);
            this.Controls.Add(this.flpMeeting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UctMeeting";
            this.Size = new System.Drawing.Size(1100, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flpMeeting;
        private System.Windows.Forms.FlowLayoutPanel flpPersonTiles;
        private System.Windows.Forms.ComboBox cbxPersonTiles;
    }
}
