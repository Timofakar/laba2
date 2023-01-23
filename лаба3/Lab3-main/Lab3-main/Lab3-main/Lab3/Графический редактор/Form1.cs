using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class BitMap : Form
    {
        public BitMap()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        Color DefaultColor { get { return Color.LightGray; } }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i=0; i<width; i++)
            {
                for (int j=0; j<height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            Brush.W = width;
            Brush.H = height;
        }

        int _x, _y;
        bool _mouseClicked = false;
        Color SelectedColor { get { return colorDialog1.Color; } }
        int SelectedSize { get { return tbSizeBrush.Value; } }
        Brush _selectedBrush;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            var form = new AskSizeForm();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void выходКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void btnSpray_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBrush(SelectedColor, SelectedSize);
        }
        private void btnChrist_Click(object sender, EventArgs e)
        {
            _selectedBrush = new ChristBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_mouseDown(object sender, MouseEventArgs e) //btn_swuere?
        {
            if (_selectedBrush == null) { return; }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) { _mouseClicked = false; }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColorChange.BackColor = colorDialog1.Color;
                _selectedBrush.BrushColor = colorDialog1.Color;
            }
        }

        private void tbSizeBrush_Scroll(object sender, EventArgs e)
        {
            if (_selectedBrush != null)
            _selectedBrush.Size = SelectedSize;
        }

        private void btnLastic_Click(object sender, EventArgs e)
        {
            _selectedBrush = new ClearBrush(DefaultColor, SelectedSize);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        
    }
}
