﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace 矩形選択と数値入力
{
    public interface IObserver
    {
        void Update(Rectangle rectangle);
    }
}
