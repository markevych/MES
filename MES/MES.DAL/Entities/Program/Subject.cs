namespace MES.DAL.Entities.Program
{
    using System;
    using System.Collections.Generic;

    public class Subject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int HoursQuantity { get; set; }

        public ICollection<Topic> Topics { get; set; }

        public Guid ProgramId { get; set; }

        public Program Program { get; set; }
    }
}
