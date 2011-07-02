using System.Windows.Forms;
namespace InfoCenter.Controls
{
    partial class FrmIntrebareTestGroupBox
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
            this.txtRaspuns = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtRaspuns, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtRaspuns
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtRaspuns, 2);
            this.txtRaspuns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaspuns.Location = new System.Drawing.Point(3, 3);
            this.txtRaspuns.MinimumSize = new System.Drawing.Size(100, 100);
            this.txtRaspuns.Multiline = true;
            this.txtRaspuns.Name = "txtRaspuns";
            this.txtRaspuns.Size = new System.Drawing.Size(100, 100);
            this.txtRaspuns.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox.Controls.Add(this.lblIntrebare);
            this.groupBox.Controls.Add(this.tableLayoutPanel1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(5, 5);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(6, 143);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrebare.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIntrebare.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblIntrebare.Location = new System.Drawing.Point(3, 18);
            this.lblIntrebare.MinimumSize = new System.Drawing.Size(0, 16);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(28, 16);
            this.lblIntrebare.TabIndex = 1;
            this.lblIntrebare.Text = "       ";
            // 
            // frmIntrebareTestGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(600, 0);
            this.Name = "frmIntrebareTestGroupBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(16, 153);
            this.SizeChanged += new System.EventHandler(this.IntrebareGroupBox_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox;
        private Label lblIntrebare;
        private TextBox txtRaspuns;

    }
}