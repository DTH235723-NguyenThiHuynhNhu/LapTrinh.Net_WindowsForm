using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7._5
{
    public partial class Form1 : Form
    {

        bool drawing = false;
        Point startPoint, endPoint;
        Color borderColor = Color.Blue;
        Color fillColor = Color.Red;
        int borderSize = 2;
        string shapeType = "Filled Ellipse";

        public Form1()
        {
            InitializeComponent();

            cboHinhve.Items.AddRange(new string[]
           {
                "Line", "Rectangle", "Ellipse", "Filled Rectangle", "Filled Ellipse"
           });
            cboHinhve.SelectedIndex = 4;

            // Thêm kích thước nét vẽ
            for (int i = 1; i <= 10; i++) cbosize.Items.Add(i);
            cbosize.SelectedIndex = 1;

            picBorderColor.BackColor = borderColor;
            picFillColor.BackColor = fillColor;

            // Gắn sự kiện cho Panel
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseUp += panelDraw_MouseUp;
            panelDraw.MouseMove += panelDraw_MouseMove;
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            startPoint = e.Location;
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            endPoint = e.Location;
            DrawShape(panelDraw.CreateGraphics());
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
                endPoint = e.Location;
        }
        private void DrawShape(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderSize);
            Brush brush = new SolidBrush(fillColor);

            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int w = Math.Abs(startPoint.X - endPoint.X);
            int h = Math.Abs(startPoint.Y - endPoint.Y);

            switch (shapeType)
            {
                case "Line":
                    g.DrawLine(pen, startPoint, endPoint);
                    break;
                case "Rectangle":
                    g.DrawRectangle(pen, x, y, w, h);
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, x, y, w, h);
                    break;
                case "Filled Rectangle":
                    g.FillRectangle(brush, x, y, w, h);
                    g.DrawRectangle(pen, x, y, w, h);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, x, y, w, h);
                    g.DrawEllipse(pen, x, y, w, h);
                    break;
            }
        }

        private void picBorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                borderColor = dlg.Color;
                picBorderColor.BackColor = borderColor;
            }
        }

        private void picFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fillColor = dlg.Color;
                picFillColor.BackColor = fillColor;
            }
        }

        private void cboHinhve_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeType = cboHinhve.SelectedItem.ToString();
        }

        private void cbosize_SelectedIndexChanged(object sender, EventArgs e)
        {
            borderSize = int.Parse(cbosize.SelectedItem.ToString());
        }
    }
}
