﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly_2019
{
    interface IObserver
    {
        void UpdatePosition(int position, string name);
        void UpdateMoney(double money, string name);
        void UpdateProperty(List<Abs_Box> propreties, Board board);
    }
}
