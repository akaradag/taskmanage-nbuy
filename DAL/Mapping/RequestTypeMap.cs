using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class RequestTypeMap : EntityTypeConfiguration<RequestType>
    {
        public RequestTypeMap()
        {
            Property(rt => rt.Name)
                .HasMaxLength(50);

            HasMany(rt => rt.Requests)
                .WithRequired(r => r.RequestType)
                .HasForeignKey(r => r.RequestTypeID);

        }
    }
}
