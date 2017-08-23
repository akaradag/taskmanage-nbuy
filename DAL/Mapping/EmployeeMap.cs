
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(e => e.ID);

            Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .IsOptional();

            Property(e => e.HireDate)
                .HasColumnType("datetime")
                .IsRequired();

            Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(e => e.Password)
                .HasMaxLength(15)
                .HasColumnType("nchar")
                .IsRequired();

            Property(e => e.RoleID)
                .IsRequired();




        }
    }
}
