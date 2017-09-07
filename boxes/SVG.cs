using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace boxes
{
    [XmlRoot(ElementName = "svg", Namespace = "http://www.w3.org/2000/svg")]
    public class Svg
    {
        public Svg() { }

        public Svg(string width, string height, string viewBox)
        {
            Rect = new List<Rect>();
            Path = new List<Path>();
            Line = new List<Line>();
            this.ViewBox = viewBox;
            this.Width = width;
            this.Height = height;
        }

        [XmlElement(ElementName = "rect", Namespace = "http://www.w3.org/2000/svg")]
        public List<Rect> Rect { get; set; }
        [XmlElement(ElementName = "path", Namespace = "http://www.w3.org/2000/svg")]
        public List<Path> Path { get; set; }
        [XmlElement(ElementName = "line", Namespace = "http://www.w3.org/2000/svg")]
        public List<Line> Line { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xlink { get; set; }
        [XmlAttribute(AttributeName = "viewBox")]
        public string ViewBox { get; set; }
        [XmlAttribute(AttributeName = "preserveAspectRatio")]
        public string PreserveAspectRatio { get; set; }
    }

    [XmlRoot(ElementName = "rect", Namespace = "http://www.w3.org/2000/svg")]
    public class Rect
    {
        public Rect(){}

        public Rect(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Style = "stroke-width: 1;";
            this.Stroke = "black";
            this.Fill = "none";
        }

        [XmlAttribute(AttributeName = "x")]
        public int X { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public int Y { get; set; }
        [XmlAttribute(AttributeName = "style")]
        public string Style { get; set; }
        [XmlAttribute(AttributeName = "stroke")]
        public string Stroke { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public int Width { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public int Height { get; set; }
        [XmlAttribute(AttributeName = "fill")]
        public string Fill { get; set; }
        [XmlAttribute(AttributeName = "rx")]
        public string Rx { get; set; }
        [XmlAttribute(AttributeName = "ry")]
        public string Ry { get; set; }
    }

    [XmlRoot(ElementName = "path", Namespace = "http://www.w3.org/2000/svg")]
    public class Path
    {
        public Path() { }

        public Path(string d)
        {
            this.Stroke = "black";
            this.Strokewidth = "1";
            this.Fill = "none";
            this.D = d;
        }
        [XmlAttribute(AttributeName = "d")]
        public string D { get; set; }
        [XmlAttribute(AttributeName = "style")]
        public string Style { get; set; }
        [XmlAttribute(AttributeName = "stroke")]
        public string Stroke { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "stroke-width")]
        public string Strokewidth { get; set; }
        [XmlAttribute(AttributeName = "fill")]
        public string Fill { get; set; }
    }

    [XmlRoot(ElementName = "line")]
    public class Line
    {
        public Line() { }
        public Line(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.Strokedasharray = "20, 10";
            this.Stroke = "white";
            this.StrokeWidth = "2";
        }

        [XmlAttribute(AttributeName = "stroke-dasharray")]
        public string Strokedasharray { get; set; }
        [XmlAttribute(AttributeName = "stroke")]
        public string Stroke { get; set; }
        [XmlAttribute(AttributeName = "stroke-width")]
        public string StrokeWidth { get; set; }
        [XmlAttribute(AttributeName = "x1")]
        public int X1 { get; set; }
        [XmlAttribute(AttributeName = "y1")]
        public int Y1 { get; set; }
        [XmlAttribute(AttributeName = "x2")]
        public int X2 { get; set; }
        [XmlAttribute(AttributeName = "y2")]
        public int Y2 { get; set; }
    }
}