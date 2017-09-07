using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxes
{
    public abstract class Template1
    {
        public static Svg Create(int _x, int _y, int _z, int _px, int _py)
        {
            double px = _px / 10.0;
            double py = _py / 10.0;
            string spx = px.ToString(CultureInfo.InvariantCulture) + "cm";
            string spy = py.ToString(CultureInfo.InvariantCulture) + "cm";
            int marginTop = 2 * _z + (_z / 4);

            Svg picture = new Svg(spx, spy, "0 0 " + _px * 10 + " " + _py * 10);

            picture.Rect.Add(new Rect(1, marginTop, _z, _y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X,
                picture.Rect.Last().Y + picture.Rect.Last().Height,
                picture.Rect.Last().X + picture.Rect.Last().Width,
                picture.Rect.Last().Y + picture.Rect.Last().Height));


            int tempX = picture.Rect.Last().X + picture.Rect.Last().Width;
            int tempY = _y - 1;
            picture.Rect.Add(new Rect(tempX, marginTop, _x, tempY - 100));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y + picture.Rect.Last().Height, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y + +picture.Rect.Last().Height));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X, 
                picture.Rect.Last().Y + picture.Rect.Last().Height));
            picture.Line.Add(new Line(
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y + picture.Rect.Last().Height));


            tempX = picture.Rect.Last().X + picture.Rect.Last().Width;
            picture.Rect.Add(new Rect(tempX, marginTop, _z, _y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y + picture.Rect.Last().Height));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X, 
                picture.Rect.Last().Y + picture.Rect.Last().Height, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y + picture.Rect.Last().Height));


            tempX = picture.Rect.Last().X + picture.Rect.Last().Width;
            picture.Rect.Add(new Rect(tempX, marginTop, _x, _y));
            StringBuilder path = new StringBuilder("M ");
            path.Append(picture.Rect.Last().X + (_x / 2 - 75));
            path.Append(' ');
            path.Append(picture.Rect.Last().Y + _y);
            path.Append(" c ");
            path.Append(0);
            path.Append(' ');
            path.Append(-75);
            path.Append(' ');
            path.Append(150);
            path.Append(' ');
            path.Append(-75);
            path.Append(' ');
            path.Append(150);
            path.Append(' ');
            path.Append(0);
            picture.Path.Add(new Path(path.ToString()));
            path.Clear();
            picture.Line.Add(new Line(
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y, 
                picture.Rect.Last().X + picture.Rect.Last().Width, 
                picture.Rect.Last().Y + picture.Rect.Last().Height));


            tempX = picture.Rect.Last().X + picture.Rect.Last().Width;
            picture.Rect.Add(new Rect(tempX, marginTop, _z, _y));

            tempY = picture.Rect[1].Y - _z;
            picture.Rect.Add(new Rect(picture.Rect[1].X, tempY, _x, _z));
            picture.Line.Add(new Line(
                picture.Rect.Last().X + picture.Rect.Last().Width / 10,
                picture.Rect.Last().Y,
                picture.Rect.Last().X + (int)(picture.Rect.Last().Width * 0.9),
                picture.Rect.Last().Y));


            ///////////////////////////////////////////////////////////////////////////////////////////////// Path
            path.Append("M ");
            path.Append(picture.Rect[5].X);
            path.Append(' ');
            path.Append(picture.Rect[5].Y);
            path.Append(" L ");
            path.Append(picture.Rect[5].X);
            path.Append(' ');
            path.Append(picture.Rect[5].Y - 52); ///
            path.Append(" q ");
            path.Append(0);
            path.Append(' ');
            path.Append((_z / 4) * -1);
            path.Append(' ');
            path.Append(_z / 4);
            path.Append(' ');
            path.Append((_z / 4) * -1);
            path.Append(" L ");
            path.Append((picture.Rect[5].X + picture.Rect[5].Width) - _z / 4);
            path.Append(' ');
            path.Append(picture.Rect[5].Y - (_z / 4 + 52));
            path.Append(" q ");
            path.Append(_z / 4);
            path.Append(' ');
            path.Append(0);
            path.Append(' ');
            path.Append(_z / 4);
            path.Append(' ');
            path.Append(_z / 4);
            path.Append(" L ");
            path.Append(picture.Rect[5].X + picture.Rect[5].Width);
            path.Append(' ');
            path.Append(picture.Rect[5].Y);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();
            /////////////////////////////////////////////////////////////////////////////////////////////////

            tempY = picture.Rect[0].Y + picture.Rect[0].Height;
            picture.Rect.Add(new Rect(picture.Rect[1].X, tempY, _x, _z));
            picture.Line.Add(new Line(
                picture.Rect.Last().X,
                picture.Rect.Last().Y,
                picture.Rect.Last().X + picture.Rect.Last().Width,
                picture.Rect.Last().Y));
            picture.Line.Add(new Line(
                picture.Rect.Last().X + picture.Rect.Last().Width / 10,
                picture.Rect.Last().Y + picture.Rect.Last().Height,
                picture.Rect.Last().X + (int)(picture.Rect.Last().Width * 0.9),
                picture.Rect.Last().Y + picture.Rect.Last().Height));

            ///////////////////////////////////////////////////////////////////////////////////////////////// Path
            path.Append("M ");
            path.Append(picture.Rect[6].X);
            path.Append(' ');
            path.Append(picture.Rect[6].Y + picture.Rect[6].Height);
            path.Append(" L ");
            path.Append(picture.Rect[6].X);
            path.Append(' ');
            path.Append((picture.Rect[6].Y + picture.Rect[6].Height + 52));
            path.Append(" q ");
            path.Append(0);
            path.Append(' ');
            path.Append((_z / 4));
            path.Append(' ');
            path.Append(_z / 4);
            path.Append(' ');
            path.Append((_z / 4));
            path.Append(" L ");
            path.Append((picture.Rect[6].X + picture.Rect[6].Width) - (_z / 4));
            path.Append(' ');
            path.Append((picture.Rect[6].Y + picture.Rect[6].Height + (_z / 4 + 52)));
            path.Append(" q ");
            path.Append(_z / 4);
            path.Append(' ');
            path.Append(0);
            path.Append(' ');
            path.Append(_z / 4);
            path.Append(' ');
            path.Append((_z / 4) * -1);
            path.Append(" L ");
            path.Append(picture.Rect[6].X + picture.Rect[5].Width);
            path.Append(' ');
            path.Append(picture.Rect[6].Y + picture.Rect[6].Height);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();
            /////////////////////////////////////////////////////////////////////////////////////////////////

            path.Append("M ");
            path.Append(picture.Rect.First().X);
            path.Append(' ');
            path.Append(picture.Rect.First().Y);
            path.Append(" q 0 ");
            path.Append((_z / 2) * -1);
            path.Append(' ');
            path.Append(_z);
            path.Append(' ');
            path.Append((_z / 2) * -1);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();

            path.Append("M ");
            path.Append(picture.Rect[2].X);
            path.Append(' ');
            path.Append(picture.Rect[2].Y - (_z / 2));
            path.Append(" q ");
            path.Append(_z);
            path.Append(' ');
            path.Append(0);
            path.Append(' ');
            path.Append(_z);
            path.Append(' ');
            path.Append(_z / 2);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();

            path.Append("M ");
            path.Append(picture.Rect[0].X);
            path.Append(' ');
            path.Append(picture.Rect[0].Y + picture.Rect[0].Height);
            path.Append(" q ");
            path.Append(0);
            path.Append(' ');
            path.Append(_z / 2);
            path.Append(' ');
            path.Append(_z);
            path.Append(' ');
            path.Append(_z / 2);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();

            path.Append("M ");
            path.Append(picture.Rect[2].X);
            path.Append(' ');
            path.Append(picture.Rect[2].Y + picture.Rect[0].Height + _z / 2);
            path.Append(" q ");
            path.Append(_z);
            path.Append(' ');
            path.Append(0);
            path.Append(' ');
            path.Append(_z);
            path.Append(' ');
            path.Append((_z / 2) * -1);

            picture.Path.Add(new Path(path.ToString()));
            path.Clear();

            return picture;
        }
    }
}
