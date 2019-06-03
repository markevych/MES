namespace MES.DAL.Configurations
{
    using MES.DAL.Entities.Program;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Topic).WithMany(e => e.Skills).HasForeignKey(e => e.TopicId);
        }
    }
}
