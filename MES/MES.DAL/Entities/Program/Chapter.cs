namespace MES.DAL.Entities.Program
{
    using System;

    public class Chapter
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
