namespace ThemeColorPickerDemo
{
    partial class frmThemeColorPickerToolStripSplitButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemeColorPickerToolStripSplitButton));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.themeColorPickerToolStripSplitButton1 = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeColorPickerToolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(452, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // themeColorPickerToolStripSplitButton1
            // 
            this.themeColorPickerToolStripSplitButton1.Color = System.Drawing.Color.White;
            this.themeColorPickerToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeColorPickerToolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("themeColorPickerToolStripSplitButton1.Image")));
            this.themeColorPickerToolStripSplitButton1.ImageHeight = 16;
            this.themeColorPickerToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeColorPickerToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeColorPickerToolStripSplitButton1.ImageWidth = 32;
            this.themeColorPickerToolStripSplitButton1.Name = "themeColorPickerToolStripSplitButton1";
            this.themeColorPickerToolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.themeColorPickerToolStripSplitButton1.Text = "themeColorPickerToolStripSplitButton1";
            // 
            // frmThemeColorPickerToolStripSplitButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 383);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmThemeColorPickerToolStripSplitButton";
            this.Text = "frmThemeColorPickerToolStripSplitButton";
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton1;
    }
}