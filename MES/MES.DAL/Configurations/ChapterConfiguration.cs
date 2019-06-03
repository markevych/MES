namespace MES.DAL.Configurations
{
    using MES.DAL.Entities.Program;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Topic).WithMany(e => e.Chapters).HasForeignKey(e => e.TopicId);
        }
    }
}
