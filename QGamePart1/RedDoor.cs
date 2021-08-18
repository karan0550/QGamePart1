using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSharmaAssignment2
{
    public class RedDoor : Block
    {
        public RedDoor()
        {
            Image = Properties.Resources.RedDoor;
            ItemType = ItemType.RedDoor;
        }
    }
}
