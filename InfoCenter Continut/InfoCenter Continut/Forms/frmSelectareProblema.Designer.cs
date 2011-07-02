namespace InfoCenter.Forms
{
    partial class FrmSelectareProblema
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
            this.listaProbleme = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdauga = new Telerik.WinControls.UI.RadButton();
            this.txtProbleme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalveaza = new Telerik.WinControls.UI.RadButton();
            this.btnSterge = new Telerik.WinControls.UI.RadButton();
            this.btnInchide = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listaProbleme
            // 
            this.listaProbleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listaProbleme.Location = new System.Drawing.Point(12, 25);
            this.listaProbleme.Name = "listaProbleme";
            this.listaProbleme.Size = new System.Drawing.Size(493, 342);
            this.listaProbleme.TabIndex = 0;
            this.listaProbleme.UseCompatibleStateImageBehavior = false;
            this.listaProbleme.View = System.Windows.Forms.View.Details;
            this.listaProbleme.DoubleClick += new System.EventHandler(this.listaProbleme_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titlu problemă";
            this.columnHeader1.Width = 478;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listă probleme existente:";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Image = global::InfoCenter.Properties.Resources.imgAdd16;
            this.btnAdauga.Location = new System.Drawing.Point(403, 373);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAdauga.Size = new System.Drawing.Size(102, 23);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "    Adaugă în listă";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtProbleme
            // 
            this.txtProbleme.Location = new System.Drawing.Point(12, 392);
            this.txtProbleme.Name = "txtProbleme";
            this.txtProbleme.ReadOnly = true;
            this.txtProbleme.Size = new System.Drawing.Size(373, 22);
            this.txtProbleme.TabIndex = 3;
            this.txtProbleme.TextChanged += new System.EventHandler(this.txtProbleme_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Probleme selectate:";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSalveaza.Location = new System.Drawing.Point(12, 424);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalveaza.Size = new System.Drawing.Size(179, 23);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Salvează şi Închide";
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Image = global::InfoCenter.Properties.Resources.imgWrong16;
            this.btnSterge.Location = new System.Drawing.Point(403, 402);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSterge.Size = new System.Drawing.Size(102, 23);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "   Şterge din listă";
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.Location = new System.Drawing.Point(206, 424);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(179, 23);
            this.btnInchide.TabIndex = 4;
            this.btnInchide.Text = "Închide";
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // frmSelectareProblema
            // 
            this.AllowAeroGlass = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 459);
            this.ControlBox = false;
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.txtProbleme);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaProbleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSelectareProblema";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Selectare problemă";
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnAdauga;
        private System.Windows.Forms.TextBox txtProbleme;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnSalveaza;
        private Telerik.WinControls.UI.RadButton btnSterge;
        private System.Windows.Forms.ListView listaProbleme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Telerik.WinControls.UI.RadButton btnInchide;
    }
}