using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThemeColorPickerDemo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btThemeColorPicker_Click(object sender, EventArgs e)
        {
            frmThemeColorPicker f = new frmThemeColorPicker();
            f.Show();
        }

        private void btThemeColorPickerWindow_Click(object sender, EventArgs e)
        {
            frmThemeColorPickerWindow f = new frmThemeColorPickerWindow();
            f.Show();
        }

        private void btToolStripSplitButton_Click(object sender, EventArgs e)
        {
            frmThemeColorPickerToolStripSplitButton f = new frmThemeColorPickerToolStripSplitButton();
            f.Show();
        }
    }
}
