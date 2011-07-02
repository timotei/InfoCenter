namespace InfoCenter.Forms
{
    partial class FrmSelectareTest
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
            this.treeViewTeste = new Telerik.WinControls.UI.RadTreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtTeste = new System.Windows.Forms.TextBox();
            this.btnAdauga = new Telerik.WinControls.UI.RadButton();
            this.btnSterge = new Telerik.WinControls.UI.RadButton();
            this.btnInchide = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewTeste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewTeste
            // 
            this.treeViewTeste.BackColor = System.Drawing.Color.Transparent;
            this.treeViewTeste.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.treeViewTeste.Location = new System.Drawing.Point(12, 20);
            this.treeViewTeste.Name = "treeViewTeste";
            this.treeViewTeste.Size = new System.Drawing.Size(493, 352);
            this.treeViewTeste.TabIndex = 0;
            this.treeViewTeste.Text = "radTreeView1";
            this.treeViewTeste.DoubleClick += new System.EventHandler(this.treeViewTeste_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listă teste:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teste electate:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSave.Location = new System.Drawing.Point(12, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(172, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvează şi închide";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(12, 391);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.ReadOnly = true;
            this.txtTeste.Size = new System.Drawing.Size(374, 21);
            this.txtTeste.TabIndex = 4;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Image = global::InfoCenter.Properties.Resources.imgAdd16;
            this.btnAdauga.Location = new System.Drawing.Point(400, 378);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAdauga.Size = new System.Drawing.Size(105, 23);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "   Adaugă în listă";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Image = global::InfoCenter.Properties.Resources.imgWrong16;
            this.btnSterge.Location = new System.Drawing.Point(400, 405);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSterge.Size = new System.Drawing.Size(105, 23);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "   Şterge din listă";
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.Transparent;
            this.btnInchide.Location = new System.Drawing.Point(190, 429);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(196, 23);
            this.btnInchide.TabIndex = 3;
            this.btnInchide.Text = "Închide";
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // frmSelectareTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 459);
            this.ControlBox = false;
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSelectareTest";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    Selectare teste";
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.treeViewTeste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSterge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView treeViewTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.TextBox txtTeste;
        private Telerik.WinControls.UI.RadButton btnAdauga;
        private Telerik.WinControls.UI.RadButton btnSterge;
        private Telerik.WinControls.UI.RadButton btnInchide;
    }
}