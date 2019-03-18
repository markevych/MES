using System;
using System.Collections.Generic;

namespace MES.DAL.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public int Grade { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
