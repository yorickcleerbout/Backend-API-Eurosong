﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong
{
    public class Vote
    {
        public int ID { get; private set; }
        public string IP { get; set; }
        public int SongID { get; set; }
        public int Points { get; set; }
    }
}
