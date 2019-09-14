namespace Coco.UI
{
    partial class UctPersonTile
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
            this.lblName = new System.Windows.Forms.LinkLabel();
            this.tbxAllocations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 15);
            this.lblName.TabIndex = 0;
            this.lblName.TabStop = true;
            this.lblName.Text = "Maher-Schalal-Hasch-Bas";
            this.lblName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblName_LinkClicked);
            // 
            // tbxAllocations
            // 
            this.tbxAllocations.BackColor = System.Drawing.Color.White;
            this.tbxAllocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAllocations.Location = new System.Drawing.Point(3, 21);
            this.tbxAllocations.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbxAllocations.Multiline = true;
            this.tbxAllocations.Name = "tbxAllocations";
            this.tbxAllocations.ReadOnly = true;
            this.tbxAllocations.Size = new System.Drawing.Size(292, 75);
            this.tbxAllocations.TabIndex = 1;
            this.tbxAllocations.Text = "-\r\n-\r\n-\r\n-\r\n-";
            this.tbxAllocations.WordWrap = false;
            // 
            // UctPersonTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbxAllocations);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UctPersonTile";
            this.Size = new System.Drawing.Size(298, 99);
            this.Load += new System.EventHandler(this.UctPersonTile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblName;
        private System.Windows.Forms.TextBox tbxAllocations;
    }
}
