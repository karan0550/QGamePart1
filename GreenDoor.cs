using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGamePart1
{
    public class GreenDoor : Block
    {
        public GreenDoor()
        {
            Image = Properties.Resources.GreenDoor;
            ItemType = ItemType.Wall;
        }
    }
}
