﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA5BlackBoxReader
{
    interface IMessageStrategy
    {
        List<string> Decode(byte[] byteToDecode);
    }
}




