namespace MES.DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Group
    {
        public Guid Id { get; set; }

        public int Grade { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
