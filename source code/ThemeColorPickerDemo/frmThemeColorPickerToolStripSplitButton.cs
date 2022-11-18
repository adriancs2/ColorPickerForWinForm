using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThemeColorPickerDemo
{
    public partial class frmThemeColorPickerToolStripSplitButton : frmBase
    {
        public frmThemeColorPickerToolStripSplitButton()
        {
            InitializeComponent();
            themeColorPickerToolStripSplitButton1.ColorSelected += new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton.colorSelected(themeColorPickerToolStripSplitButton1_ColorSelected);
        }

        void themeColorPickerToolStripSplitButton1_ColorSelected(object sender, ColorSelectedArg e)
        {
            panelColor.BackColor = e.Color;
            txtHex.Text = e.HexColor;
            txtR.Text = e.R.ToString();
            txtG.Text = e.G.ToString();
            txtB.Text = e.B.ToString();
        }

    }
}
