namespace MES.DAL.Entities.Group
{
    using System;
    using System.Collections.Generic;
    using MES.DAL.Enumerations;

    public class DirectionType
    {
        public Guid Id { get; set; }

        public DirectionTypeName Name { get; set; }

        public ICollection<Direction> Directions { get; set; }
    }
}
