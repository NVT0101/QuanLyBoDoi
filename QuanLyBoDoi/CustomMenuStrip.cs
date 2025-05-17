using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBoDoi
{
    public class CustomMenuStrip : MenuStrip
    {
        private Color baseColor = Color.FromArgb(33, 150, 243); // Màu xanh dương tươi
        private Color hoverColor = Color.FromArgb(30, 136, 229); // Màu xanh khi hover
        private Color pressedColor = Color.FromArgb(25, 118, 210); // Màu khi nhấn
        private Color textColor = Color.White;

        public CustomMenuStrip()
        {
            this.RenderMode = ToolStripRenderMode.Professional;
            this.BackColor = baseColor;
            this.ForeColor = textColor;
            this.Padding = new Padding(10, 5, 10, 5);
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            this.Renderer = new CustomToolStripRenderer(baseColor, hoverColor, pressedColor, textColor);
        }
    }

    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        private Color baseColor;
        private Color hoverColor;
        private Color pressedColor;
        private Color textColor;

        public CustomToolStripRenderer(Color baseColor, Color hoverColor, Color pressedColor, Color textColor)
        {
            this.baseColor = baseColor;
            this.hoverColor = hoverColor;
            this.pressedColor = pressedColor;
            this.textColor = textColor;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

            if (e.Item.Selected)
            {
                using (SolidBrush brush = new SolidBrush(hoverColor))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            else if (e.Item.Pressed)
            {
                using (SolidBrush brush = new SolidBrush(pressedColor))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(baseColor))
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            // Vẽ separator mỏng màu trắng nhẹ nhàng
            Rectangle rect = new Rectangle(0, 0, e.Item.Width, 1);
            e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            try
            {
                e.TextColor = textColor;
                base.OnRenderItemText(e);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
