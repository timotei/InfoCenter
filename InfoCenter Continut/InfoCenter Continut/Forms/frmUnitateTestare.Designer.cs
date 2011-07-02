namespace InfoCenter.Forms
{
    partial class FrmUnitateTestare
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeTest = new System.Windows.Forms.TextBox();
            this.txtDateIntrare = new System.Windows.Forms.RichTextBox();
            this.txtDateIesire = new System.Windows.Forms.RichTextBox();
            this.btnInchide = new Telerik.WinControls.UI.RadButton();
            this.btnSalveazaInchide = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.04124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.95876F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeTest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDateIntrare, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDateIesire, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume test:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de intrare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de ieşire:";
            // 
            // txtNumeTest
            // 
            this.txtNumeTest.Location = new System.Drawing.Point(108, 3);
            this.txtNumeTest.Name = "txtNumeTest";
            this.txtNumeTest.Size = new System.Drawing.Size(471, 22);
            this.txtNumeTest.TabIndex = 3;
            // 
            // txtDateIntrare
            // 
            this.txtDateIntrare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateIntrare.Location = new System.Drawing.Point(108, 31);
            this.txtDateIntrare.Name = "txtDateIntrare";
            this.txtDateIntrare.Size = new System.Drawing.Size(471, 112);
            this.txtDateIntrare.TabIndex = 4;
            this.txtDateIntrare.Text = "";
            // 
            // txtDateIesire
            // 
            this.txtDateIesire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateIesire.Location = new System.Drawing.Point(108, 149);
            this.txtDateIesire.Name = "txtDateIesire";
            this.txtDateIesire.Size = new System.Drawing.Size(471, 107);
            this.txtDateIesire.TabIndex = 5;
            this.txtDateIesire.Text = "";
            // 
            // btnInchide
            // 
            this.btnInchide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInchide.Location = new System.Drawing.Point(371, 277);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInchide.Size = new System.Drawing.Size(148, 23);
            this.btnInchide.TabIndex = 1;
            this.btnInchide.Text = "Închide";
            this.btnInchide.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btnSalveazaInchide
            // 
            this.btnSalveazaInchide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalveazaInchide.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSalveazaInchide.Location = new System.Drawing.Point(93, 277);
            this.btnSalveazaInchide.Name = "btnSalveazaInchide";
            this.btnSalveazaInchide.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalveazaInchide.Size = new System.Drawing.Size(149, 23);
            this.btnSalveazaInchide.TabIndex = 1;
            this.btnSalveazaInchide.Text = "Salvează şi Închide";
            this.btnSalveazaInchide.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // frmUnitateTestare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalveazaInchide);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUnitateTestare";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    Unitate testare";
            this.ThemeName = "Office2007Blue";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btnInchide;
        private Telerik.WinControls.UI.RadButton btnSalveazaInchide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeTest;
        private System.Windows.Forms.RichTextBox txtDateIntrare;
        private System.Windows.Forms.RichTextBox txtDateIesire;
    }
}