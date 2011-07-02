namespace InfoCenter.Forms
{
    partial class FrmDetaliiUnitateTestare
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateIntrare = new System.Windows.Forms.TextBox();
            this.txtDateIesire = new System.Windows.Forms.TextBox();
            this.lblInchide = new System.Windows.Forms.LinkLabel();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNumeUnitate = new System.Windows.Forms.TextBox();
            this.lblCreeaza = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateUtilizator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume test:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date de intrare:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date de ieşire corecte:";
            // 
            // txtDateIntrare
            // 
            this.txtDateIntrare.Location = new System.Drawing.Point(105, 31);
            this.txtDateIntrare.Multiline = true;
            this.txtDateIntrare.Name = "txtDateIntrare";
            this.txtDateIntrare.ReadOnly = true;
            this.txtDateIntrare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDateIntrare.Size = new System.Drawing.Size(208, 70);
            this.txtDateIntrare.TabIndex = 1;
            // 
            // txtDateIesire
            // 
            this.txtDateIesire.Location = new System.Drawing.Point(105, 107);
            this.txtDateIesire.Multiline = true;
            this.txtDateIesire.Name = "txtDateIesire";
            this.txtDateIesire.ReadOnly = true;
            this.txtDateIesire.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDateIesire.Size = new System.Drawing.Size(208, 70);
            this.txtDateIesire.TabIndex = 1;
            // 
            // lblInchide
            // 
            this.lblInchide.AutoSize = true;
            this.lblInchide.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInchide.Location = new System.Drawing.Point(297, 6);
            this.lblInchide.Name = "lblInchide";
            this.lblInchide.Size = new System.Drawing.Size(14, 13);
            this.lblInchide.TabIndex = 2;
            this.lblInchide.TabStop = true;
            this.lblInchide.Text = "X";
            this.lblInchide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInchide_LinkClicked);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(102, 9);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(0, 13);
            this.lblNume.TabIndex = 3;
            // 
            // txtNumeUnitate
            // 
            this.txtNumeUnitate.Location = new System.Drawing.Point(105, 7);
            this.txtNumeUnitate.MaxLength = 250;
            this.txtNumeUnitate.Name = "txtNumeUnitate";
            this.txtNumeUnitate.Size = new System.Drawing.Size(129, 21);
            this.txtNumeUnitate.TabIndex = 4;
            this.txtNumeUnitate.Visible = false;
            // 
            // lblCreeaza
            // 
            this.lblCreeaza.AutoSize = true;
            this.lblCreeaza.Location = new System.Drawing.Point(240, 10);
            this.lblCreeaza.Name = "lblCreeaza";
            this.lblCreeaza.Size = new System.Drawing.Size(47, 13);
            this.lblCreeaza.TabIndex = 5;
            this.lblCreeaza.TabStop = true;
            this.lblCreeaza.Text = "Creează";
            this.lblCreeaza.Visible = false;
            this.lblCreeaza.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreeaza_LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date de ieşire utilizator:";
            // 
            // txtDateUtilizator
            // 
            this.txtDateUtilizator.Location = new System.Drawing.Point(105, 191);
            this.txtDateUtilizator.Multiline = true;
            this.txtDateUtilizator.Name = "txtDateUtilizator";
            this.txtDateUtilizator.ReadOnly = true;
            this.txtDateUtilizator.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDateUtilizator.Size = new System.Drawing.Size(208, 70);
            this.txtDateUtilizator.TabIndex = 1;
            // 
            // FrmDetaliiUnitateTestare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 270);
            this.Controls.Add(this.lblCreeaza);
            this.Controls.Add(this.txtNumeUnitate);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblInchide);
            this.Controls.Add(this.txtDateUtilizator);
            this.Controls.Add(this.txtDateIesire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateIntrare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetaliiUnitateTestare";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetaliiUnitateTestare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateIntrare;
        private System.Windows.Forms.TextBox txtDateIesire;
        private System.Windows.Forms.LinkLabel lblInchide;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNumeUnitate;
        private System.Windows.Forms.LinkLabel lblCreeaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateUtilizator;
    }
}