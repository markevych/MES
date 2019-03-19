﻿namespace MES.DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Stream
    {
        public Guid Id { get; set; }

        public int Year { get; set; }

        public ICollection<Direction> Directions { get; set; }
    }
}
