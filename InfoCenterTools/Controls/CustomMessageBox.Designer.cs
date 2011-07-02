namespace InfoCenter.Controls
{
    sealed partial class CustomMessageBox
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnDa = new Telerik.WinControls.UI.RadButton();
            this.btnNu = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Location = new System.Drawing.Point(25, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(43, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "deeeee";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDa
            // 
            this.btnDa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDa.Location = new System.Drawing.Point(92, 65);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(75, 23);
            this.btnDa.TabIndex = 1;
            this.btnDa.Text = "Da";
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNu
            // 
            this.btnNu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNu.Location = new System.Drawing.Point(250, 65);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(75, 23);
            this.btnNu.TabIndex = 1;
            this.btnNu.Text = "Nu";
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(419, 93);
            this.ControlBox = false;
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private Telerik.WinControls.UI.RadButton btnDa;
        private Telerik.WinControls.UI.RadButton btnNu;
    }
}