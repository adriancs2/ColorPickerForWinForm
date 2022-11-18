using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThemeColorPickerDemo
{
    public partial class frmThemeColorPicker : frmBase
    {
        public frmThemeColorPicker()
        {
            InitializeComponent();
            themeColorPicker1.ColorSelected += themeColorPicker1_ColorSelected;
        }

        void themeColorPicker1_ColorSelected(object sender, ColorSelectedArg e)
        {
            panelColor.BackColor = e.Color;
            txtHex.Text = e.HexColor;
            txtR.Text = e.R.ToString();
            txtG.Text = e.G.ToString();
            txtB.Text = e.B.ToString();
        }
    }
}
