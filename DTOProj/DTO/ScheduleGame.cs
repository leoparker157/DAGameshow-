﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProj
{
    [Serializable]
    public class ScheduleGame

    {
        public string NameGame { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
