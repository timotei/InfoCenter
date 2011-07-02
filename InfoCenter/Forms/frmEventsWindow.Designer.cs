namespace InfoCenter.Forms
{
    partial class FrmEventsWindow
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnAvansat = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvansat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(0, 28);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(511, 212);
            this.lista.TabIndex = 0;
            // 
            // btnAvansat
            // 
            this.btnAvansat.Location = new System.Drawing.Point(4, 3);
            this.btnAvansat.Name = "btnAvansat";
            this.btnAvansat.Size = new System.Drawing.Size(75, 23);
            this.btnAvansat.TabIndex = 1;
            this.btnAvansat.Text = "Avansat";
            this.btnAvansat.Click += new System.EventHandler(this.btnAvansat_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(427, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(75, 23);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Închide";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(85, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vezi log-ul";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EventsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 240);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnAvansat);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventsWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evenimente";
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnAvansat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private Telerik.WinControls.UI.RadButton btnAvansat;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}