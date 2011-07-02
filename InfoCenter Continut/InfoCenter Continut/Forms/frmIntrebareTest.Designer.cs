namespace InfoCenter.Forms
{
    partial class FrmIntrebareTest
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
            this.btnInchide = new Telerik.WinControls.UI.RadButton();
            this.btnSalveazaInchide = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntrebare = new System.Windows.Forms.RichTextBox();
            this.txtPuncte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRaspunsCorect = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaInchide)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInchide
            // 
            this.btnInchide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInchide.Location = new System.Drawing.Point(333, 298);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(133, 23);
            this.btnInchide.TabIndex = 10;
            this.btnInchide.Text = "Închide";
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // btnSalveazaInchide
            // 
            this.btnSalveazaInchide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalveazaInchide.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.btnSalveazaInchide.Location = new System.Drawing.Point(118, 299);
            this.btnSalveazaInchide.Name = "btnSalveazaInchide";
            this.btnSalveazaInchide.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalveazaInchide.Size = new System.Drawing.Size(132, 23);
            this.btnSalveazaInchide.TabIndex = 9;
            this.btnSalveazaInchide.Text = "   Salvează şi închide";
            this.btnSalveazaInchide.Click += new System.EventHandler(this.btnSalveazaInchide_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIntrebare, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPuncte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRaspunsCorect, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 283);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Întrebare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Răspuns corect:";
            // 
            // txtIntrebare
            // 
            this.txtIntrebare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIntrebare.Location = new System.Drawing.Point(139, 3);
            this.txtIntrebare.Name = "txtIntrebare";
            this.txtIntrebare.Size = new System.Drawing.Size(443, 112);
            this.txtIntrebare.TabIndex = 1;
            this.txtIntrebare.Text = "";
            // 
            // txtPuncte
            // 
            this.txtPuncte.Location = new System.Drawing.Point(139, 249);
            this.txtPuncte.Name = "txtPuncte";
            this.txtPuncte.Size = new System.Drawing.Size(61, 20);
            this.txtPuncte.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Puncte:";
            // 
            // richTextBox1
            // 
            this.txtRaspunsCorect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaspunsCorect.Location = new System.Drawing.Point(139, 121);
            this.txtRaspunsCorect.Name = "richTextBox1";
            this.txtRaspunsCorect.Size = new System.Drawing.Size(443, 122);
            this.txtRaspunsCorect.TabIndex = 2;
            this.txtRaspunsCorect.Text = "";
            // 
            // frmIntrebareTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 333);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.btnSalveazaInchide);
            this.Name = "frmIntrebareTest";
            // 
            // 
            // 
            this.ShowIcon = false;
            this.ShowInTaskbar = false;            
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "       Întrebare Test";
            this.ThemeName = "Office2007Blue";
            this.Load += new System.EventHandler(frmIntrebareTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalveazaInchide)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnInchide;
        private Telerik.WinControls.UI.RadButton btnSalveazaInchide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtIntrebare;
        private System.Windows.Forms.TextBox txtPuncte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtRaspunsCorect;
    }
}