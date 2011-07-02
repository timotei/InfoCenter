namespace InfoCenter.Forms
{
    partial class FrmOptiuni
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
            this.components = new System.ComponentModel.Container();
            this.txtQuickSavePath = new System.Windows.Forms.TextBox();
            this.btnCautaQuickSave = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveSettings = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLocatieCPP = new System.Windows.Forms.TextBox();
            this.btnCautaCPP = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatternCPP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDetalii = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCautaQuickSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCautaCPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuickSavePath
            // 
            this.txtQuickSavePath.Location = new System.Drawing.Point(12, 160);
            this.txtQuickSavePath.Name = "txtQuickSavePath";
            this.txtQuickSavePath.Size = new System.Drawing.Size(522, 21);
            this.txtQuickSavePath.TabIndex = 1;
            // 
            // btnCautaQuickSave
            // 
            this.btnCautaQuickSave.Location = new System.Drawing.Point(459, 188);
            this.btnCautaQuickSave.Name = "btnCautaQuickSave";
            this.btnCautaQuickSave.Size = new System.Drawing.Size(75, 23);
            this.btnCautaQuickSave.TabIndex = 0;
            this.btnCautaQuickSave.Text = "Caută";
            this.btnCautaQuickSave.Click += new System.EventHandler(this.btnCautaQuickSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Exe files|*.exe|Command Line|*.cmd|BAT files|*.bat|PowerShell script|*.ps,*.ps1|A" +
                "ll Files|*.exe,*.cmd,*.bat,*.ps1,*.ps";
            this.openFileDialog.Title = "Cauta bcc.exe";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 232);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(135, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Salvează opţiunile";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(459, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Închide";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtLocatieCPP
            // 
            this.txtLocatieCPP.Location = new System.Drawing.Point(12, 36);
            this.txtLocatieCPP.Name = "txtLocatieCPP";
            this.txtLocatieCPP.Size = new System.Drawing.Size(522, 21);
            this.txtLocatieCPP.TabIndex = 6;
            // 
            // btnCautaCPP
            // 
            this.btnCautaCPP.Location = new System.Drawing.Point(459, 64);
            this.btnCautaCPP.Name = "btnCautaCPP";
            this.btnCautaCPP.Size = new System.Drawing.Size(75, 23);
            this.btnCautaCPP.TabIndex = 5;
            this.btnCautaCPP.Text = "Caută";
            this.btnCautaCPP.Click += new System.EventHandler(this.btnCautaBC_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locaţie compilator C++:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Locaţie dosar salvare rapidă:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model argumente compilator (Ex: {0} -o {1} -Wno-deprecated):";
            // 
            // txtPatternCPP
            // 
            this.txtPatternCPP.Location = new System.Drawing.Point(12, 86);
            this.txtPatternCPP.Name = "txtPatternCPP";
            this.txtPatternCPP.Size = new System.Drawing.Size(385, 21);
            this.txtPatternCPP.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(9, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(631, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "_________________________________________________________________________________" +
                "_______________________";
            // 
            // lblDetalii
            // 
            this.lblDetalii.AutoSize = true;
            this.lblDetalii.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalii.Location = new System.Drawing.Point(330, 70);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(36, 13);
            this.lblDetalii.TabIndex = 11;
            this.lblDetalii.TabStop = true;
            this.lblDetalii.Text = "Detalii";
            this.lblDetalii.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDetalii_LinkClicked);
            // 
            // frmOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(571, 267);
            this.ControlBox = false;
            this.Controls.Add(this.lblDetalii);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPatternCPP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuickSavePath);
            this.Controls.Add(this.btnCautaQuickSave);
            this.Controls.Add(this.txtLocatieCPP);
            this.Controls.Add(this.btnCautaCPP);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOptiuni";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opţiuni Info Center";
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnCautaQuickSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCautaCPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox txtQuickSavePath;
        private Telerik.WinControls.UI.RadButton btnCautaQuickSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Telerik.WinControls.UI.RadButton btnSaveSettings;
        private Telerik.WinControls.UI.RadButton btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocatieCPP;
        private Telerik.WinControls.UI.RadButton btnCautaCPP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatternCPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblDetalii;
    }
}