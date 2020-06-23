using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToScreen
{
    public class CustomLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.DrawString(Text, Font, solidBrush, new PointF(0, 10));
        }
    }
}
