using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxes
{
    public class PaperFormats
    {
        public List<Paper> formats;
        public PaperFormats()
        {
            formats = new List<Paper>();
        }
        public void AddFormat(string name, int width, int height)
        {
            formats.Add(new Paper(name, width, height));
        }
    }

    public class Paper
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Paper() { }
        public Paper(string name, int width, int height)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }
    }
}
