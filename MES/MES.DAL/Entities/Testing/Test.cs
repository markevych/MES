namespace MES.DAL.Entities.Testing
{
    using System;
    using System.Collections.Generic;
    using MES.DAL.Entities.Program;

    public class Test
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Guid TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
