﻿namespace MES.DAL.Entities
{
    using System;

    public class Student
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }

        public Group Group { get; set; }
    }
}
