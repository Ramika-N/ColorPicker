using System;
using System.Drawing;
using System.Windows.Forms;
using ScreenColorPicker.Helpers;

namespace ScreenColorPicker.Forms
{
    public partial class Form1 : Form
    {
        private Timer pickerTimer;
        private bool isPicking = false;

        public Form1()
        {
            InitializeComponent();
            SetupPickerTimer();
            
            this.KeyPreview = true;
        }
        private void SetupPickerTimer()
        {
            pickerTimer = new Timer();
            pickerTimer.Interval = 20; // ~50 FPS real-time update rate
            pickerTimer.Tick += PickerTimer_Tick;
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            isPicking = true;
            this.Cursor = Cursors.Cross;
            pickerTimer.Start();
        }

        private void PickerTimer_Tick(object sender, EventArgs e)
        {
            if (!isPicking) return;

            Point currentMouse = Cursor.Position;

            Color pickedColor = ColorPickerHelper.GetColorAt(currentMouse);

            pnlPreview.BackColor = pickedColor;
            txtHex.Text = ColorPickerHelper.ColorToHex(pickedColor);

            if (picMagnifier.Image != null)
            {
                picMagnifier.Image.Dispose();
            }
            picMagnifier.Image = ColorPickerHelper.GetMagnifiedImage(currentMouse, picMagnifier.Width, picMagnifier.Height);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (isPicking)
            {
                StopPicking();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape && isPicking)
            {
                StopPicking();
            }
        }

        private void StopPicking()
        {
            isPicking = false;
            pickerTimer.Stop();
            this.Cursor = Cursors.Default;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHex.Text))
            {
                Clipboard.SetText(txtHex.Text);
                MessageBox.Show("HEX Code copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}