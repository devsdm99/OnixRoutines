using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OnixLibrary.CustomControls
{
    public partial class FlatOnix : UserControl
    {
        private string _Texto;
        private Image _Imagen;
        public FlatOnix()
        {
            InitializeComponent();
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using ( GraphicsPath GraphPath = GetRoundPath(Rect, 50))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.White, 3.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            cambiarColores(true);
        }

        private void cambiarColores(bool onHover)
        {
            if (onHover)
            {
                if (this.BackColor != Color.FromArgb(255, 100, 83))
                {
                    this.BackColor = Color.FromArgb(255, 100, 83);
                }
            }
            else
            {
                this.BackColor = Color.Coral;
            }
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            cambiarColores(false);
        }

        public Image Imagen {
            get { return this._Imagen; }
            set { _Imagen = value;
                 foto.Image = Imagen;
             }
        }
        public string Texto {
            get{ return this._Texto; }
            set {_Texto = value;
                labelmenu.Text = Texto;
            }
        }

        private void foto_MouseEnter(object sender, EventArgs e)
        {
            cambiarColores(true);
        }

        private void labelmenu_MouseEnter(object sender, EventArgs e)
        {
            cambiarColores(true);
        }

        private void foto_MouseLeave(object sender, EventArgs e)
        {
            cambiarColores(false);
        }

        private void labelmenu_MouseLeave(object sender, EventArgs e)
        {
            cambiarColores(false);
        }

        private void foto_Click(object sender, EventArgs e)
        {

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        private void labelmenu_Click(object sender, EventArgs e)
        {

        }
    }


}
