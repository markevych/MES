namespace MES.DAL.Entities.Group
{
    using System;
    using System.Collections.Generic;

    public class Group
    {
        public Guid Id { get; set; }

        public int Grade { get; set; }

        public Guid DirectionId { get; set; }

        public Direction Direction { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
