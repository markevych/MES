﻿namespace MES.DAL.Entities.Testing
{
    using System;
    using System.Collections.Generic;

    public class Question
    {
        public Guid Id { get; set; }

        public string Instance { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
