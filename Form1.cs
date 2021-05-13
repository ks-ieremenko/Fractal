using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        public int level;
        //Высота и ширина для отрисовки
        private int width, height, i;
        // Bitmap для фрактала
        private Bitmap fractal;
        // используем для отрисовки на PictureBox
        private Graphics graph;
        PointF topPoint, leftPoint, rightPoint, downPoint;
        static Pen pen1, pen2;
        public Form1()
        {
            InitializeComponent();
            width = FractalPictureBox.Width;
            height = FractalPictureBox.Height;
        }

        private void Fractal_1_Click(object sender, EventArgs e)
        {
            fractal = new Bitmap(width, height);
            // cоздаем новый объект Graphics из указанного Bitmap
            graph = Graphics.FromImage(fractal);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            topPoint = new PointF(width / 2f, 0);
            leftPoint = new PointF(0, height);
            rightPoint = new PointF(width, height);
            DrawTriangle(0, topPoint, leftPoint, rightPoint);
            FractalPictureBox.BackgroundImage = fractal;
        }
        private void Fractal_2_Click(object sender, EventArgs e)
        {
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            downPoint = new PointF(width / 2f, height);
            leftPoint = new PointF(0, height / 4f);
            rightPoint = new PointF(width, height / 4f);
            pen1 = new Pen(Color.Blue, 1);
            pen2 = new Pen(Color.White, 2f);
            //Зарисуем треугольник
            graph.DrawLine(pen1, leftPoint, rightPoint);
            graph.DrawLine(pen1, rightPoint, downPoint);
            graph.DrawLine(pen1, downPoint, leftPoint);
            FractalPictureBox.BackgroundImage = fractal;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            level = Convert.ToInt32(numericUpDown1.Value);
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            DrawTriangle(level, topPoint, leftPoint, rightPoint);
            FractalPictureBox.BackgroundImage = fractal;
        }

        
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            i = Convert.ToInt32(numericUpDown2.Value);
            fractal = new Bitmap(width, height);
            graph = Graphics.FromImage(fractal);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.DrawLine(pen1, leftPoint, rightPoint);
            graph.DrawLine(pen1, rightPoint, downPoint);
            graph.DrawLine(pen1, downPoint, leftPoint);
            Fractal(leftPoint, rightPoint, downPoint, i);
            Fractal(rightPoint, downPoint, leftPoint, i);
            Fractal(downPoint, leftPoint, rightPoint, i);
            FractalPictureBox.BackgroundImage = fractal;
        }

        int Fractal(PointF p1, PointF p2, PointF p3, int iter)
        {
            if (iter > 0)  //условие выхода из рекурсии
            {
                //средняя треть отрезка
                var p4 = new PointF((2*p1.X + p2.X) / 3, (2*p1.Y + p2.Y) / 3);
                var p5 = new PointF((2*p2.X + p1.X) / 3, (p1.Y + 2*p2.Y) / 3);
                //координаты вершины угла
                var ps = MidPoint(p2, p1);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                //рисуем его
                graph.DrawLine(pen1, p4, pn);
                graph.DrawLine(pen1, p5, pn);
                graph.DrawLine(pen2, p4, p5);
                graph.DrawLine(pen2, p4, p5);
                //рекурсивно вызываем функцию нужное число раз
                Fractal(p4, pn, p5, iter - 1);
                Fractal(pn, p5, p4, iter - 1);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);
            }
            return iter;
        }
        private void DrawTriangle(int iter, PointF top, PointF left, PointF right)
        {
            //проверяем, закончили ли мы построение
            if (iter == 0)
            {
                PointF[] points = new PointF[3] { top, right, left };
                //рисуем  треугольник
                graph.FillPolygon(Brushes.DarkOrange, points);
            }
            else
            {
                //вычисляем среднюю точку
                var leftMid = MidPoint(top, left); //левая сторона
                var rightMid = MidPoint(top, right); //правая сторона
                var topMid = MidPoint(left, right); // основание
                //рекурсивно вызываем функцию для каждого и 3 треугольников
                DrawTriangle(iter - 1, top, leftMid, rightMid);
                DrawTriangle(iter - 1, leftMid, left, topMid);
                DrawTriangle(iter - 1, rightMid, topMid, right);
            }
        }
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }
        private void clear_Button_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            FractalPictureBox.BackgroundImage = null;
        }
    }
}
