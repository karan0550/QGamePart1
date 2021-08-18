using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGamePart1
{
    public class GreenBox : Block
    {
        public GreenBox()
        {
            Image = Properties.Resources.GreenBox;
            ItemType = ItemType.Wall;
        }
    }
}
