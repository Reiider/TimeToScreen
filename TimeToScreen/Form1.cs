using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToScreen
{
    public partial class Form1 : Form
    {
        Font font;
        CustomLabel label;

        public Form1()
        {
            InitializeComponent();
            
            int widthScreen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int heightScreen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            label = new CustomLabel();
            label.ForeColor = Color.White;
            label.Text = DateTime.Now.ToString("t").ToString();
            Controls.Add(label);
            label.Padding = new Padding(0);
            label.Margin = new Padding(0);
            float pt = (float)(widthScreen * 0.249071);

            font = new Font("Arial Unicode MS", pt);
            label.Font = font;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.Width = widthScreen;

            label.Height = (int)(pt * (widthScreen / (double)heightScreen)*1.1);
            label.Location = new Point(0, (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - label.Height)/2);

            Cursor.Hide(); 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString("t").ToString();
        }
    }
}
