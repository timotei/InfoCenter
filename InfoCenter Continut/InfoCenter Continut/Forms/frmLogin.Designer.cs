namespace InfoCenter.Forms
{
    partial class FrmLogin
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
            this.txtCont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnIntra = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume cont:";
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(80, 89);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(208, 21);
            this.txtCont.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autentificare Info Center Conţinut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parola:";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(80, 115);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(208, 21);
            this.txtParola.TabIndex = 1;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // btnIntra
            // 
            this.btnIntra.Location = new System.Drawing.Point(213, 142);
            this.btnIntra.Name = "btnIntra";
            this.btnIntra.Size = new System.Drawing.Size(75, 23);
            this.btnIntra.TabIndex = 2;
            this.btnIntra.Text = "Intră";
            this.btnIntra.UseVisualStyleBackColor = true;
            this.btnIntra.Click += new System.EventHandler(this.btnIntra_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 191);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status program...";
            this.lblStatus.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIntra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnIntra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare Info Center";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnIntra;
        private System.Windows.Forms.Label lblStatus;
    }
}