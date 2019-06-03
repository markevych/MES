namespace MES.DAL.Configurations
{
    using MES.DAL.Entities.Group;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DirectionConfiguration : IEntityTypeConfiguration<Direction>
    {
        public void Configure(EntityTypeBuilder<Direction> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.DirectionType).WithMany(e => e.Directions).HasForeignKey(e => e.DirectionTypeId);
            builder.HasOne(e => e.Stream).WithMany(e => e.Directions).HasForeignKey(e => e.StreamId);
        }
    }
}
