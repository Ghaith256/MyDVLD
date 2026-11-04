using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Presentation {
    public static class clsFormatHelper {

        public static System.Drawing.Drawing2D.GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius = 10)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void StyleDataGridView(DataGridView dgv)
        {

            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = ColorTranslator.FromHtml("#1f2937");
            dgv.GridColor = Color.Silver;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1f2937");
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#f97316");
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowTemplate.Height = 40;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Nunito", 11F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;
        }

        public static void SunnyStyleButton(UIButton btn, bool isPrimary = true)
        {
            if (btn == null)
                return;

            btn.Style = UIStyle.Custom;

            btn.Font = new Font("Nunito", 11F, FontStyle.Bold);
            btn.Radius = 10;

            if (isPrimary)
            {
                btn.FillColor = ColorTranslator.FromHtml("#F97316");       // لون الخلفية
                btn.FillHoverColor = ColorTranslator.FromHtml("#FB8C3D");  // عند التمرير
                btn.FillPressColor = ColorTranslator.FromHtml("#EA580C");  // عند الضغط
                btn.RectColor = ColorTranslator.FromHtml("#F97316");       // لون الإطار
                btn.RectHoverColor = ColorTranslator.FromHtml("#FB8C3D");
                btn.RectPressColor = ColorTranslator.FromHtml("#EA580C");
                btn.ForeColor = Color.White;                               // لون النص
            }
            else
            {
                btn.FillColor = ColorTranslator.FromHtml("#111827");
                btn.FillHoverColor = ColorTranslator.FromHtml("#1F2937");
                btn.FillPressColor = ColorTranslator.FromHtml("#374151");
                btn.RectColor = ColorTranslator.FromHtml("#F97316");       // إطار برتقالي
                btn.RectHoverColor = ColorTranslator.FromHtml("#FB8C3D");
                btn.RectPressColor = ColorTranslator.FromHtml("#EA580C");
                btn.ForeColor = Color.White;
            }
        }

        public static void StyleButton(Button btn) {
            if (btn == null) 
                return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ColorTranslator.FromHtml("#f97316");
            btn.ForeColor = Color.White;
            btn.Font = new Font("Nunito", 11F, FontStyle.Bold);

            MakeButtonRounded(btn, 15);
        }

        public static void MakeButtonRounded(Button btn, int radius) {
            using (GraphicsPath path = new GraphicsPath()) {
                path.StartFigure();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }

        public static void StyleDateTimePicker(DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd";

            System.Reflection.MethodInfo mi = typeof(Control).GetMethod("SetStyle",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (mi != null)
            {
                mi.Invoke(dtp, new object[] { ControlStyles.UserPaint, true });
            }

            dtp.Paint += (s, e) =>
            {
                e.Graphics.Clear(Color.FromArgb(45, 54, 70));

                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    e.Graphics.DrawString(dtp.Text, dtp.Font, textBrush, 4, 4);
                }

                Rectangle dropButtonRect = new Rectangle(dtp.Width - 20, 0, 20, dtp.Height);
                using (Brush bgBrush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillRectangle(bgBrush, dropButtonRect);
                }

                int arrowX = dtp.Width - 13;
                int arrowY = dtp.Height / 2 - 2;
                Point[] arrow = new Point[]
                {
            new Point(arrowX, arrowY),
            new Point(arrowX + 6, arrowY),
            new Point(arrowX + 3, arrowY + 4)
                };
                using (Brush arrowBrush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillPolygon(arrowBrush, arrow);
                }
            };
        }

        public static void MakePictureBoxCircular(PictureBox pb)
        {
            if (pb == null)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, pb.Width, pb.Height);
                pb.Region = new Region(path);
            }
        }

        public static void MakePictureBoxRoundedCorners(PictureBox pb, int radius)
        {
            if (pb == null)
                return;

            Rectangle rect = new Rectangle(0, 0, pb.Width, pb.Height);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                pb.Region = new Region(path);
            }
        }

        public static void StyleContextMenu(ContextMenuStrip cms, Color? hoverColor = null) {
            if (cms == null) 
                return;

            Color selectedColor = hoverColor ?? Color.FromArgb(249, 115, 22);

            cms.Renderer = new ToolStripProfessionalRenderer(new CustomMenuColors(selectedColor));
            cms.BackColor = Color.FromArgb(12, 22, 50);
            cms.ForeColor = Color.White;
            cms.ShowImageMargin = false;
            cms.ShowCheckMargin = false;
        }

        public class CustomMenuColors : ProfessionalColorTable
        {
            private readonly Color _hoverColor;
            private readonly Color _darkBlue = Color.FromArgb(12, 22, 50);

            public CustomMenuColors(Color hoverColor)
            {
                _hoverColor = hoverColor;
            }

            public override Color MenuItemSelected => _hoverColor;
            public override Color MenuItemSelectedGradientBegin => _hoverColor;
            public override Color MenuItemSelectedGradientEnd => _hoverColor;
            public override Color MenuItemBorder => _hoverColor;
            public override Color MenuBorder => _hoverColor;

            public override Color ToolStripDropDownBackground => _darkBlue;
            public override Color ImageMarginGradientBegin => _darkBlue;
            public override Color ImageMarginGradientMiddle => _darkBlue;
            public override Color ImageMarginGradientEnd => _darkBlue;
        }

        public static void SetControlsColor(Panel pnl, Color textColor, Color iconColor)
        {
            if (pnl == null) return;

            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl is FontAwesome.Sharp.IconPictureBox icon)
                    icon.IconColor = iconColor;
                else if (ctrl is PictureBox pic)
                    pic.ForeColor = iconColor;
                else if (ctrl is Label lbl)
                    lbl.ForeColor = textColor;
            }
        }


    }
}
