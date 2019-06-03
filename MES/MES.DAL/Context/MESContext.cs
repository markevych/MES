namespace MES.DAL.Context
{
    using MES.DAL.Entities.Education;
    using MES.DAL.Entities.Group;
    using MES.DAL.Entities.Program;
    using MES.DAL.Entities.Testing;
    using Microsoft.EntityFrameworkCore;

    public class MESContext : DbContext
    {
        public MESContext(DbContextOptions<MESContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<Direction> Directions { get; set; }

        public DbSet<DirectionType> DirectionTypes { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Program> Programs { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Stream> Streams { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Lecture> Lectures { get; set; }
    }
}
