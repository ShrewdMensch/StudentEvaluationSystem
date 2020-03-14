using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEvaluationSystem.Models;

namespace StudentEvaluationSystem.EntityConfiguration
{
    public class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(s => s.Results)
                .WithOne(r => r.Student)
                .HasForeignKey(r => r.StudentId);

            builder.HasMany(s => s.StudentClasses)
               .WithOne(j => j.Student)
               .HasForeignKey(j=>j.StudentId);

            builder.Property(s => s.Promoted)
                .HasDefaultValue(false);

        }
    }
}
