using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class CustomLabel : Label
    {
        private TextRenderingHint _hint = TextRenderingHint.AntiAlias;
        public TextRenderingHint TextRenderingHint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(e);
        }
    }
}
