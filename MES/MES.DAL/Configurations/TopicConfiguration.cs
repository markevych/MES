namespace MES.DAL.Configurations
{
    using MES.DAL.Entities.Program;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Subject).WithMany(e => e.Topics).HasForeignKey(e => e.SubjectId);
        }
    }
}
