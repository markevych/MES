using System;

namespace MES.DAL.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}
