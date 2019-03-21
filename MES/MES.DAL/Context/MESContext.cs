namespace MES.DAL.Context
{
    using MES.DAL.Entities.Program;
    using Microsoft.EntityFrameworkCore;

    public class MESContext : DbContext
    {
        public MESContext(DbContextOptions<MESContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
    }
}
