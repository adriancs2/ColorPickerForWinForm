namespace ThemeColorPickerDemo
{
    partial class MainMenu
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
            this.btThemeColorPicker = new System.Windows.Forms.Button();
            this.btThemeColorPickerWindow = new System.Windows.Forms.Button();
            this.btToolStripSplitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btThemeColorPicker
            // 
            this.btThemeColorPicker.Location = new System.Drawing.Point(35, 33);
            this.btThemeColorPicker.Name = "btThemeColorPicker";
            this.btThemeColorPicker.Size = new System.Drawing.Size(198, 23);
            this.btThemeColorPicker.TabIndex = 0;
            this.btThemeColorPicker.Text = "ThemeColorPicker";
            this.btThemeColorPicker.UseVisualStyleBackColor = true;
            this.btThemeColorPicker.Click += new System.EventHandler(this.btThemeColorPicker_Click);
            // 
            // btThemeColorPickerWindow
            // 
            this.btThemeColorPickerWindow.Location = new System.Drawing.Point(35, 75);
            this.btThemeColorPickerWindow.Name = "btThemeColorPickerWindow";
            this.btThemeColorPickerWindow.Size = new System.Drawing.Size(198, 23);
            this.btThemeColorPickerWindow.TabIndex = 1;
            this.btThemeColorPickerWindow.Text = "ThemeColorPickerWindow";
            this.btThemeColorPickerWindow.UseVisualStyleBackColor = true;
            this.btThemeColorPickerWindow.Click += new System.EventHandler(this.btThemeColorPickerWindow_Click);
            // 
            // btToolStripSplitButton
            // 
            this.btToolStripSplitButton.Location = new System.Drawing.Point(35, 128);
            this.btToolStripSplitButton.Name = "btToolStripSplitButton";
            this.btToolStripSplitButton.Size = new System.Drawing.Size(198, 23);
            this.btToolStripSplitButton.TabIndex = 3;
            this.btToolStripSplitButton.Text = "ThemeColorPickerToolStripSplitButton";
            this.btToolStripSplitButton.UseVisualStyleBackColor = true;
            this.btToolStripSplitButton.Click += new System.EventHandler(this.btToolStripSplitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 188);
            this.Controls.Add(this.btToolStripSplitButton);
            this.Controls.Add(this.btThemeColorPickerWindow);
            this.Controls.Add(this.btThemeColorPicker);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThemeColorPicker;
        private System.Windows.Forms.Button btThemeColorPickerWindow;
        private System.Windows.Forms.Button btToolStripSplitButton;
    }
}