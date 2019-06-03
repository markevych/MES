namespace MES.DAL.Entities.Group
{
    using System;
    using System.Collections.Generic;

    public class Direction
    {
        public Guid Id { get; set; }

        public Guid DirectionTypeId { get; set; }

        public DirectionType DirectionType { get; set; }

        public Guid StreamId { get; set; }

        public Stream Stream { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
