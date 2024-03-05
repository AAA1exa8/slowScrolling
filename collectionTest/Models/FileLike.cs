using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionTest.Models
{
    internal class FileLike
    {
        public string Type { get; set; }
        public Item Item { get; set; }

        public FileLike(string glyph, string name, int len)
        {
            Type = glyph;
            Item = new Item { Name = name, Length = len };
        }
    }

    internal class Item
    {
        public string Name { get; set; }
        public int Length { get; set; }
    }
}
