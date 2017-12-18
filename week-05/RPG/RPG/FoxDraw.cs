using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GreenFox
{
    public class FoxDraw
    {
        private const int TILEWIDTH = 50;
        private const int TILEHEIGHT = 50;

        public List<Image> Tiles { get; set; }
        public List<Image> Enemies { get; set; }
        public List<Image> Hero { get; set; }
        public Canvas Canvas { get; set; }
        private SolidColorBrush LineColor { get; set; } = SystemColors.WindowFrameBrush;
        private SolidColorBrush ShapeColor { get; set; } = new SolidColorBrush(Colors.DarkGreen);

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
            Tiles = new List<Image>();
            Hero = new List<Image>();
            Enemies = new List<Image>();
        }

        public void BackgroundColor(Color color)
        {
            Canvas.Background = new SolidColorBrush(color);
        }

        public void StrokeColor(Color color)
        {
            LineColor = new SolidColorBrush(color);
        }

        public void FillColor(Color color)
        {
            ShapeColor = new SolidColorBrush(color);
        }

        public void DrawEllipse(double x, double y, double width, double height)
        {
            var ellipse = new Ellipse()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(ellipse);
            SetPosition(ellipse, x, y);
        }

        public void DrawLine(Point p1, Point p2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = p1.X,
                Y1 = p1.Y,
                X2 = p2.X,
                Y2 = p2.Y
            };

            Canvas.Children.Add(line);
        }

        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };

            Canvas.Children.Add(line);
        }

        public void DrawPolygon(IEnumerable<Point> points)
        {
            var polygon = new Polygon()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Points = ListToPointCollection(points)
            };

            Canvas.Children.Add(polygon);
        }

        public void DrawRectangle(double x, double y, double width, double height)
        {
            var rectangle = new Rectangle()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(rectangle);
            SetPosition(rectangle, x, y);
        }


        public void AddEnemy(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TILEWIDTH,
                Height = TILEHEIGHT,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Enemies.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }
        public void AddHero(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TILEWIDTH,
                Height = TILEHEIGHT,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Hero.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddTile(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TILEWIDTH,
                Height = TILEHEIGHT,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Tiles.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public PointCollection ListToPointCollection(IEnumerable<Point> points)
        {
            var pointCollection = new PointCollection();

            foreach (var point in points)
            {
                pointCollection.Add(point);
            }

            return pointCollection;
        }
    }
}