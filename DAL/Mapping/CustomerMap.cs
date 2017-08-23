using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {

        public CustomerMap()
        {

            HasKey(c => c.ID);

            Property(c => c.CompanyName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(co => co.Country)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(ci => ci.City)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(c => c.Address)
                .HasMaxLength(200)
                .IsOptional();


            HasMany(c => c.Contacts)
                .WithRequired(co => co.Customer)
                .HasForeignKey(co => co.CustomerID);

            HasMany(c => c.Projects)
                .WithRequired(p => p.Customer)
                .HasForeignKey(p => p.CustomerID);


        }




    }
}
