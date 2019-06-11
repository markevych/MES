namespace MES.DAL.Entities.Program
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Program
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Subject> Subjects { get; set; }
    }
}
