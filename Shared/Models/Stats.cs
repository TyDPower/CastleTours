﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTours.Shared.Models
{
    public class Stats
    {
        public int Id { get; set; }
        public int Visits { get; set; }
        public DateTime? LastVisit { get; set; }

    }
}