using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.EntityConfiguration
{
    public class CourseConfiguration : EntityTypeConfiguration<Cours>
    {
        public CourseConfiguration()
        {
            ToTable("Courses");
            HasKey(x => x.Id);

            Property(c => c.Description)
                  .IsRequired()
           .HasMaxLength(200);

            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(a => a.AuthorID)
            .WillCascadeOnDelete(false);



            Property(c => c.Name)
           .IsRequired()
           .HasMaxLength(200);

            HasMany(c => c.Tags)
            .WithMany(c => c.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseId");
                m.MapRightKey("TagID");

            });




            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Cours);

        }
    }
}
