using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            Property(p => p.Name)
                .HasMaxLength(100);

            Property(p => p.CustomerID)
                .IsRequired();

            HasRequired(p => p.Customer)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CustomerID);

        }
    }
}
