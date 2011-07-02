namespace InfoCenter.Controls
{
    partial class CompilerTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.IsReadOnly = false;
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(550, 381);
            this.txtSource.TabIndex = 2;
            // 
            // CompilerTextBox
            // 
            this.AutoSize = true;
            this.Controls.Add(this.txtSource);
            this.Name = "CompilerTextBox";
            this.Size = new System.Drawing.Size(550, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtSource;


    }
}
