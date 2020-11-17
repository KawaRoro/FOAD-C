using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Defilement
{
    public partial class Defilement : Form
    {
        private System.Drawing.Color colorZone;

        public Defilement()
        {
            InitializeComponent();
            colorZone = Color.FromArgb(0, 0, 0);
        }
        public Defilement(Color _colorValue)
        {
            InitializeComponent();
            colorZone = _colorValue;
            UpdateColorZone();
        }

        /// <summary>
        /// Update zone color
        /// </summary>
        public void UpdateColorZone()
        {
            this.hScrollBarRed.Value = colorZone.R;
            this.numericUpDownRed.Value = colorZone.R;
            this.textBoxRed.BackColor = Color.FromArgb(colorZone.R, 0, 0);

            this.hScrollBarGreen.Value = colorZone.G;
            this.numericUpDownGreen.Value = colorZone.G;
            this.textBoxGreen.BackColor = Color.FromArgb(0, colorZone.G, 0);

            this.hScrollBarBlue.Value = colorZone.B;
            this.numericUpDownBlue.Value = colorZone.B;
            this.textBoxBlue.BackColor = Color.FromArgb(0, 0, colorZone.B);

            textBoxColor.BackColor = colorZone;
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            colorZone = Color.FromArgb(hScrollBarRed.Value, colorZone.G, colorZone.B);
            UpdateColorZone();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            colorZone = Color.FromArgb(colorZone.R, hScrollBarGreen.Value, colorZone.B);
            UpdateColorZone();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            colorZone = Color.FromArgb(colorZone.R, colorZone.G, hScrollBarBlue.Value);
            UpdateColorZone();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            colorZone = Color.FromArgb((int)numericUpDownRed.Value, colorZone.G, colorZone.B);
            UpdateColorZone();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            colorZone = Color.FromArgb(colorZone.R, (int)numericUpDownGreen.Value, colorZone.B);
            UpdateColorZone();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            colorZone = Color.FromArgb(colorZone.R, colorZone.G, (int)numericUpDownBlue.Value);
            UpdateColorZone();
        }

    }
}
