using System;
using System.Collections.Generic;

namespace MES.DAL.Entities
{
    public class Stream
    {
        public Guid Id { get; set; }
        public int Year { get; set; }

        public ICollection<Direction> Directions { get; set; }
    }
}
