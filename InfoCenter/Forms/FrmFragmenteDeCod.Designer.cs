namespace InfoCenter.Forms
{
    partial class FrmFragmenteDeCod
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
            this.listaCodeSnippets = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodSursa = new InfoCenter.Controls.CompilerTextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFragment = new Telerik.WinControls.UI.RadButton();
            this.btnDeleteFragment = new Telerik.WinControls.UI.RadButton();
            this.btnNewFragment = new Telerik.WinControls.UI.RadButton();
            this.btnInsertFragment = new Telerik.WinControls.UI.RadButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFragment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFragment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewFragment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertFragment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listaCodeSnippets
            // 
            this.listaCodeSnippets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listaCodeSnippets.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaCodeSnippets.FullRowSelect = true;
            this.listaCodeSnippets.GridLines = true;
            this.listaCodeSnippets.Location = new System.Drawing.Point(0, 0);
            this.listaCodeSnippets.Name = "listaCodeSnippets";
            this.listaCodeSnippets.ShowGroups = false;
            this.listaCodeSnippets.Size = new System.Drawing.Size(218, 459);
            this.listaCodeSnippets.TabIndex = 0;
            this.listaCodeSnippets.UseCompatibleStateImageBehavior = false;
            this.listaCodeSnippets.View = System.Windows.Forms.View.Details;
            this.listaCodeSnippets.SelectedIndexChanged += new System.EventHandler(this.listaCodeSnippets_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titlu";
            this.columnHeader1.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodSursa);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtTitlu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveFragment);
            this.groupBox1.Controls.Add(this.btnDeleteFragment);
            this.groupBox1.Controls.Add(this.btnNewFragment);
            this.groupBox1.Controls.Add(this.btnInsertFragment);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(216, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii fragment de cod:";
            // 
            // txtCodSursa
            // 
            this.txtCodSursa.AutoSize = true;
            this.txtCodSursa.Location = new System.Drawing.Point(10, 89);
            this.txtCodSursa.Name = "txtCodSursa";
            this.txtCodSursa.Size = new System.Drawing.Size(440, 254);
            this.txtCodSursa.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(47, 41);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(383, 21);
            this.txtAutor.TabIndex = 1;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(47, 18);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(383, 21);
            this.txtTitlu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod sursă:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titlu: ";
            // 
            // btnSaveFragment
            // 
            this.btnSaveFragment.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSaveFragment.Location = new System.Drawing.Point(9, 349);
            this.btnSaveFragment.Name = "btnSaveFragment";
            this.btnSaveFragment.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSaveFragment.Size = new System.Drawing.Size(154, 23);
            this.btnSaveFragment.TabIndex = 3;
            this.btnSaveFragment.Text = "Salvează fragmentul";
            this.btnSaveFragment.Click += new System.EventHandler(this.btnSaveFragment_Click);
            // 
            // btnDeleteFragment
            // 
            this.btnDeleteFragment.Image = global::InfoCenter.Properties.Resources.imgWrong16;
            this.btnDeleteFragment.Location = new System.Drawing.Point(10, 378);
            this.btnDeleteFragment.Name = "btnDeleteFragment";
            this.btnDeleteFragment.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDeleteFragment.Size = new System.Drawing.Size(154, 23);
            this.btnDeleteFragment.TabIndex = 4;
            this.btnDeleteFragment.Text = "Şterge fragmentul";
            this.btnDeleteFragment.Click += new System.EventHandler(this.btnDeleteFragment_Click);
            // 
            // btnNewFragment
            // 
            this.btnNewFragment.Image = global::InfoCenter.Properties.Resources.imgAdd16;
            this.btnNewFragment.Location = new System.Drawing.Point(290, 349);
            this.btnNewFragment.Name = "btnNewFragment";
            this.btnNewFragment.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnNewFragment.Size = new System.Drawing.Size(154, 23);
            this.btnNewFragment.TabIndex = 5;
            this.btnNewFragment.Text = "Creează fragment nou";
            this.btnNewFragment.Click += new System.EventHandler(this.btnNewFragment_Click);
            // 
            // btnInsertFragment
            // 
            this.btnInsertFragment.Image = global::InfoCenter.Properties.Resources.addCodSursa32;
            this.btnInsertFragment.Location = new System.Drawing.Point(151, 411);
            this.btnInsertFragment.Name = "btnInsertFragment";
            this.btnInsertFragment.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnInsertFragment.Size = new System.Drawing.Size(169, 36);
            this.btnInsertFragment.TabIndex = 6;
            this.btnInsertFragment.Text = "    Inserează fragmentul";
            this.btnInsertFragment.Click += new System.EventHandler(this.btnInsertFragment_Click);
            // 
            // FrmFragmenteDeCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaCodeSnippets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmFragmenteDeCod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Fragmente de cod";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFragment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFragment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewFragment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsertFragment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaCodeSnippets;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnSaveFragment;
        private Telerik.WinControls.UI.RadButton btnNewFragment;
        private Telerik.WinControls.UI.RadButton btnInsertFragment;
        private InfoCenter.Controls.CompilerTextBox txtCodSursa;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnDeleteFragment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}