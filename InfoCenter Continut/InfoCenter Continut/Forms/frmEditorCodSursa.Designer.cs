namespace InfoCenter.Forms
{
    partial class FrmEditorCodSursa
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
            Telerik.WinControls.Keyboard.InputBinding inputBinding1 = new Telerik.WinControls.Keyboard.InputBinding();
            Telerik.WinControls.Keyboard.Chord chord1 = new Telerik.WinControls.Keyboard.Chord();
            Telerik.WinControls.Keyboard.ChordModifier chordModifier1 = new Telerik.WinControls.Keyboard.ChordModifier();
            Telerik.WinControls.Elements.ClickCommand clickCommand1 = new Telerik.WinControls.Elements.ClickCommand();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.textBox = new ICSharpCode.TextEditor.TextEditorControl();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButton1.Location = new System.Drawing.Point(284, 424);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(170, 23);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Închide";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            chordModifier1.AltModifier = false;
            chordModifier1.ControlModifier = true;
            chordModifier1.ShiftModifier = false;
            chord1.ChordModifier = chordModifier1;
            chord1.Keys = "Ctrl+S";
            inputBinding1.Chord = chord1;
            clickCommand1.ContextType = null;
            clickCommand1.ImageList = null;
            clickCommand1.Name = "ActionCommand";
            clickCommand1.OwnerType = typeof(Telerik.WinControls.RadItem);
            clickCommand1.Text = "This command rises the Click event of a selected RadItem instance.";
            clickCommand1.Type = "";
            inputBinding1.Command = clickCommand1;
            this.radButton2.CommandBindings.AddRange(new Telerik.WinControls.Keyboard.InputBinding[] {
            inputBinding1});
            this.radButton2.Image = global::InfoCenter.Properties.Resources.imgSave16;
            this.radButton2.Location = new System.Drawing.Point(55, 424);
            this.radButton2.Name = "radButton2";
            this.radButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radButton2.Size = new System.Drawing.Size(170, 23);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Salvează şi închide";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.IsReadOnly = false;
            this.textBox.Location = new System.Drawing.Point(1, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(514, 415);
            this.textBox.TabIndex = 2;
            // 
            // frmEditorCodSursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 459);
            this.ControlBox = false;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Name = "frmEditorCodSursa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        Editor cod sursă";
            this.ThemeName = "Office2007Blue";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private ICSharpCode.TextEditor.TextEditorControl textBox;
    }
}