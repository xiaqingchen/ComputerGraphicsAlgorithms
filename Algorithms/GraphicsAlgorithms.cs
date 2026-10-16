using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerGraphicsAlgorithms.Models;

namespace ComputerGraphicsAlgorithms.Algorithms
{
    public static class GraphicsAlgorithms
    {
        // =========================================================
        // 1. 点
        // =========================================================
        public static List<PixelPoint> DrawPoint(int x, int y)
        {
            List<PixelPoint> points = new List<PixelPoint>();

            points.Add(new PixelPoint(x, y));

            return points;
        }


        // =========================================================
        // 2. DDA直线算法
        // =========================================================
        public static List<PixelPoint> DDA(
            int x0, int y0,
            int x1, int y1)
        {
            List<PixelPoint> points = new List<PixelPoint>();

            int dx = x1 - x0;
            int dy = y1 - y0;

            int steps = Math.Max(
                Math.Abs(dx),
                Math.Abs(dy));

            if (steps == 0)
            {
                points.Add(new PixelPoint(x0, y0));
                return points;
            }

            double xIncrement =
                (double)dx / steps;

            double yIncrement =
                (double)dy / steps;

            double x = x0;
            double y = y0;

            for (int i = 0; i <= steps; i++)
            {
                points.Add(
                    new PixelPoint(
                        (int)Math.Round(x),
                        (int)Math.Round(y)));

                x += xIncrement;
                y += yIncrement;
            }

            return points;
        }


        // =========================================================
        // 3. 中点画线算法
        // =========================================================
        public static List<PixelPoint> MidpointLine(
            int x0, int y0,
            int x1, int y1)
        {
            List<PixelPoint> points =
                new List<PixelPoint>();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            int x = x0;
            int y = y0;

            if (dx >= dy)
            {
                int d = 2 * dy - dx;

                for (int i = 0; i <= dx; i++)
                {
                    points.Add(
                        new PixelPoint(x, y));

                    if (d < 0)
                    {
                        d += 2 * dy;
                    }
                    else
                    {
                        y += sy;
                        d += 2 * (dy - dx);
                    }

                    x += sx;
                }
            }
            else
            {
                int d = 2 * dx - dy;

                for (int i = 0; i <= dy; i++)
                {
                    points.Add(
                        new PixelPoint(x, y));

                    if (d < 0)
                    {
                        d += 2 * dx;
                    }
                    else
                    {
                        x += sx;
                        d += 2 * (dx - dy);
                    }

                    y += sy;
                }
            }

            return points;
        }


        // =========================================================
        // 4. Bresenham直线算法
        // =========================================================
        public static List<PixelPoint> BresenhamLine(
            int x0, int y0,
            int x1, int y1)
        {
            List<PixelPoint> points =
                new List<PixelPoint>();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            int err = dx - dy;

            int x = x0;
            int y = y0;

            while (true)
            {
                points.Add(
                    new PixelPoint(x, y));

                if (x == x1 && y == y1)
                {
                    break;
                }

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }

            return points;
        }


        // =========================================================
        // 5. 中点画圆算法
        // =========================================================
        public static List<PixelPoint> MidpointCircle(
            int xc,
            int yc,
            int radius)
        {
            List<PixelPoint> points =
                new List<PixelPoint>();

            if (radius < 0)
            {
                return points;
            }

            int x = 0;
            int y = radius;

            int d = 1 - radius;

            while (x <= y)
            {
                AddCirclePoints(
                    points,
                    xc,
                    yc,
                    x,
                    y);

                if (d < 0)
                {
                    d += 2 * x + 3;
                }
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }

                x++;
            }

            return points;
        }


        // =========================================================
        // 6. Bresenham画圆算法
        // =========================================================
        public static List<PixelPoint> BresenhamCircle(
            int xc,
            int yc,
            int radius)
        {
            List<PixelPoint> points =
                new List<PixelPoint>();

            if (radius < 0)
            {
                return points;
            }

            int x = 0;
            int y = radius;

            int d = 3 - 2 * radius;

            while (x <= y)
            {
                AddCirclePoints(
                    points,
                    xc,
                    yc,
                    x,
                    y);

                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }

                x++;
            }

            return points;
        }


        // =========================================================
        // 圆的八对称点
        // =========================================================
        private static void AddCirclePoints(
            List<PixelPoint> points,
            int xc,
            int yc,
            int x,
            int y)
        {
            points.Add(
                new PixelPoint(
                    xc + x,
                    yc + y));

            points.Add(
                new PixelPoint(
                    xc - x,
                    yc + y));

            points.Add(
                new PixelPoint(
                    xc + x,
                    yc - y));

            points.Add(
                new PixelPoint(
                    xc - x,
                    yc - y));

            points.Add(
                new PixelPoint(
                    xc + y,
                    yc + x));

            points.Add(
                new PixelPoint(
                    xc - y,
                    yc + x));

            points.Add(
                new PixelPoint(
                    xc + y,
                    yc - x));

            points.Add(
                new PixelPoint(
                    xc - y,
                    yc - x));
        }


        // =========================================================
        // 7. 中点椭圆算法
        // =========================================================
        public static List<PixelPoint> MidpointEllipse(
            int xc,
            int yc,
            int a,
            int b)
        {
            List<PixelPoint> points =
                new List<PixelPoint>();

            if (a <= 0 || b <= 0)
            {
                return points;
            }

            double a2 = a * a;
            double b2 = b * b;

            double x = 0;
            double y = b;

            double d1 =
                b2
                - a2 * b
                + 0.25 * a2;

            // 第一区域
            while (b2 * x < a2 * y)
            {
                AddEllipsePoints(
                    points,
                    xc,
                    yc,
                    (int)Math.Round(x),
                    (int)Math.Round(y));

                if (d1 < 0)
                {
                    x++;

                    d1 +=
                        2 * b2 * x
                        + b2;
                }
                else
                {
                    x++;
                    y--;

                    d1 +=
                        2 * b2 * x
                        - 2 * a2 * y
                        + b2;
                }
            }

            // 第二区域
            double d2 =
                b2 * Math.Pow(x + 0.5, 2)
                + a2 * Math.Pow(y - 1, 2)
                - a2 * b2;

            while (y >= 0)
            {
                AddEllipsePoints(
                    points,
                    xc,
                    yc,
                    (int)Math.Round(x),
                    (int)Math.Round(y));

                if (d2 > 0)
                {
                    y--;

                    d2 +=
                        a2
                        - 2 * a2 * y;
                }
                else
                {
                    x++;
                    y--;

                    d2 +=
                        2 * b2 * x
                        - 2 * a2 * y
                        + a2;
                }
            }

            return points;
        }


        // =========================================================
        // 椭圆四对称点
        // =========================================================
        private static void AddEllipsePoints(
            List<PixelPoint> points,
            int xc,
            int yc,
            int x,
            int y)
        {
            points.Add(
                new PixelPoint(
                    xc + x,
                    yc + y));

            points.Add(
                new PixelPoint(
                    xc - x,
                    yc + y));

            points.Add(
                new PixelPoint(
                    xc + x,
                    yc - y));

            points.Add(
                new PixelPoint(
                    xc - x,
                    yc - y));
        }
    }
}
