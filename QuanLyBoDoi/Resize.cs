using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBoDoi
{
    partial class MainForm
    {
        private float _originalWidth;
        private float _originalHeight;

        private Dictionary<Control, ControlOriginalState> _originalStates = new();

        // Lưu ImageList gốc của ListView (key: ListView control)
        private Dictionary<ListView, (ImageList small, ImageList large)> _originalImageLists = new();


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_SETREDRAW = 0x000B;

        private void BeginUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        private void EndUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            this.Refresh();
        }
        /// <summary>
        /// Gọi lại khi muốn cập nhật trạng thái gốc (ví dụ reload dữ liệu, tạo control mới)
        /// </summary>
        public void SaveOriginalStates(Control parent)
        {
            _originalStates.Clear();
            _originalImageLists.Clear();

            foreach (Control ctrl in GetAllControls(parent))
            {
                _originalStates[ctrl] = new ControlOriginalState
                {
                    Left = ctrl.Left,
                    Top = ctrl.Top,
                    Width = ctrl.Width,
                    Height = ctrl.Height,
                    FontSize = ctrl.Font.Size,
                    FontName = ctrl.Font.Name,
                    FontStyle = ctrl.Font.Style
                };

                if (ctrl is ListView lv)
                {
                    _originalImageLists[lv] = (lv.SmallImageList, lv.LargeImageList);
                }
            }
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                yield return ctrl;
                foreach (var child in GetAllControls(ctrl))
                    yield return child;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            resizeTimer.Start();
            
        }

        private void ScaleAllControls(Control parent, float scaleX, float scaleY)
        {
            parent.SuspendLayout();
            foreach (Control ctrl in parent.Controls)
            {
                if (_originalStates.TryGetValue(ctrl, out var original))
                {
                    // Scale vị trí & kích thước với min size 10x10
                    ctrl.Left = (int)(original.Left * scaleX);
                    ctrl.Top = (int)(original.Top * scaleY);
                    ctrl.Width = Math.Max(10, (int)(original.Width * scaleX));
                    ctrl.Height = Math.Max(10, (int)(original.Height * scaleY));

                    // Scale font với min size 6pt
                    float scaleFont = Math.Min(scaleX, scaleY);
                    float newFontSize = Math.Max(6f, original.FontSize * scaleFont);
                    ctrl.Font = new Font(original.FontName, newFontSize, original.FontStyle);

                    // DataGridView
                    if (ctrl is DataGridView dgv)
                    {
                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            col.Width = Math.Max(10, (int)(col.Width * scaleX));
                        }
                        dgv.RowTemplate.Height = Math.Max(10, (int)(dgv.RowTemplate.Height * scaleY));
                    }
                    // ListView
                    else if (ctrl is ListView lv)
                    {
                        foreach (ColumnHeader colHeader in lv.Columns)
                        {
                            colHeader.Width = Math.Max(10, (int)(colHeader.Width * scaleX));
                        }

                        // Scale ImageList từ bản gốc
                        if (_originalImageLists.TryGetValue(lv, out var lists))
                        {
                            if (lists.small != null)
                            {
                                lv.SmallImageList = ScaleImageList(lists.small, scaleX, scaleY);
                            }
                            if (lists.large != null)
                            {
                                lv.LargeImageList = ScaleImageList(lists.large, scaleX, scaleY);
                            }
                        }
                    }
                    // TabControl
                    else if (ctrl is TabControl tab)
                    {
                        if (tab.SizeMode == TabSizeMode.Fixed)
                        {
                            int newItemHeight = Math.Max(10, (int)(tab.ItemSize.Height * scaleY));
                            int newItemWidth = Math.Max(10, (int)(tab.ItemSize.Width * scaleX));
                            tab.ItemSize = new Size(newItemWidth, newItemHeight);
                        }
                    }
                }

                if (ctrl.Controls.Count > 0)
                    ScaleAllControls(ctrl, scaleX, scaleY);
            }
            parent.ResumeLayout();
        }

        private ImageList ScaleImageList(ImageList originalList, float scaleX, float scaleY)
        {
            int newWidth = Math.Max(1, (int)(originalList.ImageSize.Width * scaleX));
            int newHeight = Math.Max(1, (int)(originalList.ImageSize.Height * scaleY));

            ImageList newList = new ImageList();
            newList.ColorDepth = originalList.ColorDepth;
            newList.ImageSize = new Size(newWidth, newHeight);

            foreach (Image img in originalList.Images)
            {
                Bitmap bmp = new Bitmap(img, newWidth, newHeight);
                newList.Images.Add(bmp);
            }

            return newList;
        }
        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            resizeTimer.Stop();

            BeginUpdate();

            float scaleX = (float)this.Width / _originalWidth;
            float scaleY = (float)this.Height / _originalHeight;

            ScaleAllControls(this, scaleX, scaleY);

            EndUpdate();
        }

        private class ControlOriginalState
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
            public float FontSize;
            public string FontName;
            public FontStyle FontStyle;
        }
    }
}
