namespace MES.DAL.Entities.Program
{
    using System;
    using System.Collections.Generic;

    public class Topic
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int Hours { get; set; }

        public int Grade { get; set; }

        public Guid SubjectId { get; set; }

        public Subject Subject { get; set; }

        public ICollection<Chapter> Chapters { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
