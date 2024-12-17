using Domain.Enities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess.Configurations
{
    public class TaskEnityConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("Task List");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);

            builder.Property(t => t.Description).HasMaxLength(500);

            builder.Property(t => t.Priority).IsRequired().HasConversion<int>();

            builder.Property(t => t.DeadLine).IsRequired();

            builder.HasIndex(t => t.Title).IsUnique();

        }
    }
}
