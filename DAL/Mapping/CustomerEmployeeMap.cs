
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class CustomerEmployeeMap : EntityTypeConfiguration<CustomerEmployee>
    {

        public CustomerEmployeeMap()
        {
            HasKey(ce => ce.ID);

            Property(ce => ce.FirstName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();


            Property(ce => ce.LastName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(ce => ce.Phone)
                .HasMaxLength(13)
                .HasColumnType("varchar")
                .IsOptional();

            Property(ce => ce.CustomerID)
                .IsRequired();

            //bire çok ilişki var
            HasRequired(ce => ce.Customer)
                .WithMany(c => c.Contacts)
                .HasForeignKey(ce => ce.CustomerID);
        }
    }
}