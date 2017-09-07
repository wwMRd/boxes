using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxes
{
    public class Configuration
    {
        public Configuration() { }
        public Configuration(PaperFormats paperFormats)
        {
            this.paperFormats = paperFormats;
        }
        public PaperFormats paperFormats { get; set; }
    }
}
