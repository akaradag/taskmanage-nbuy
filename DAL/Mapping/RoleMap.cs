using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            Property(r => r.Name)
                .HasMaxLength(50);

            HasMany(r => r.Employees)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID);
        }
    }
}
