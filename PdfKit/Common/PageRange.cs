using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfKit.Common
{
    public class PageRange
    {
        public int start { get; set; }
        public int end { get; set; }

        public PageRange(int start) : this(start, start)
        {

        }

        public PageRange(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public override string ToString()
        {
            if (start == end)
                return start.ToString();
            return string.Format("{0}-{1}", this.start, this.end);
        }
    }
}
