﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSharmaAssignment2
{
    public class RedBox : Block
    {
        public RedBox()
        {
            Image = Properties.Resources.RedBox;
            ItemType = ItemType.RedBox;
        }
    }
}
