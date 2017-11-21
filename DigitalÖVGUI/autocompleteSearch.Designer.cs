namespace DigitalÖVGUI
{
    partial class autocompleteSearch
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
            this.acsInput = new System.Windows.Forms.TextBox();
            this.acsListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // acsInput
            // 
            this.acsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.acsInput.Location = new System.Drawing.Point(0, 0);
            this.acsInput.Margin = new System.Windows.Forms.Padding(4);
            this.acsInput.Name = "acsInput";
            this.acsInput.Size = new System.Drawing.Size(265, 22);
            this.acsInput.TabIndex = 0;
            this.acsInput.TextChanged += new System.EventHandler(this.acsInput_TextChanged);
            this.acsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.acsInput_KeyDown);
            // 
            // acsListbox
            // 
            this.acsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acsListbox.FormattingEnabled = true;
            this.acsListbox.ItemHeight = 16;
            this.acsListbox.Location = new System.Drawing.Point(0, 22);
            this.acsListbox.Margin = new System.Windows.Forms.Padding(4);
            this.acsListbox.Name = "acsListbox";
            this.acsListbox.Size = new System.Drawing.Size(265, 148);
            this.acsListbox.TabIndex = 1;
            this.acsListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.acsListbox_KeyDown);
            // 
            // autocompleteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acsListbox);
            this.Controls.Add(this.acsInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "autocompleteSearch";
            this.Size = new System.Drawing.Size(265, 170);
            this.Load += new System.EventHandler(this.autocompleteSearch_Load);
            this.Leave += new System.EventHandler(this.autocompleteSearch_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acsInput;
        private System.Windows.Forms.ListBox acsListbox;
    }
}
