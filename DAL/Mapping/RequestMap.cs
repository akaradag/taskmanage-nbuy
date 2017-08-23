using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class RequestMap : EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            Property(r => r.Description)
                .HasMaxLength(500);


            Property(r => r.ProjectID)
                .IsRequired();

            Property(r => r.RequestTypeID)
                .IsRequired();



            HasRequired(r => r.Project)
                .WithMany(p => p.Requests)
                .HasForeignKey(r => r.ProjectID);

            HasRequired(r => r.RequestType)
                .WithMany(rt => rt.Requests)
                .HasForeignKey(r => r.RequestTypeID);


        }
    }
}
