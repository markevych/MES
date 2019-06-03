namespace MES.DAL.Entities.Testing
{
    using System;

    public class Answer
    {
        public Guid Id { get; set; }

        public string Instance { get; set; }

        public bool IsCorrect { get; set; }

        public Guid QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
