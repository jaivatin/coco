namespace Coco.UI
{
    partial class UctDocumentElement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastEdited = new System.Windows.Forms.Label();
            this.btnOpenMeeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(351, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Montag, 2. Jän. 2017";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastEdited
            // 
            this.lblLastEdited.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastEdited.Location = new System.Drawing.Point(0, 48);
            this.lblLastEdited.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblLastEdited.Name = "lblLastEdited";
            this.lblLastEdited.Size = new System.Drawing.Size(351, 15);
            this.lblLastEdited.TabIndex = 1;
            this.lblLastEdited.Text = "Bearbeitet: 02.01.2017";
            this.lblLastEdited.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenMeeting
            // 
            this.btnOpenMeeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenMeeting.Enabled = false;
            this.btnOpenMeeting.Location = new System.Drawing.Point(88, 69);
            this.btnOpenMeeting.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnOpenMeeting.Name = "btnOpenMeeting";
            this.btnOpenMeeting.Size = new System.Drawing.Size(175, 23);
            this.btnOpenMeeting.TabIndex = 2;
            this.btnOpenMeeting.Text = "Öffnen";
            this.btnOpenMeeting.UseVisualStyleBackColor = true;
            this.btnOpenMeeting.Click += new System.EventHandler(this.BtnOpenMeeting_Click);
            // 
            // UctDocumentElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLastEdited);
            this.Controls.Add(this.btnOpenMeeting);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(225, 83);
            this.Name = "UctDocumentElement";
            this.Size = new System.Drawing.Size(351, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastEdited;
        private System.Windows.Forms.Button btnOpenMeeting;
    }
}
