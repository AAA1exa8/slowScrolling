using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionTest.Models
{
    internal class ExtendedSftpItem
    {
        public string Glyph { get; set; }
        public Item Item { get; set; }

        public ExtendedSftpItem(string glyph, string name, int len)
        {
            Glyph = glyph;
            Item = new Item { Name = name, Length = len };
        }
    }

    internal class Item
    {
        public string Name { get; set; }
        public int Length { get; set; }
    }
}
