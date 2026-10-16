using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ComputerGraphicsAlgorithms.Algorithms;
using ComputerGraphicsAlgorithms.Models;

namespace ComputerGraphicsAlgorithms
{
    public partial class MainForm : Form
    {
        private Bitmap canvas;


        // =========================================================
        // 构造函数
        // =========================================================

        public MainForm()
        {
            InitializeComponent();

            canvas = new Bitmap(
                pnlCanvas.Width,
                pnlCanvas.Height);

            ClearCanvas();

            // 绑定按钮事件
            btnPoint.Click += btnPoint_Click;

            btnDDA.Click += btnDDA_Click;

            btnMidpointLine.Click +=
                btnMidpointLine_Click;

            btnBresenhamLine.Click +=
                btnBresenhamLine_Click;

            btnMidpointCircle.Click +=
                btnMidpointCircle_Click;

            btnBresenhamCircle.Click +=
                btnBresenhamCircle_Click;

            btnEllipse.Click +=
                btnEllipse_Click;

            btnClear.Click +=
                btnClear_Click;
        }


        // =========================================================
        // 清空画布
        // =========================================================

        private void ClearCanvas()
        {
            using (Graphics g =
                   Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
            }

            pnlCanvas.Invalidate();
        }


        // =========================================================
        // 将算法得到的像素点显示出来
        // =========================================================

        private void DrawPoints(
            List<PixelPoint> points)
        {
            foreach (PixelPoint point in points)
            {
                if (point.X >= 0 &&
                    point.X < canvas.Width &&
                    point.Y >= 0 &&
                    point.Y < canvas.Height)
                {
                    canvas.SetPixel(
                        point.X,
                        point.Y,
                        Color.Black);
                }
            }

            pnlCanvas.Invalidate();
        }


        // =========================================================
        // Panel绘制
        // =========================================================

        private void pnlCanvas_Paint(
            object sender,
            PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                canvas,
                0,
                0);
        }


        // =========================================================
        // 生成点
        // =========================================================

        private void btnPoint_Click(
            object sender,
            EventArgs e)
        {
            int x =
                int.Parse(txtX0.Text);

            int y =
                int.Parse(txtY0.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.DrawPoint(
                    x,
                    y);

            DrawPoints(points);
        }


        // =========================================================
        // DDA
        // =========================================================

        private void btnDDA_Click(
            object sender,
            EventArgs e)
        {
            int x0 =
                int.Parse(txtX0.Text);

            int y0 =
                int.Parse(txtY0.Text);

            int x1 =
                int.Parse(txtX1.Text);

            int y1 =
                int.Parse(txtY1.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.DDA(
                    x0,
                    y0,
                    x1,
                    y1);

            DrawPoints(points);
        }


        // =========================================================
        // 中点画线
        // =========================================================

        private void btnMidpointLine_Click(
            object sender,
            EventArgs e)
        {
            int x0 =
                int.Parse(txtX0.Text);

            int y0 =
                int.Parse(txtY0.Text);

            int x1 =
                int.Parse(txtX1.Text);

            int y1 =
                int.Parse(txtY1.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.MidpointLine(
                    x0,
                    y0,
                    x1,
                    y1);

            DrawPoints(points);
        }


        // =========================================================
        // Bresenham直线
        // =========================================================

        private void btnBresenhamLine_Click(
            object sender,
            EventArgs e)
        {
            int x0 =
                int.Parse(txtX0.Text);

            int y0 =
                int.Parse(txtY0.Text);

            int x1 =
                int.Parse(txtX1.Text);

            int y1 =
                int.Parse(txtY1.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.BresenhamLine(
                    x0,
                    y0,
                    x1,
                    y1);

            DrawPoints(points);
        }


        // =========================================================
        // 中点画圆
        // =========================================================

        private void btnMidpointCircle_Click(
            object sender,
            EventArgs e)
        {
            int xc =
                int.Parse(txtX0.Text);

            int yc =
                int.Parse(txtY0.Text);

            int radius =
                int.Parse(txtRadius.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.MidpointCircle(
                    xc,
                    yc,
                    radius);

            DrawPoints(points);
        }


        // =========================================================
        // Bresenham画圆
        // =========================================================

        private void btnBresenhamCircle_Click(
            object sender,
            EventArgs e)
        {
            int xc =
                int.Parse(txtX0.Text);

            int yc =
                int.Parse(txtY0.Text);

            int radius =
                int.Parse(txtRadius.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.BresenhamCircle(
                    xc,
                    yc,
                    radius);

            DrawPoints(points);
        }


        // =========================================================
        // 中点椭圆
        // =========================================================

        private void btnEllipse_Click(
            object sender,
            EventArgs e)
        {
            int xc =
                int.Parse(txtX0.Text);

            int yc =
                int.Parse(txtY0.Text);

            int a =
                int.Parse(txtA.Text);

            int b =
                int.Parse(txtB.Text);

            List<PixelPoint> points =
                GraphicsAlgorithms.MidpointEllipse(
                    xc,
                    yc,
                    a,
                    b);

            DrawPoints(points);
        }


        // =========================================================
        // 清空
        // =========================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearCanvas();
        }
    }
}
