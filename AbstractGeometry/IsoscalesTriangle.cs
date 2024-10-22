﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class IsoscalesTriangle:Triangle
    {
        double triangleBase;
        double triangleSide;
        public double TriangleBase
        {
            get => triangleBase;
            set => triangleBase = SizeFilter(value);

        }
        public double TriangleSide
        {
            get=> triangleSide;
            set => triangleSide = SizeFilter(value);
        }
        public IsoscalesTriangle
            (
            double triangleBase,double triangleSide,
            int startX, int startY, int LineWidth,Color color
            ):base(startX, startY, LineWidth, color) 
        {
            TriangleBase = triangleBase;
            TriangleSide = triangleSide;
        }
        public override double GetHeight()=>  Math.Sqrt(Math.Pow(TriangleSide, 2) - Math.Pow(TriangleBase / 2, 2));
        public override double GetArea()=>TriangleBase * GetHeight()/2;
        public override double GetPerimiter()=>TriangleBase + GetHeight()*2;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen =new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX,StartY+(int)TriangleSide),
                new Point(StartX+(int)TriangleBase,StartY+(int)TriangleSide),
                new Point
                (
                    StartX+(int)TriangleBase/2,
                    StartY+(int)TriangleSide-(int)GetHeight()
                    )

            };
            e.Graphics.DrawPolygon(pen, points);
        }


    }
}
