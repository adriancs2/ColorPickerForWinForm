using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThemeColorPickerDemo
{
    public partial class frmThemeColorPickerWindow : frmBase
    {
        public frmThemeColorPickerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point pt = PointToScreen(this.button1.Location);
            ThemeColorPickerWindow f = new ThemeColorPickerWindow(pt, System.Windows.Forms.FormBorderStyle.FixedToolWindow, ThemeColorPickerWindow.Action.CloseWindow, ThemeColorPickerWindow.Action.CloseWindow);
            f.ActionAfterColorSelected = ThemeColorPickerWindow.Action.CloseWindow;
            f.ColorSelected += new ThemeColorPickerWindow.colorSelected(f_ColorSelected);
            f.Show();
        }

        void f_ColorSelected(object sender, ColorSelectedArg e)
        {
            panelColor.BackColor = e.Color;
            txtHex.Text = e.HexColor;
            txtR.Text = e.R.ToString();
            txtG.Text = e.G.ToString();
            txtB.Text = e.B.ToString();
        }
    }
}