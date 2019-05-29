namespace MES.DAL.Entities.Program
{
    using System;

    public class Skill
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Guid TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
