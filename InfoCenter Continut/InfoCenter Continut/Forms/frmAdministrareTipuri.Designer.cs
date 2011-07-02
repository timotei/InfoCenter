namespace InfoCenter.Forms
{
    partial class FrmAdministrareTipuri
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnTipNou = new Telerik.WinControls.UI.RadButton();
            this.btnAdauga = new Telerik.WinControls.UI.RadButton();
            this.btnSterge = new Telerik.WinControls.UI.RadButton();
            this.btnSaveClose = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTipNou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listă tipuri:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 25);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(185, 133);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(208, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informaţii tip:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(71, 26);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(179, 22);
            this.txtNume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume Tip:";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSave.Location = new System.Drawing.Point(208, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvează tipul";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTipNou
            // 
            this.btnTipNou.Image = global::InfoCenter.Properties.Resources.imgNew16;
            this.btnTipNou.Location = new System.Drawing.Point(347, 102);
            this.btnTipNou.Name = "btnTipNou";
            this.btnTipNou.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTipNou.Size = new System.Drawing.Size(120, 23);
            this.btnTipNou.TabIndex = 3;
            this.btnTipNou.Text = "Tip nou";
            this.btnTipNou.Click += new System.EventHandler(this.btnTipNou_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Image = global::InfoCenter.Properties.Resources.imgAdd16;
            this.btnAdauga.Location = new System.Drawing.Point(208, 135);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdauga.Size = new System.Drawing.Size(125, 23);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adaugă tipul";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Image = global::InfoCenter.Properties.Resources.imgWrong16;
            this.btnSterge.Location = new System.Drawing.Point(347, 135);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSterge.Size = new System.Drawing.Size(120, 23);
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Şterge tipul";
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSaveClose.Location = new System.Drawing.Point(49, 168);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSaveClose.Size = new System.Drawing.Size(128, 23);
            this.btnSaveClose.TabIndex = 4;
            this.btnSaveClose.Text = "   Salvează şi Închide";
            this.btnSaveClose.UseMnemonic = false;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(253, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Închide";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume tip";
            this.columnHeader1.Width = 180;
            // 
            // frmAdministrareTipuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnTipNou);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdministrareTipuri";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "     Administrare tipuri";
            this.ThemeName = "Office2007Blue";
            this.Load += new System.EventHandler(this.frmAdministrareTipuri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTipNou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnTipNou;
        private Telerik.WinControls.UI.RadButton btnAdauga;
        private Telerik.WinControls.UI.RadButton btnSterge;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnSaveClose;
        private Telerik.WinControls.UI.RadButton btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}